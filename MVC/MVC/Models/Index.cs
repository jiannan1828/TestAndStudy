namespace MVC.Models
{
    public class Index
    {
        public int CounterValue { get; set; } = 0;

        public string RadioButtonSelectedOption { get; set; } // 用於儲存選中的RadioButton選項

        public List<string> CheckboxSelectedOptions { get; set; } = new List<string>(); // 用於儲存選中的Checkbox選項

        public string TextboxValue { get; set; } = ""; // 用於儲存 textbox 的值

        public string DropDownSelectedOption { get; set; } = ""; // 用於儲存下拉選單的選擇
    }
}
