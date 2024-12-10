using System;
using System.Text.Json;
using System.Windows.Forms;
using netDxf;
using netDxf.Entities;
using static NeedleViewer.DataManager;

namespace NeedleViewer
{
    public partial class Frm_Main : Form
    {
        private System.Drawing.Image buddha;
        private System.Drawing.Image buddhaText;

        private DataManager DataManager = new DataManager();

        private double minX, minY, maxX, maxY, width, height;

        private const float ScaleFactor = 10;
        private float ZoomFactor = 1;

        private PointF Offset = new PointF(0, 0);
        private PointF PrevMousePos = new PointF(0, 0);
        private PointF RealMousePos = new PointF(0, 0);
        private PointF RealMousePosBeforeZoom = new PointF(0, 0);
        private PointF RealMousePosAfterZoom = new PointF(0, 0);

        private readonly Color DefaltCircleColor = Color.ForestGreen;
        private readonly Color HighlightedCircleColor = Color.LightBlue;
        private readonly Color FocusedCircleColor = Color.Red;

        private double Mouse2CircleDistance;

        private DataManager.JSON.Circle HighlightedCircle = new DataManager.JSON.Circle();
        private int HighlightedRow = -1;

        private DataManager.JSON.Circle FocusedCircle = new DataManager.JSON.Circle();
        private int FocusedRow = -1;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            buddha = System.Drawing.Image.FromFile(@"..\..\..\Images\Buddha.png");
            buddhaText = System.Drawing.Image.FromFile(@"..\..\..\Images\BuddhaText.png");
        }

        private void Frm_Main_Paint(object sender, PaintEventArgs e)
        {

            int x = this.ClientSize.Width - 300;
            int y = this.ClientSize.Height - 300;
            e.Graphics.DrawImage(buddhaText, new Rectangle(x - 15, y - 150, 300, 300));
            e.Graphics.DrawImage(buddha, new Rectangle(x, y, 300, 300));
        }

        private void Frm_Main_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void tsmi_OpenFile_Click(object sender, EventArgs e)
        {
            DataManager.OpenFile();

            UI.show_dgv_NeedleInfo(dgv_Needles, DataManager.Json);

            DataManager.find_boundary(DataManager.Json, out minX, out minY, out maxX, out maxY, out width, out height);

            ZoomFactor = Math.Min(pic_Needles.Width / ScaleFactor / (float)width, pic_Needles.Height / ScaleFactor / (float)height);
            Offset.X = -(float)minX * ScaleFactor * ZoomFactor;
            Offset.Y = -(float)minY * ScaleFactor * ZoomFactor;

            pic_Needles.Refresh();

        }

        private void tsmi_SaveFile_Click(object sender, EventArgs e)
        {
            DataManager.SaveFile();
        }

        private void pic_Needles_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.ScaleTransform(ZoomFactor, ZoomFactor);
            e.Graphics.TranslateTransform(Offset.X / ZoomFactor, Offset.Y / ZoomFactor); // 拖曳圖片轉換座標

