using System.IO.Ports;
using System.Text.Json;

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
        public string rtb_ReceiveMessage_Text { get; set; } = ""; 
        public string cmb_Port_Text { get; set; } = ""; 
        public string cmb_Port_Enabled { get; set; } = "True";
        public List<string> cmb_Port_Items { get; set; } = new List<string>();
        public string btn_Connect_Enabled { get; set; } = "True";
        public string btn_Disconnect_Enabled { get; set; } = "False";
        public string btn_SendMessage_Enabled { get; set; } = "False";
        public string txt_SendMessage_Text { get; set; } = ""; 

        
        #endregion
    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
