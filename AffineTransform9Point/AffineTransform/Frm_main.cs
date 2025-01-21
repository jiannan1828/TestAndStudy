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
            for (int i = 0; i < 9; i++)
            {
                // x 方程
                A[2 * i, 0] = realPoints[i, 0];
                A[2 * i, 1] = realPoints[i, 1];
                A[2 * i, 2] = 1;
                A[2 * i, 3] = 0;
                A[2 * i, 4] = 0;
                A[2 * i, 5] = 0;
                b[2 * i] = idealPoints[i, 0];

                // y 方程
                A[2 * i + 1, 0] = 0;
                A[2 * i + 1, 1] = 0;
                A[2 * i + 1, 2] = 0;
                A[2 * i + 1, 3] = realPoints[i, 0];
                A[2 * i + 1, 4] = realPoints[i, 1];
                A[2 * i + 1, 5] = 1;
                b[2 * i + 1] = idealPoints[i, 1];
            }

            TestPoint[0] = float.Parse(txt_TestPointX.Text);
            TestPoint[1] = float.Parse(txt_TestPointY.Text);

            // 計算 A^T * A 和 A^T * b
            double[,] AtA = Multiply(Transpose(A), A);
            double[] Atb = Multiply(Transpose(A), b);

            // 解線性方程組 (這裡使用高斯消去法)
            double[] transformMatrix = SolveLinearSystem(AtA, Atb);

            double[] result = ApplyAffineTransform(TestPoint, transformMatrix);

            txt_ResultPointX.Text = result[0].ToString();
            txt_ResultPointY.Text = result[1].ToString();
        }
    }
}
