using Caculatorlib;

namespace Training2
{
    public partial class frm_Main
    {
        Caculator Calc = new Caculator();
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                txt_equal.Text = (Calc.add(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text))).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("輸入格式錯誤");
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                txt_equal.Text = (Calc.minus(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text))).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("輸入格式錯誤");
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            try
            {
                txt_equal.Text = (Calc.multiply(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text))).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("輸入格式錯誤");
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            try
            {
                txt_equal.Text = (Calc.divide(Convert.ToDouble(txt_num1.Text), Convert.ToDouble(txt_num2.Text))).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("輸入格式錯誤");
            }
        }
    }
}
