using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static MVC.Models.Index _indexModel = new MVC.Models.Index(); // �ϥηs���ҫ�

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Options = new List<string> { "�ﶵ A", "�ﶵ B", "�ﶵ C" }; // �U�Կ�檺�ﶵ
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
            _indexModel.CounterValue += 1; // �N�ȥ[1
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RadioButtonSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "�A��ܪ� RadioButton ���ﶵ�O�G" + indexModel.RadioButtonSelectedOption;
            return View("Index", indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "�A��� CheckBox ���ﶵ�O�G " + string.Join(", ", indexModel.CheckboxSelectedOptions);
            return View("Index", indexModel); // ��^ Index ����
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "TextBox ��J���ȬO�G " + indexModel.TextboxValue;
            return View("Index", indexModel); // ��^ Index ����
        }

        [HttpPost]
        public IActionResult DropDownSubmit(MVC.Models.Index indexModel)
        {
            ViewBag.Message = "�A��ܤU�Ԧ���檺�ﶵ�O�G " + indexModel.DropDownSelectedOption;
            ViewBag.Options = new List<string> { "�ﶵ A", "�ﶵ B", "�ﶵ C" }; // ���s��R�ﶵ
            return View("Index", indexModel); // ��^ Index ����
        }
    }
}
