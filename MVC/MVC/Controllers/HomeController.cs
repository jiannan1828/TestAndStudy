using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        private static IndexModel _indexModel = new IndexModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_indexModel);
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
        public IActionResult RadioButtonSubmit(IndexModel indexModel)
        {
            _indexModel.RadioButtonSelectedOption = indexModel.RadioButtonSelectedOption;
            _indexModel.RichTextboxValue += "你選擇的 RadioButton 的選項是：" + indexModel.RadioButtonSelectedOption + Environment.NewLine;
            return View("Index", _indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(IndexModel indexModel)
        {
            _indexModel.CheckboxSelectedOptions = indexModel.CheckboxSelectedOptions;
            _indexModel.RichTextboxValue += "你選擇 CheckBox 的選項是： " + string.Join(", ", indexModel.CheckboxSelectedOptions) + Environment.NewLine;
            return View("Index", _indexModel); 
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(IndexModel indexModel)
        {
            _indexModel.TextboxValue = indexModel.TextboxValue;
            _indexModel.RichTextboxValue += "TextBox 輸入的值是： " + indexModel.TextboxValue + Environment.NewLine;
            return View("Index", _indexModel); 
        }

        [HttpPost]
        public IActionResult DropDownSubmit(IndexModel indexModel)
        {
            _indexModel.DropDownSelectedOption = indexModel.DropDownSelectedOption;
            _indexModel.RichTextboxValue += "你選擇下拉式選單的選項是： " + indexModel.DropDownSelectedOption + Environment.NewLine;
            return View("Index", _indexModel); 
        }
    }
}
