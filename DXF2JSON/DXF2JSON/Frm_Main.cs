using System.Windows.Forms;
using DXF2JSON;
using netDxf;
using netDxf.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Training7
{
    public partial class Frm_Main : Form
    {
        public DxfDocument dxfDoc = new DxfDocument();
        public double minX, minY, maxX, maxY;

        private OpenFileDialog openDXFFileDialog = new OpenFileDialog();

        private bool zoomHasChanged = true;
        private float zoomFactor = 1;

        private PointF offset = new PointF(0, 0);
        private PointF prevMousePos = new PointF(0, 0);
        private PointF realMousePos = new PointF(0, 0);

        private double mouse2CircleDistance;
        private Circle highlightedCircle = null;
        private int prevHighlightedRow;
        private bool isHighlightedRow = false;


        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_OpenDXFFile_Click(object sender, EventArgs e)
        {
            openDXFFileDialog.Filter = "DXF Files (*.dxf)|*.dxf";

            if (openDXFFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_OpenDXFFile.Text = openDXFFileDialog.FileName;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                dxfDoc = DxfDocument.Load(openDXFFileDialog.FileName);
                MessageBox.Show($"檔案 {openDXFFileDialog.FileName} 成功讀取！");

                DXFDatas.show_dgv_DXFDatas(dgv_DXFDatas, dxfDoc);

                DXFDatas.find_DXFDatas_bounds(dxfDoc, out minX, out minY, out maxX, out maxY);
                
                offset.X = (float)minX * 10;
                offset.Y = (float)minY * 10;

                pic_DXFDatas.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}");
            }
        }

        private void pic_DXFDatas_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.ScaleTransform(zoomFactor, zoomFactor);
            e.Graphics.TranslateTransform(offset.X / zoomFactor, offset.Y / zoomFactor); // 拖曳圖片轉換座標

            try
            {
                foreach (var circle in dxfDoc.Entities.Circles)
                {
                    Brush fillBrush = new SolidBrush(Color.ForestGreen); // 預設顏色

                    RectangleF rectangleF = new RectangleF(
                        (float)(circle.Center.X * 10 - circle.Radius * 10),
                        (float)(circle.Center.Y * 10 - circle.Radius * 10),
                        (float)(2 * circle.Radius * 10),
                        (float)(2 * circle.Radius * 10)
                    );

                    if (circle == highlightedCircle)
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

        private void pic_DXFDatas_MouseMove(object sender, MouseEventArgs e)
        {
            realMousePos.X = (e.X - offset.X) / zoomFactor / 10;
            realMousePos.Y = (e.Y - offset.Y) / zoomFactor / 10;

            lbl_MousePos.Text = $"真實座標 : {realMousePos.X}, {realMousePos.Y}";

            // 左鍵拖曳
            if (e.Button == MouseButtons.Left) 
            {
                // 計算滑鼠移動的差值
                offset.X += e.X - prevMousePos.X;
                offset.Y += e.Y - prevMousePos.Y;

                prevMousePos = e.Location; // 拖曳當中隨時紀錄當下滑鼠在 PictureBox 上的位置, 不以左鍵點擊當下的位置
            }

            // 鼠標與圓的距離判斷是否高量
            highlightedCircle = null; // 每一次移動滑鼠都必須重新判斷是否需要高量
            int index = 0; // datagridview 的索引行遍歷

            foreach (var circle in dxfDoc.Entities.Circles)
            {
                // 计算鼠标位置与圆心的距离
                mouse2CircleDistance = Math.Sqrt(
                    Math.Pow((e.X - offset.X) / 10 / zoomFactor - circle.Center.X, 2) + 
                    Math.Pow((e.Y - offset.Y) / 10 / zoomFactor - circle.Center.Y, 2)
                );

                if (mouse2CircleDistance <= circle.Radius)
                {
                    if (isHighlightedRow == true) 
                    {
                        dgv_DXFDatas.Rows[prevHighlightedRow].DefaultCellStyle.BackColor = SystemColors.Window;
                    }

                    highlightedCircle = circle; // 記錄高亮的圓              
                    dgv_DXFDatas.Rows[index].DefaultCellStyle.BackColor = SystemColors.Highlight;  // 高亮 datagridview 該列               
                    dgv_DXFDatas.FirstDisplayedScrollingRowIndex = index;// 設置自動捲動到該列

                    prevHighlightedRow = index; // 紀錄上一次被highlight過的列
                    isHighlightedRow = true;
                    
                    break;
                }

                index++;
            }

            pic_DXFDatas.Refresh();
        }

        private void pic_DXFDatas_MouseWheel(object sender, MouseEventArgs e)
        {
            
            // 滑鼠在 PictureBox 上的位置對應的真實座標（縮放前）
            float realXBeforeZoom = (e.X - offset.X) / zoomFactor;
            float realYBeforeZoom = (e.Y - offset.Y) / zoomFactor;

            if (e.Delta > 0)
            {
                zoomFactor *= 2f; // 滾輪向上，放大
            }
            else if (e.Delta < 0)
            {
                if(zoomFactor > 1) // 最小就 1 倍
                {
                    zoomFactor /= 2f; // 滾輪向下，縮小
                }                   
            }

            // 滑鼠在 PictureBox 上的位置對應的真實座標（縮放後）
            float realXAfterZoom = (e.X - offset.X) / zoomFactor;
            float realYAfterZoom = (e.Y - offset.Y) / zoomFactor;

            // 根據縮放前後的真實座標差異調整偏移量
            offset.X += (realXAfterZoom - realXBeforeZoom) * zoomFactor;
            offset.Y += (realYAfterZoom - realYBeforeZoom) * zoomFactor;

            pic_DXFDatas.Refresh();
        }
        
        private void pic_DXFDatas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                prevMousePos = e.Location;
            }
        }

    }
}
