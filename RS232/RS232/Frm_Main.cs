using System.IO.Ports; // 新版的 .NET Framework 未包含 IOPorts 功能, 要自行下載程式庫

namespace RS232
{
    public partial class Frm_Main : Form
    {
        SerialPort RS232 = new SerialPort();
        String[] processedMessage;

        // 新增一個 Buffer, 等待接收換行符號
        string Received_Data_Buffer = "";

        public Frm_Main()
        {
            InitializeComponent();

            btn_Connect.Enabled = false;
            btn_SendMessage.Enabled = false;

            // 得到可用的連接埠, 並顯示在 cmb 上
            String[] port_Enable = SerialPort.GetPortNames();
            foreach (var item in port_Enable)
            {
                cmb_Port.Items.Add(item);
            }

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //波特率
                RS232.BaudRate = 9600;
                //資料位
                RS232.DataBits = 8;
                RS232.PortName = cmb_Port.Text;
                //兩個停止位
                RS232.StopBits = System.IO.Ports.StopBits.One;
                //無奇偶校驗位
                RS232.Parity = System.IO.Ports.Parity.None;
                RS232.ReadTimeout = 100;
                RS232.Open();

                // 如果 serialPort 開啟成功
                if (RS232.IsOpen)
                {
                    MessageBox.Show("埠" + cmb_Port.Text + "開啟成功");

                    cmb_Port.Enabled = false;
                    btn_Connect.Enabled = false;
                    btn_SendMessage.Enabled = true;
                }
                else
                {
                    MessageBox.Show("埠" + cmb_Port.Text + "開啟失敗");
                    return;
                }

                //添加事件處理程序以監聽串口資料接收
                RS232.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                RS232.Dispose();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            RS232.Dispose();

            cmb_Port.Enabled = true;
            btn_Connect.Enabled = true;
            btn_SendMessage.Enabled = false;
        }

        private void cmb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Connect.Enabled = true;
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                // 當資料寫入的時候, 會觸發 SerialDataReceivedEventHandler 事件,
                // 並執行函數 DataReceivedHandler
                RS232.Write(txt_SendMessage.Text + "\n");
            }
            catch (Exception ex)
            {
                RS232.Dispose(); MessageBox.Show(ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // 運用事件傳過來的資料, 型別為 SerialPort
            SerialPort SerialPort_Receive = (SerialPort)sender;

            // 讀取 RS232 所有已抵達的資料
            string Received_Data = SerialPort_Receive.ReadExisting();

            // 將抵達的資料加到緩衝中
            Received_Data_Buffer += Received_Data;

            // 假如檢測到換行符號
            if (Received_Data_Buffer.Contains("\n"))
            {
                // 將接收的資料顯示在 richtextbox 上
                rtb_ReceiveMessage.Invoke(new Action(() =>
                {
                    rtb_ReceiveMessage.AppendText(Received_Data_Buffer);

                    processedMessage = processMessage(Received_Data_Buffer);

                    foreach (string line in processedMessage)
                    {
                        rtb_ProcessedMessage.AppendText(line);
                    }
                }));

                // 清空 buffer
                Received_Data_Buffer = "";
            }
        }

        private string[] processMessage(string Message)
        {
            if (Message.Contains("abc"))
            {
                MessageBox.Show("字串中含有abc");
            }
            Message = Message.Trim('{','}'); // 去除兩邊{ }
            Message = Message.Replace("\"","").Replace(" ","").Replace("{","").Replace("}", "").Replace(":"," -> ".Replace("\n","")); // 去除 " 空格
            processedMessage = Message.Split(','); // 以 , 做分割
            return processedMessage;
        }

        private void btn_CleanRtb_Click(object sender, EventArgs e)
        {
            rtb_ReceiveMessage.Clear();
            rtb_ProcessedMessage.Clear();
        }
    }
}
