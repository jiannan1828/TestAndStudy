using System.Threading.Tasks;

namespace Training3
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

        }

        private void btn_Task1_Click(object sender, EventArgs e)
        {
            btn_Task1.Enabled = false;

            Task Task1 = Task.Run(() =>
            {
                while (Convert.ToInt32(lbl_Task1.Text) != 20)
                {
                    // �ϥ� Invoke ��k�N UI ��s�ާ@�e���^ UI �����
                    this.Invoke((MethodInvoker)delegate // MethodInvoker �j���૬�������ѼƤ����^�Ǫ���k�e��
                    {
                        lbl_Task1.Text = (Convert.ToInt32(lbl_Task1.Text) + 1).ToString();
                    });

                    System.Threading.Thread.Sleep(1000);
                }
            });

            Task1.ContinueWith(t => // Task1 ���ȧ�������ާ@
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lbl_Task1.Text = "0";
                    btn_Task1.Enabled = true;  
                });
            });
        }

        private void btn_Task2_Click(object sender, EventArgs e)
        {
            btn_Task2.Enabled = false;

            Task Task2 = Task.Run(() =>
            {
                while (Convert.ToInt32(lbl_Task2.Text) != 20)
                {
                    // �ϥ� Invoke ��k�N UI ��s�ާ@�e�U�^ UI �����
                    this.Invoke((MethodInvoker)delegate // MethodInvoker �j���૬�������ѼƤ����^�Ǫ���k�e�U
                    {
                        lbl_Task2.Text = (Convert.ToInt32(lbl_Task2.Text) + 2).ToString();
                    });

                    System.Threading.Thread.Sleep(1000);
                }
            });

            Task2.ContinueWith(t => // Task2 ���ȧ�������ާ@
            {
                this.Invoke((MethodInvoker)delegate
                {
                    lbl_Task2.Text = "0";
                    btn_Task2.Enabled = true;  
                });
            });
        }
    }
}
