namespace MVC.Models
{
    public class IndexModel
    {
        #region 測試用的變數
        public int CounterValue { get; set; } = 0;
        public string RadioButtonSelectedOption { get; set; } = "";// 用於儲存選中的RadioButton選項
        public List<string> CheckboxSelectedOptions { get; set; } = new List<string>(); // 用於儲存選中的Checkbox選項
        public string TextboxValue { get; set; } = ""; // 用於儲存 textbox 的值
        public string DropDownSelectedOption { get; set; } = ""; // 用於儲存下拉選單的選擇
        public string RichTextboxValue { get; set; } = ""; // 用於儲存 Rich TextBox 的值
        #endregion

        #region RS232
        public string rtb_ReceiveMessage { get; set; } = ""; // 用於儲存 RS232 接收到的訊息
        #endregion
    }
}
