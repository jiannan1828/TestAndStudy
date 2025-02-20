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
            var model = new MVC.Models.Index(); // �ϥηs���ҫ����
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
            indexModel.RichTextboxValue += "�A��ܪ� RadioButton ���ﶵ�O�G" + indexModel.RadioButtonSelectedOption;
            return View("Index", indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(MVC.Models.Index indexModel)
        {
            indexModel.RichTextboxValue += "�A��� CheckBox ���ﶵ�O�G " + string.Join(", ", indexModel.CheckboxSelectedOptions);
            return View("Index", indexModel); // ��^ Index ����
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(MVC.Models.Index indexModel)
        {
            indexModel.RichTextboxValue += "TextBox ��J���ȬO�G " + indexModel.TextboxValue;
            return View("Index", indexModel); // ��^ Index ����
        }

        [HttpPost]
        public IActionResult DropDownSubmit(MVC.Models.Index indexModel)
        {
            // �N�U�Կ���ܪ��T����ȵ� RichTextValue
            indexModel.RichTextboxValue += "�A��ܤU�Ԧ���檺�ﶵ�O�G " + indexModel.DropDownSelectedOption + "\n";
            return View("Index", indexModel); // ��^ Index ����
        }
    }
}
