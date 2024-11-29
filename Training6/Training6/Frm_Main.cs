namespace Training6
{
    public partial class Frm_Main : Form
    {
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
    }
}
