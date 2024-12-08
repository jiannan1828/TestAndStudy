using System.Windows.Forms;
using DxfDatas;
using netDxf;
using netDxf.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DxfReader
{
    public partial class Frm_Main : Form
    {
        public DxfDocument DxfDoc = new DxfDocument();
        public Dxf.Json Json  = new Dxf.Json();
        public double minX, minY, maxX, maxY, width, height;

        private System.Drawing.Image buddha;
        private System.Drawing.Image buddhaText;

        private OpenFileDialog OpenDXFFileDialog = new OpenFileDialog();

        private float ZoomFactor = 1;

        private PointF Offset = new PointF(0, 0);
        private PointF PrevMousePos = new PointF(0, 0);
        private PointF RealMousePos = new PointF(0, 0);
        private PointF RealMousePosBeforeZoom = new PointF(0, 0);
        private PointF RealMousePosAfterZoom = new PointF(0, 0);

        private double Mouse2CircleDistance;
        private Dxf.Json.Circle HighlightedCircle = null;
        private int PrevHighlightedRow;
        private bool IsHighlightedRow = false;


        public Frm_Main()
        {
            InitializeComponent();
        }

        private void pic_DxfDatas_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.ScaleTransform(ZoomFactor, ZoomFactor);
            e.Graphics.TranslateTransform(Offset.X / ZoomFactor, Offset.Y / ZoomFactor); // 拖曳圖片轉換座標

            try
            {
                foreach (var circle in Json.Circles)
                {
                    Brush fillBrush = new SolidBrush(Color.ForestGreen); // 預設顏色

                    RectangleF rectangleF = new RectangleF(
                        (float)(circle.X * 10 - circle.Diameter / 2 * 10),
                        (float)(circle.Y * 10 - circle.Diameter / 2 * 10),
                        (float)(2 * circle.Diameter / 2 * 10),
                        (float)(2 * circle.Diameter / 2 * 10)
                    );

                    if (circle == HighlightedCircle)
                    {
                        fillBrush = new SolidBrush(Color.LightBlue);
                    }

                    e.Graphics.FillEllipse(fillBrush, rectangleF);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pic_DxfDatas_MouseMove(object sender, MouseEventArgs e)
        {
            RealMousePos.X = (e.X - Offset.X) / ZoomFactor / 10;
            RealMousePos.Y = (e.Y - Offset.Y) / ZoomFactor / 10;

            lbl_MousePos.Text = $"真實座標 : {RealMousePos.X}, {RealMousePos.Y}";

            // 左鍵拖曳
            if (e.Button == MouseButtons.Left)
            {
                // 計算滑鼠移動的差值
                Offset.X += e.X - PrevMousePos.X;
                Offset.Y += e.Y - PrevMousePos.Y;

                PrevMousePos = e.Location; // 拖曳當中隨時紀錄當下滑鼠在 PictureBox 上的位置, 不以左鍵點擊當下的位置
            }

            // 鼠標與圓的距離判斷是否高量
            HighlightedCircle = null; // 每一次移動滑鼠都必須重新判斷是否需要高量
            int index = 0; // datagridview 的索引行遍歷

            foreach (var circle in Json.Circles)
            {
                // 计算鼠标位置与圆心的距离
                Mouse2CircleDistance = Math.Sqrt(
                    Math.Pow((e.X - Offset.X) / 10 / ZoomFactor - circle.X, 2) +
                    Math.Pow((e.Y - Offset.Y) / 10 / ZoomFactor - circle.Y, 2)
                );

                if (Mouse2CircleDistance <= circle.Diameter / 2)
                {
                    if (IsHighlightedRow == true)
                    {
                        dgv_Dxf.Rows[PrevHighlightedRow].DefaultCellStyle.BackColor = SystemColors.Window;
                    }

                    HighlightedCircle = circle; // 記錄高亮的圓              
                    dgv_Dxf.Rows[index].DefaultCellStyle.BackColor = SystemColors.Highlight;  // 高亮 datagridview 該列               
                    dgv_Dxf.FirstDisplayedScrollingRowIndex = index;// 設置自動捲動到該列

                    PrevHighlightedRow = index; // 紀錄上一次被highlight過的列
                    IsHighlightedRow = true;

                    break;
                }

                index++;
            }

            pic_Dxf.Refresh();
        }

        private void pic_DxfDatas_MouseWheel(object sender, MouseEventArgs e)
        {

            // 滑鼠在 PictureBox 上的位置對應的真實座標（縮放前）
            RealMousePosBeforeZoom.X = (e.X - Offset.X) / ZoomFactor;
            RealMousePosBeforeZoom.Y = (e.Y - Offset.Y) / ZoomFactor;

            if (e.Delta > 0)
            {
                ZoomFactor *= 1.1f; // 滾輪向上，放大
            }
            else if (e.Delta < 0)
            {
                if (ZoomFactor > 1) // 最小就 1 倍
                {
                    ZoomFactor /= 1.1f; // 滾輪向下，縮小
                }
            }

            // 滑鼠在 PictureBox 上的位置對應的真實座標（縮放後）
            RealMousePosAfterZoom.X = (e.X - Offset.X) / ZoomFactor;
            RealMousePosAfterZoom.Y = (e.Y - Offset.Y) / ZoomFactor;

            // 根據縮放前後的真實座標差異調整偏移量
            Offset.X += (RealMousePosAfterZoom.X - RealMousePosBeforeZoom.X) * ZoomFactor;
            Offset.Y += (RealMousePosAfterZoom.Y - RealMousePosBeforeZoom.Y) * ZoomFactor;

            pic_Dxf.Refresh();
        }

        private void pic_DxfDatas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PrevMousePos = e.Location;
            }
        }

        private void dgv_DxfDatas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // 獲取行的範圍
            var rowHeaderBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dgv_Dxf.RowHeadersWidth,
                e.RowBounds.Height
            );

            // 繪製行號
            e.Graphics.DrawString(
                (e.RowIndex + 1).ToString(), // 行號從 1 開始
                dgv_Dxf.Font,
                SystemBrushes.ControlText,
                rowHeaderBounds,
                new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                }
            );
        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDXFFileDialog.Filter = "DXF Files (*.dxf)|*.dxf";

            if (OpenDXFFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DxfDoc = DxfDocument.Load(OpenDXFFileDialog.FileName);
                    MessageBox.Show($"檔案 {OpenDXFFileDialog.FileName} 成功讀取！");

                    Dxf.transform_Dxf2Json(DxfDoc, out Json);

                    Dxf.show_dgv_Dxf(dgv_Dxf, Json);

                    Dxf.find_Dxf_bounds(Json, out minX, out minY, out maxX, out maxY, out width, out height);

                    ZoomFactor = Math.Min(pic_Dxf.Width / 10 / (float)width, pic_Dxf.Height / 10 / (float)height);
                    Offset.X = -(float)minX * 10 * ZoomFactor;
                    Offset.Y = -(float)minY * 10 * ZoomFactor;

                    pic_Dxf.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}");
                }
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            buddha = System.Drawing.Image.FromFile(@"..\..\..\Images\Buddha.png");
            buddhaText = System.Drawing.Image.FromFile(@"..\..\..\Images\BuddhaText.png");
        }

        private void Frm_Main_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(buddhaText, new Rectangle(1290, 500, 300, 300));
            e.Graphics.DrawImage(buddha, new Rectangle(1300, 650, 300, 300));
        }
    }
}
