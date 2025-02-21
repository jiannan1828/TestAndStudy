using System.Diagnostics;
using System.IO.Ports;
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
            // �o��i�Ϊ��s����, ����ܦb cmb �W
            String[] port_Enable = SerialPort.GetPortNames();
            foreach (var item in port_Enable)
            {
                _indexModel.cmb_Port_Items.Add(item);
            }
            return View(_indexModel);
        }

        [HttpGet]
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
            _indexModel.RichTextboxValue += "�A��ܪ� RadioButton ���ﶵ�O�G" + indexModel.RadioButtonSelectedOption + Environment.NewLine;
            return View("Index", _indexModel);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(IndexModel indexModel)
        {
            _indexModel.CheckboxSelectedOptions = indexModel.CheckboxSelectedOptions;
            _indexModel.RichTextboxValue += "�A��� CheckBox ���ﶵ�O�G " + string.Join(", ", indexModel.CheckboxSelectedOptions) + Environment.NewLine;
            return View("Index", _indexModel); 
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(IndexModel indexModel)
        {
            _indexModel.TextboxValue = indexModel.TextboxValue;
            _indexModel.RichTextboxValue += "TextBox ��J���ȬO�G " + indexModel.TextboxValue + Environment.NewLine;
            return View("Index", _indexModel); 
        }

        [HttpPost]
        public IActionResult DropDownSubmit(IndexModel indexModel)
        {
            _indexModel.DropDownSelectedOption = indexModel.DropDownSelectedOption;
            _indexModel.RichTextboxValue += "�A��ܤU�Ԧ���檺�ﶵ�O�G " + indexModel.DropDownSelectedOption + Environment.NewLine;
            return View("Index", _indexModel); 
        }

        [HttpPost]
        public IActionResult btn_Connect_Click(IndexModel indexModel)
        {
            try
            {
                _indexModel.RS232.BaudRate = 9600;
                _indexModel.RS232.DataBits = 8;
                _indexModel.RS232.PortName = indexModel.cmb_Port_Text;
                _indexModel.RS232.StopBits = System.IO.Ports.StopBits.One;
                _indexModel.RS232.Parity = System.IO.Ports.Parity.None;
                _indexModel.RS232.ReadTimeout = 100;
                _indexModel.RS232.Open();

                if (_indexModel.RS232.IsOpen)
                {
                    _indexModel.rtb_ReceiveMessage_Text += $"�� {indexModel.cmb_Port_Text} �}�Ҧ��\" + Environment.NewLine;

                    _indexModel.cmb_Port_Text = indexModel.cmb_Port_Text;
                    _indexModel.cmb_Port_Enabled = false;
                    _indexModel.btn_Connect_Enabled = false;
                    _indexModel.btn_Disconnect_Enabled = true;
                    _indexModel.btn_SendMessage_Enabled = true;
                }
                else
                {
                    _indexModel.rtb_ReceiveMessage_Text = $"�� {indexModel.cmb_Port_Text} �}�ҥ���" + Environment.NewLine;
                    return View("Index", _indexModel);
                }

                _indexModel.RS232.DataReceived += new SerialDataReceivedEventHandler(_indexModel.DataReceivedHandler);
                return View("Index", _indexModel);
            }
            catch (Exception ex)
            {
                _indexModel.RS232.Dispose();
                _indexModel.rtb_ReceiveMessage_Text += ex.Message + Environment.NewLine;
                return View("Index", _indexModel);
            }
        }

        [HttpPost]
        public IActionResult btn_Disconnect_Click(IndexModel indexModel)
        {
            _indexModel.RS232.Dispose();

            _indexModel.cmb_Port_Enabled = true;
            _indexModel.btn_Connect_Enabled = true;
            _indexModel.btn_Disconnect_Enabled = false;
            _indexModel.btn_SendMessage_Enabled = false;

            _indexModel.rtb_ReceiveMessage_Text += $"�� {_indexModel.cmb_Port_Text} ���\�_�}" + Environment.NewLine;

            return View("Index", _indexModel);
        }

        [HttpPost]
        public IActionResult btn_SendMessage_Click(IndexModel indexModel)
        {
            try
            {
                // ���Ƽg�J���ɭ�, �|Ĳ�o SerialDataReceivedEventHandler �ƥ�,
                // �ð����� DataReceivedHandler
                _indexModel.RS232.Write(indexModel.txt_SendMessage_Text + "\n");
                _indexModel.txt_SendMessage_Text = indexModel.txt_SendMessage_Text;
                _indexModel.rtb_ReceiveMessage_Text += $"���\�ǰe : {indexModel.txt_SendMessage_Text} " + Environment.NewLine;
            }
            catch (Exception ex)
            {
                _indexModel.RS232.Dispose();
                _indexModel.rtb_ReceiveMessage_Text += ex.Message + Environment.NewLine;
            }

            return View("Index", _indexModel);
        }
    }
}
