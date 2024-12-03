using System.Windows.Forms;

namespace Training6
{
    public partial class Frm_Main : Form
    {
        private Point _mouseLocation;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void pic_Draw_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 10);

            blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            Rectangle circle = new Rectangle(750, 750, 500, 500);

            graphics.DrawEllipse(blackPen, circle);


        }

        private void pic_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseLocation = e.Location; 
            }
        }

        private void pic_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // �p��ƹ����ʪ��t��
                int dx = e.Location.X - _mouseLocation.X;
                int dy = e.Location.Y - _mouseLocation.Y;

                // ��s Panel ���u�ʦ�m
                pnl_Pic_Draw.AutoScrollPosition = new Point(
                    -pnl_Pic_Draw.AutoScrollPosition.X - dx, // Scrollbar�V�k�U�u�ʬ��t
                    -pnl_Pic_Draw.AutoScrollPosition.Y - dy  // ���W�ȳ̤j, �k�U�ȳ̤p
                );
            }
        }
    }
}
