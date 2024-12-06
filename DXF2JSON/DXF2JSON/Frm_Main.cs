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
        public System.Drawing.Point  mousePosition;
        public double zoomFactor = 1;

        private OpenFileDialog openDXFFileDialog = new OpenFileDialog();

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
                pic_DXFDatas.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}");
            }
        }

        private void pic_DXFDatas_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pic_DXFDatas.BackColor);

            try
            {
                foreach (var Circle in dxfDoc.Entities.Circles)
                {
                    Graphics graphics = e.Graphics;
                    Pen blackPen = new Pen(Color.Black, 1);
                    blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Rectangle circle = new Rectangle(
                        Convert.ToInt32(Circle.Center.X * 10000 * zoomFactor),
                        Convert.ToInt32(Circle.Center.Y * 10000 * zoomFactor),
                        Convert.ToInt32(Circle.Radius * 10000 * zoomFactor),
                        Convert.ToInt32(Circle.Radius * 10000 * zoomFactor)
                        ); // 20241206 4xuan : 等比例縮放
                    graphics.ScaleTransform(1f / 10000f, 1f / 10000f); // 將 picturebox 等比例縮小 10000 倍
                    graphics.DrawEllipse(blackPen, circle);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void pic_DXFDatas_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_MousePos.Text = $"滑鼠座標 : {(double)(e.X) / 10000 / zoomFactor}, {(double)(e.Y) / 10000 / zoomFactor}";

            if (e.Button == MouseButtons.Left) // 左鍵拖曳
            {
                // 計算滑鼠移動的差值
                int dx = e.Location.X - mousePosition.X;
                int dy = e.Location.Y - mousePosition.Y;

                // 更新 Panel 的滾動位置
                pnl_pic_DXFDatas.AutoScrollPosition = new System.Drawing.Point(
                    -pnl_pic_DXFDatas.AutoScrollPosition.X - dx, // Scrollbar向右下滾動為負
                    -pnl_pic_DXFDatas.AutoScrollPosition.Y - dy  // 左上值最大, 右下值最小
                );
            }

            foreach (var circle in dxfDoc.Entities.Circles)
            {
                // 计算鼠标位置与圆心的距离
                double distance = Math.Sqrt(Math.Pow(e.Location.X - circle.Center.X * 10 * zoomFactor, 2) + Math.Pow(e.Location.Y - circle.Center.Y * 10 * zoomFactor, 2));

                // 如果鼠标在圆的范围内（距离小于半径），执行某个操作
                if (distance <= circle.Radius * 10 * zoomFactor)
                {
                    // 这里你可以执行你的操作，如修改颜色或触发事件
                    pic_DXFDatas.Cursor = Cursors.Hand;  // 示例：改变鼠标样式
                                                         // 执行其他操作，比如改变圆的颜色
                                                         // 例如：highlightCircle(circle);   // 你可以给这个圆加上高亮显示的效果
                    break;  // 找到第一个匹配的圆后就不再继续判断
                }
                else
                {
                    pic_DXFDatas.Cursor = Cursors.Default;  // 如果不在任何圆内，恢复默认鼠标样式
                }
            }
        }

        private void pic_DXFDatas_MouseWheel(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                {
                    // 滾輪向上，放大
                    zoomFactor *= 2;
                    pic_DXFDatas.Size = new Size(pic_DXFDatas.Width * 2, pic_DXFDatas.Height * 2);
                    pic_DXFDatas.Invalidate();
                }
                else if (e.Delta < 0)
                {
                    // 滾輪向下，縮小
                    zoomFactor /= 2;
                    pic_DXFDatas.Size = new Size(pic_DXFDatas.Width / 2, pic_DXFDatas.Height / 2);
                    pic_DXFDatas.Invalidate();
                }
            }
        }

        private void pic_DXFDatas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePosition = e.Location;
            }
        }

    }
}
