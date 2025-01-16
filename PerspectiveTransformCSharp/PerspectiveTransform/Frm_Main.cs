using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static PerspectiveTransform.PerspectiveTransform;

namespace PerspectiveTransform
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        PointF[] cameraPos = new PointF[4];
        PointF[] realPos = new PointF[4];

        private void btn_PerspectiveTransform_Click(object sender, EventArgs e)
        {
            cameraPos[0] = new PointF(0, 0);
            cameraPos[1] = new PointF(500, 0);
            cameraPos[2] = new PointF(400, 500);
            cameraPos[3] = new PointF(100, 500);

            realPos[0] = new PointF(0, 0);
            realPos[1] = new PointF(500, 0);
            realPos[2] = new PointF(500, 500);
            realPos[3] = new PointF(0, 500);


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_Original.Image = new Bitmap(openFileDialog.FileName);

                pic_PerspectiveTransform.Image = ApplyPerspectiveTransform((Bitmap)pic_Original.Image, cameraPos, realPos);
            }

        }
    }
}
