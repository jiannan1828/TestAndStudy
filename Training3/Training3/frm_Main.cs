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
                    // 使用 Invoke 方法將 UI 更新操作委派回 UI 執行緒
                    this.Invoke((MethodInvoker)delegate // MethodInvoker 強制轉型為不須參數不須回傳的方法委派
                    {
                        lbl_Task1.Text = (Convert.ToInt32(lbl_Task1.Text) + 1).ToString();
                    });

                    System.Threading.Thread.Sleep(1000);
                }
            });

            Task1.ContinueWith(t => // Task1 任務完成後續操作
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
                    // 使用 Invoke 方法將 UI 更新操作委託回 UI 執行緒
                    this.Invoke((MethodInvoker)delegate // MethodInvoker 強制轉型為不須參數不須回傳的方法委託
                    {
                        lbl_Task2.Text = (Convert.ToInt32(lbl_Task2.Text) + 2).ToString();
                    });

                    System.Threading.Thread.Sleep(1000);
                }
            });

            Task2.ContinueWith(t => // Task2 任務完成後續操作
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
