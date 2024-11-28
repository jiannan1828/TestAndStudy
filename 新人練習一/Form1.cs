using static System.Net.Mime.MediaTypeNames;

namespace 新人練習一
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            cmb_Select.Items.Add("1");
            cmb_Select.Items.Add("2");
            cmb_Select.Items.Add("3");
        }

        private void btn_changeText_Click(object sender, EventArgs e)
        {
            btn_changeText.Text = (int.Parse(btn_changeText.Text) + 1).ToString();
        }

        private void btn_changeLabelText_Click(object sender, EventArgs e)
        {
            lbl_changeLabelText.Text = (int.Parse(lbl_changeLabelText.Text) + 1).ToString();
        }

    }
}
