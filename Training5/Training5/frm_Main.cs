namespace Training5
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void pic_Draw_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen blackPen = new Pen(Color.Black, 10);
            Pen redPen = new Pen(Color.Red, 20);
            Pen greenPen = new Pen(Color.Green,15);
            Pen bluePen = new Pen(Color.Blue, 25);
            blackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            redPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            greenPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            greenPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;

            Rectangle circle1 = new Rectangle(100, 100, 300, 300);
            Rectangle circle2 = new Rectangle(237, 250, 25, 25);

            graphics.DrawEllipse(blackPen, circle1);
            graphics.DrawEllipse(blackPen, circle2);

            Rectangle rectangle = new Rectangle(200, 300, 100, 50);

            graphics.DrawRectangle(redPen, rectangle);

            Point startPoint1 = new Point(150, 200);
            Point endPoint1 = new Point(225, 200);

            graphics.DrawLine(greenPen, startPoint1, endPoint1);

            Point startPoint2 = new Point(187, 237);
            Point endPoint2 = new Point(187, 163);

            graphics.DrawLine(bluePen, startPoint2, endPoint2);

            Point startPoint3 = new Point(275, 163);
            Point endPoint3 = new Point(350, 237);

            graphics.DrawLine(redPen, startPoint3, endPoint3);

            Point startPoint4 = new Point(350, 163);
            Point endPoint4 = new Point(275, 237);

            graphics.DrawLine(bluePen, startPoint4, endPoint4);

            blackPen.Dispose();
        }
    }
}
