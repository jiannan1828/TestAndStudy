namespace Training4
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Change1_Click(object sender, EventArgs e)
        {
            frm_Change1 frm_Change1 = new frm_Change1();
            DialogResult result = frm_Change1.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    lbl_Change.Text = "1";
                    break;

                case DialogResult.Cancel:
                    break;

                default:
                    break;
            }
        }

        private void btn_Change2_Click(object sender, EventArgs e)
        {
            frm_Change2 frm_Change2 = new frm_Change2();
            DialogResult result = frm_Change2.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    lbl_Change.Text = "2";
                    break;

                case DialogResult.Cancel:
                    break;

                default:
                    break;
            }
        }

        private void btn_Change3_Click(object sender, EventArgs e)
        {
            frm_Change3 frm_Change3 = new frm_Change3();
            DialogResult result = frm_Change3.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:
                    lbl_Change.Text = frm_Change3.txtChange3Text;
                    break;

                case DialogResult.Cancel:
                    break;

                default:
                    break;
            }
        }

    }
}
