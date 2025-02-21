using System.IO.Ports;

namespace MVC.Models
{
    public class IndexModel
    {
        #region 測試用的變數
        public string RadioButtonSelectedOption { get; set; } = "";// 用於儲存選中的RadioButton選項
        public List<string> CheckboxSelectedOptions { get; set; } = new List<string>(); // 用於儲存選中的Checkbox選項
        public string TextboxValue { get; set; } = ""; // 用於儲存 textbox 的值
        public string DropDownSelectedOption { get; set; } = ""; // 用於儲存下拉選單的選擇
        public string RichTextboxValue { get; set; } = ""; // 用於儲存 Rich TextBox 的值
        #endregion

        #region RS232
        public SerialPort RS232 = new SerialPort();
        public string Received_Data_Buffer = "";
        public string rtb_ReceiveMessage_Text { get; set; } = ""; // 用於儲存 RS232 接收到的訊息
        public string cmb_Port_Text { get; set; } = ""; // 選擇的 COM
        public bool cmb_Port_Enabled { get; set; } = true;
        public List<string> cmb_Port_Items { get; set; } = new List<string>();
        public bool btn_Connect_Enabled { get; set; } = true;
        public bool btn_Disconnect_Enabled { get; set; } = false;
        public bool btn_SendMessage_Enabled { get; set; } = false;

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort SerialPort_Receive = (SerialPort)sender;

            string Received_Data = SerialPort_Receive.ReadExisting();

            Received_Data_Buffer += Received_Data;

            if (Received_Data_Buffer.Contains("\n"))
            {
                rtb_ReceiveMessage_Text += Received_Data_Buffer + Environment.NewLine;

                Received_Data_Buffer = "";
            }
        }
        #endregion
    }
}
