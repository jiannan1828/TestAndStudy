using static AffineTransform.AffineTransform; 

namespace AffineTransform
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void btn_Transform_Click(object sender, EventArgs e)
        {
            TestPoint[0] = float.Parse(txt_TestPointX.Text);
            TestPoint[1] = float.Parse(txt_TestPointY.Text);

            double[] transformMatrix = GaussElimination();

            double[] result = ApplyAffineTransform(TestPoint, transformMatrix);

            txt_ResultPointX.Text = result[0].ToString();
            txt_ResultPointY.Text = result[1].ToString();
        }
    }
}
