using System;
using System.Text.Json;
using System.Windows.Forms;
using netDxf;
using netDxf.Entities;
using static NeedleViewer.Dxf;

namespace NeedleViewer
{
    public partial class Frm_Main : Form
    {
        private DxfDocument DxfDoc = new DxfDocument();
        private Dxf.Json Json = new Dxf.Json();
        private double minX, minY, maxX, maxY, width, height;

        private System.Drawing.Image buddha;
        private System.Drawing.Image buddhaText;

        private OpenFileDialog OpenDxfFileDialog = new OpenFileDialog();
        private SaveFileDialog SaveJsonFileDialog = new SaveFileDialog();

        private float ZoomFactor = 1;

        private PointF Offset = new PointF(0, 0);
        private PointF PrevMousePos = new PointF(0, 0);
        private PointF RealMousePos = new PointF(0, 0);
        private PointF RealMousePosBeforeZoom = new PointF(0, 0);
        private PointF RealMousePosAfterZoom = new PointF(0, 0);

        private double Mouse2CircleDistance;

        private Dxf.Json.Circle HighlightedCircle = null;
        private int HighlightedRow = -1;

        private Dxf.Json.Circle FocusedCircle = null;
        private int FocusedRow = -1;

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


                    if (circle == FocusedCircle)
                    {
                        fillBrush = new SolidBrush(Color.Red);
                    }
                    else if (circle == HighlightedCircle)
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

            lbl_MousePos.Text = $"滑鼠座標 : {RealMousePos.X}, {RealMousePos.Y}";

            // 左鍵拖曳
            if (e.Button == MouseButtons.Left)
            {
                // 計算滑鼠移動的差值
                Offset.X += e.X - PrevMousePos.X;
                Offset.Y += e.Y - PrevMousePos.Y;

                PrevMousePos = e.Location; // 拖曳當中隨時紀錄當下滑鼠在 PictureBox 上的位置, 不以左鍵點擊當下的位置
            }


            foreach (var circle in Json.Circles)
            {
                // 计算鼠标位置与圆心的距离
                Mouse2CircleDistance = Math.Sqrt(
                    Math.Pow((e.X - Offset.X) / 10 / ZoomFactor - circle.X, 2) +
                    Math.Pow((e.Y - Offset.Y) / 10 / ZoomFactor - circle.Y, 2)
                );

                if (Mouse2CircleDistance <= circle.Diameter / 2)
                {
                    if (HighlightedRow != -1) // 之前有列被 highlight 過
                    {
                        dgv_NeedleInfo.Rows[HighlightedRow].DefaultCellStyle.BackColor = SystemColors.Window; // 洗掉上一次 highlight 的列
                    }

                    HighlightedCircle = circle; // 記錄高亮的圓
                    HighlightedRow = circle.Index; // 紀錄上一次被highlight過的列

                    dgv_NeedleInfo.Rows[circle.Index].DefaultCellStyle.BackColor = Color.PaleGoldenrod;  // 高亮 datagridview 該列               
                    dgv_NeedleInfo.FirstDisplayedScrollingRowIndex = circle.Index;// 設置自動捲動到該列

                    break;
                }
                else
                {
                    HighlightedCircle = null;
                }
            }

            pic_Needles.Refresh();
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

            pic_Needles.Refresh();
        }

        private void pic_DxfDatas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PrevMousePos = e.Location;

                if (HighlightedCircle != null)
                {
                    FocusedCircle = HighlightedCircle;

                    UI.show_grp_NeedleInfo(grp_NeedleInfo, FocusedCircle);

                    // 20241209 4xuan : 待新增picturebox上的圓點擊 與 dgv 綁定
                    dgv_NeedleInfo.Rows[FocusedCircle.Index].Selected = true; // 選擇目標行

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

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDxfFileDialog.Filter = "DXF Files (*.dxf)|*.dxf|JSON Files (*.json)|*.json";

            if (OpenDxfFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (OpenDxfFileDialog.FilterIndex == 1) //剛剛選擇檔案類型的第一行是 .dxf
                {
                    try
                    {
                        DxfDoc = DxfDocument.Load(OpenDxfFileDialog.FileName);
                        MessageBox.Show($"檔案 {OpenDxfFileDialog.FileName} 成功讀取！");

                        Dxf.transform_Dxf2Json(DxfDoc, out Json);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"讀取 DXF 檔時發生錯誤: {ex.Message}");
                    }
                }
                else if (OpenDxfFileDialog.FilterIndex == 2) //剛剛選擇檔案類型的第二行是 .json
                {
                    try
                    {
                        Json = JsonSerializer.Deserialize<Json>(File.ReadAllText(OpenDxfFileDialog.FileName));
                        MessageBox.Show($"檔案 {OpenDxfFileDialog.FileName} 成功讀取！");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show($"讀取 JSON 檔時發生錯誤: {ex.Message}");
                    }
                }

                UI.show_dgv_NeedleInfo(dgv_NeedleInfo, Json);

                Dxf.find_Dxf_bounds(Json, out minX, out minY, out maxX, out maxY, out width, out height);

                ZoomFactor = Math.Min(pic_Needles.Width / 10 / (float)width, pic_Needles.Height / 10 / (float)height);
                Offset.X = -(float)minX * 10 * ZoomFactor;
                Offset.Y = -(float)minY * 10 * ZoomFactor;

                pic_Needles.Refresh();
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

        private void dgv_Dxf_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_NeedleInfo.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleGoldenrod; // 高亮顏色
                HighlightedCircle = Json.Circles[e.RowIndex];
                HighlightedRow = e.RowIndex;
                pic_Needles.Refresh();
            }
        }

        private void dgv_Dxf_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgv_NeedleInfo.Rows[e.RowIndex].DefaultCellStyle.BackColor = SystemColors.Window; // 高亮顏色
                HighlightedCircle = null;
                HighlightedRow = -1;
                pic_Needles.Refresh();
            }
        }

        private void 儲存檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveJsonFileDialog.Filter = "JSON Files (*.json)|*.json";

            if (SaveJsonFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 使用 System.Text.Json 進行物件序列化，並設定格式化輸出（會縮排顯示）
                string json = JsonSerializer.Serialize(Json, new JsonSerializerOptions { WriteIndented = true });

                // 使用 StreamWriter 儲存 JSON 到選定的檔案
                using (StreamWriter writer = new StreamWriter(SaveJsonFileDialog.FileName))
                {
                    writer.Write(json);
                }

                MessageBox.Show("檔案儲存成功！", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Json.Circles[FocusedCircle.Index].Name = txt_Name.Text;
                Json.Circles[FocusedCircle.Index].Id = txt_Id.Text;

                Json.Circles[FocusedCircle.Index].Place = (chk_Place.Checked).ToString();
                Json.Circles[FocusedCircle.Index].Remove = (chk_Remove.Checked).ToString();
                Json.Circles[FocusedCircle.Index].Replace = (chk_Replace.Checked).ToString();
                Json.Circles[FocusedCircle.Index].Display = (chk_Display.Checked).ToString();
                Json.Circles[FocusedCircle.Index].Enable = (chk_Enable.Checked).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新資料出現錯誤: {ex.Message}");
            }
        }

        private void dgv_NeedleInfo_SelectionChanged(object sender, EventArgs e)
        {
            FocusedCircle = Json.Circles[dgv_NeedleInfo.CurrentCell.RowIndex];

            FocusedRow = dgv_NeedleInfo.CurrentCell.RowIndex;

            UI.show_grp_NeedleInfo(grp_NeedleInfo, FocusedCircle);

            pic_Needles.Refresh();
        }
    }
}
