using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new MVC.Models.Index(); // 使用新的模型實例
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult RadioButtonSubmit(MVC.Models.Index indexModel)
        {
            indexModel.RichTextboxValue += "你選擇的 RadioButton 的選項是：" + indexModel.RadioButtonSelectedOption;
            return View("Index", indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(MVC.Models.Index indexModel)
        {
            indexModel.RichTextboxValue += "你選擇 CheckBox 的選項是： " + string.Join(", ", indexModel.CheckboxSelectedOptions);
            return View("Index", indexModel); // 返回 Index 視圖
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(MVC.Models.Index indexModel)
        {
            indexModel.RichTextboxValue += "TextBox 輸入的值是： " + indexModel.TextboxValue;
            return View("Index", indexModel); // 返回 Index 視圖
        }

        [HttpPost]
        public IActionResult DropDownSubmit(MVC.Models.Index indexModel)
        {
            // 將下拉選單選擇的訊息賦值給 RichTextValue
            indexModel.RichTextboxValue += "你選擇下拉式選單的選項是： " + indexModel.DropDownSelectedOption + "\n";
            return View("Index", indexModel); // 返回 Index 視圖
        }
    }
}
