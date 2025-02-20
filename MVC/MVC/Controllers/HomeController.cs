using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static MVC.Models.Index _indexModel = new MVC.Models.Index(); // 使用新的模型

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Options = new List<string> { "選項 A", "選項 B", "選項 C" }; // 下拉選單的選項
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

        public IActionResult AddCounter()
        {
            _indexModel.CounterValue += 1; // 將值加1
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RadioButtonSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "你選擇的 RadioButton 的選項是：" + indexModel.RadioButtonSelectedOption;
            return View("Index", indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "你選擇 CheckBox 的選項是： " + string.Join(", ", indexModel.CheckboxSelectedOptions);
            return View("Index", indexModel); // 返回 Index 視圖
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "TextBox 輸入的值是： " + indexModel.TextboxValue;
            return View("Index", indexModel); // 返回 Index 視圖
        }

        [HttpPost]
        public IActionResult DropDownSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "你選擇下拉式選單的選項是： " + indexModel.DropDownSelectedOption;
            ViewBag.Options = new List<string> { "選項 A", "選項 B", "選項 C" }; // 重新填充選項
            return View("Index", indexModel); // 返回 Index 視圖
        }
    }
}
