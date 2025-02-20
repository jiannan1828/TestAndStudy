namespace MVC.Models
{
    public class Index
    {
        public int CounterValue { get; set; } = 0;

        public string RadioButtonSelectedOption { get; set; }

        public List<string> CheckboxSelectedOptions { get; set; } = new List<string>(); // 用於儲存選中的選項
    }
}