            try
            {
                foreach (var circle in DataManager.Json.Circles)
                {
                    Brush fillBrush = new SolidBrush(DefaltCircleColor); // 預設顏色

                    RectangleF rectangleF = new RectangleF(
                        (float)(circle.X * ScaleFactor - circle.Diameter / 2 * ScaleFactor),
                        (float)(circle.Y * ScaleFactor - circle.Diameter / 2 * ScaleFactor),
                        (float)(2 * circle.Diameter / 2 * ScaleFactor),
                        (float)(2 * circle.Diameter / 2 * ScaleFactor)
                    );


                    if (circle == FocusedCircle)
                    {
                        fillBrush = new SolidBrush(FocusedCircleColor);
                    }
                    else if (circle == HighlightedCircle)
                    {
                        fillBrush = new SolidBrush(HighlightedCircleColor);
                    }

                    e.Graphics.FillEllipse(fillBrush, rectangleF);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pic_Needles_MouseMove(object sender, MouseEventArgs e)
        {
            RealMousePos.X = (e.X - Offset.X) / ZoomFactor / ScaleFactor;
            RealMousePos.Y = (e.Y - Offset.Y) / ZoomFactor / ScaleFactor;

            lbl_MousePos.Text = $"滑鼠座標 : {RealMousePos.X}, {RealMousePos.Y}";

            // 左鍵拖曳
            if (e.Button == MouseButtons.Left)
            {
                // 計算滑鼠移動的差值
                Offset.X += e.X - PrevMousePos.X;
                Offset.Y += e.Y - PrevMousePos.Y;

                PrevMousePos = e.Location; // 拖曳當中隨時紀錄當下滑鼠在 PictureBox 上的位置, 不以左鍵點擊當下的位置
            }


            foreach (var circle in DataManager.Json.Circles)
            {
                // 计算鼠标位置与圆心的距离
                Mouse2CircleDistance = Math.Sqrt(
                    Math.Pow((e.X - Offset.X) / ScaleFactor / ZoomFactor - circle.X, 2) +
                    Math.Pow((e.Y - Offset.Y) / ScaleFactor / ZoomFactor - circle.Y, 2)
                );

                if (Mouse2CircleDistance <= circle.Diameter / 2)
                {
                    if (HighlightedRow != -1) // 之前有列被 highlight 過
                    {
                        dgv_Needles.Rows[HighlightedRow].DefaultCellStyle.BackColor = SystemColors.Window; // 洗掉上一次 highlight 的列
                    }

                    HighlightedCircle = circle; // 記錄高亮的圓
                    HighlightedRow = circle.Index; // 紀錄上一次被highlight過的列

                    dgv_Needles.Rows[circle.Index].DefaultCellStyle.BackColor = Color.PaleGoldenrod;  // 高亮 datagridview 該列               
                    dgv_Needles.FirstDisplayedScrollingRowIndex = circle.Index;// 設置自動捲動到該列

                    break;
                }
                else
                {
                    HighlightedCircle = null;
                }
            }

            pic_Needles.Refresh();
        }

        private void pic_Needles_MouseWheel(object sender, MouseEventArgs e)
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

            pic_Needles.Refresh();
        }

        private void pic_Needles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PrevMousePos = e.Location;

                if (HighlightedCircle != null)
                {
                    FocusedCircle = HighlightedCircle;

                    UI.show_grp_NeedleInfo(grp_NeedleInfo, FocusedCircle);

                    // 20241209 4xuan debug
                    dgv_Needles.Rows[FocusedCircle.Index].Selected = true; // 觸發 dgv_NeedleInfo_SelectionChanged

                    btn_Update.Enabled = true;
                }
                else
                {
                    FocusedCircle = null;

                    UI.clear_grp_NeedleInfo(grp_NeedleInfo);

                    btn_Update.Enabled = false;
                }
            }
        }

        private void dgv_Needles_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Needles.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGoldenrod; // 高亮顏色
                HighlightedCircle = DataManager.Json.Circles[e.RowIndex];
                HighlightedRow = e.RowIndex;
                pic_Needles.Refresh();
            }
        }

        private void dgv_Needles_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_Needles.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window; // 高亮顏色
                HighlightedCircle = null;
                HighlightedRow = -1;
                pic_Needles.Refresh();
            }
        }

        private void dgv_Needles_SelectionChanged(object sender, EventArgs e)
        {
            /* ---------------------------- 20241209 4xuan debug -------------------------------- */
            // 解決由 picturebox 觸發 dgv 選擇列但不會更新 dgv_NeedleInfo.CurrentCell.RowIndex 屬性問題
            // 不管是 picturebox 選還是 dgv 選, 都會有 HighlightedCircle 存在 
            
            FocusedCircle = HighlightedCircle;
            
            //FocusedCircle = DataManager.Json.Circles[dgv_Needles.CurrentCell.RowIndex];
            //FocusedRow = dgv_Needles.CurrentCell.RowIndex;
            
            /* ---------------------------------------------------------------------------------- */
            UI.show_grp_NeedleInfo(grp_NeedleInfo, FocusedCircle);

            pic_Needles.Refresh();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                DataManager.Json.Circles[FocusedCircle.Index].Name = txt_Name.Text;
                DataManager.Json.Circles[FocusedCircle.Index].Id = txt_Id.Text;

                DataManager.Json.Circles[FocusedCircle.Index].Place = (chk_Place.Checked).ToString();
                DataManager.Json.Circles[FocusedCircle.Index].Remove = (chk_Remove.Checked).ToString();
                DataManager.Json.Circles[FocusedCircle.Index].Replace = (chk_Replace.Checked).ToString();
                DataManager.Json.Circles[FocusedCircle.Index].Display = (chk_Display.Checked).ToString();
                DataManager.Json.Circles[FocusedCircle.Index].Enable = (chk_Enable.Checked).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新資料出現錯誤: {ex.Message}");
            }
        }
    }
}
