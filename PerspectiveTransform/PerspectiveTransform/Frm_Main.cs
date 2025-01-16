using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
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
            cameraPos[1] = new PointF(img_Original.Width, 0);
            cameraPos[2] = new PointF(img_Original.Width, img_Original.Height);
            cameraPos[3] = new PointF(0, img_Original.Height);

            realPos[0] = new PointF(0, 0);
            realPos[1] = new PointF(img_Original.Width, 0);
            realPos[2] = new PointF(img_Original.Width - 100, img_Original.Height);
            realPos[3] = new PointF(100, img_Original.Height);


            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // �ϥ� Emgu.CV Ū���Ϥ�
                var inputImage = new Image<Bgr, byte>(openFileDialog.FileName);
                img_Original.Image = inputImage; // ��ܭ��

                // �i��z���ܴ�
                var transformedImage = ApplyPerspectiveTransform(inputImage, cameraPos, realPos);
                img_PerspectiveTransform.Image = transformedImage; // ����ܴ���Ϲ�
            }
        }
    }
}

