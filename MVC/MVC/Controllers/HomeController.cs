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

        public string Received_Data_Buffer = "";


        [HttpGet]
        public IActionResult Index()
        {
            List<string> Items = new List<string>();
            String[] port_Enable = SerialPort.GetPortNames();
            foreach (var item in port_Enable)
            {
                Items.Add(item);
            }

            HttpContext.Session.SetObjectAsJson("cmb_Port_Items", Items);

            var model = new IndexModel
            {
                cmb_Port_Items = Items
            };

            return View("Index", model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult RadioButtonSubmit(IndexModel indexModel)
        {
            var currentText = HttpContext.Session.GetString("IndexModel_RichTextboxValue");
            currentText += "你選擇的 RadioButton 的選項是：" + indexModel.RadioButtonSelectedOption + Environment.NewLine;
            HttpContext.Session.SetString("IndexModel_RichTextboxValue", currentText);

            var model = new IndexModel
            {
                RichTextboxValue = HttpContext.Session.GetString("IndexModel_RichTextboxValue")
            };

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult CheckBoxSubmit(IndexModel indexModel)
        {
            var currentText = HttpContext.Session.GetString("IndexModel_RichTextboxValue");
            currentText += "你選擇 CheckBox 的選項是： " + string.Join(", ", indexModel.CheckboxSelectedOptions) + Environment.NewLine;
            HttpContext.Session.SetString("IndexModel_RichTextboxValue", currentText);

            var model = new IndexModel
            {
                RichTextboxValue = HttpContext.Session.GetString("IndexModel_RichTextboxValue")
            };

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult TextBoxSubmit(IndexModel indexModel)
        {
            var currentText = HttpContext.Session.GetString("IndexModel_RichTextboxValue");
            currentText += "TextBox 輸入的值是： " + indexModel.TextboxValue + Environment.NewLine;
            HttpContext.Session.SetString("IndexModel_RichTextboxValue", currentText);

            var model = new IndexModel
            {
                RichTextboxValue = HttpContext.Session.GetString("IndexModel_RichTextboxValue")
            };

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult DropDownSubmit(IndexModel indexModel)
        {
            var currentText = HttpContext.Session.GetString("IndexModel_RichTextboxValue");
            currentText += "你選擇下拉式選單的選項是： " + indexModel.DropDownSelectedOption + Environment.NewLine;
            HttpContext.Session.SetString("IndexModel_RichTextboxValue", currentText);

            var model = new IndexModel
            {
                RichTextboxValue = HttpContext.Session.GetString("IndexModel_RichTextboxValue")
            };

            return View("Index", model);
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
                    var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                    currentText += $"埠 {indexModel.cmb_Port_Text} 開啟成功" + Environment.NewLine;
                    HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);
                    HttpContext.Session.SetString("cmb_Port_Text", indexModel.cmb_Port_Text);
                    HttpContext.Session.SetString("cmb_Port_Enabled", false.ToString());
                    HttpContext.Session.SetString("btn_Connect_Enabled", false.ToString());
                    HttpContext.Session.SetString("btn_Disconnect_Enabled", true.ToString());
                    HttpContext.Session.SetString("btn_SendMessage_Enabled", true.ToString());
                    
                    _indexModel.RS232.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                }
                else
                {
                    var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                    currentText += $"埠 {indexModel.cmb_Port_Text} 開啟失敗" + Environment.NewLine; ;
                    HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);
                }
            }
            catch (Exception ex)
            {
                _indexModel.RS232.Dispose();

                var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                currentText += ex.Message + Environment.NewLine;
                HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);
            }

            var model = new IndexModel
            {
                rtb_ReceiveMessage_Text = HttpContext.Session.GetString("rtb_ReceiveMessage_Text"),
                cmb_Port_Text = HttpContext.Session.GetString("cmb_Port_Text"),
                cmb_Port_Enabled = HttpContext.Session.GetString("cmb_Port_Enabled"),
                cmb_Port_Items = HttpContext.Session.GetObjectFromJson<List<string>>("cmb_Port_Items"),
                btn_Connect_Enabled = HttpContext.Session.GetString("btn_Connect_Enabled"),
                btn_Disconnect_Enabled = HttpContext.Session.GetString("btn_Disconnect_Enabled"),
                btn_SendMessage_Enabled = HttpContext.Session.GetString("btn_SendMessage_Enabled"),
                txt_SendMessage_Text = HttpContext.Session.GetString("txt_SendMessage_Text")
            };

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult btn_Disconnect_Click(IndexModel indexModel)
        {
            _indexModel.RS232.Dispose();

            HttpContext.Session.SetString("cmb_Port_Enabled", true.ToString());
            HttpContext.Session.SetString("btn_Connect_Enabled", true.ToString());
            HttpContext.Session.SetString("btn_Disconnect_Enabled", false.ToString());
            HttpContext.Session.SetString("btn_SendMessage_Enabled", false.ToString());

            var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
            currentText += $"埠 {HttpContext.Session.GetString("cmb_Port_Text")} 成功斷開" + Environment.NewLine;
            HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);

            var model = new IndexModel
            {
                rtb_ReceiveMessage_Text = HttpContext.Session.GetString("rtb_ReceiveMessage_Text"),
                cmb_Port_Text = HttpContext.Session.GetString("cmb_Port_Text"),
                cmb_Port_Enabled = HttpContext.Session.GetString("cmb_Port_Enabled"),
                cmb_Port_Items = HttpContext.Session.GetObjectFromJson<List<string>>("cmb_Port_Items"),
                btn_Connect_Enabled = HttpContext.Session.GetString("btn_Connect_Enabled"),
                btn_Disconnect_Enabled = HttpContext.Session.GetString("btn_Disconnect_Enabled"),
                btn_SendMessage_Enabled = HttpContext.Session.GetString("btn_SendMessage_Enabled"),
                txt_SendMessage_Text = HttpContext.Session.GetString("txt_SendMessage_Text")
            };

            return View("Index", model);
        }

        [HttpPost]
        public IActionResult btn_SendMessage_Click(IndexModel indexModel)
        {
            try
            {
                _indexModel.RS232.Write(indexModel.txt_SendMessage_Text + "\n");
                HttpContext.Session.SetString("txt_SendMessage_Text", indexModel.txt_SendMessage_Text);

                var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                currentText += $"成功傳送 : {indexModel.txt_SendMessage_Text} " + Environment.NewLine;
                HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);
            }
            catch (Exception ex)
            {
                _indexModel.RS232.Dispose();

                var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                currentText += ex.Message + Environment.NewLine;
                HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);
            }

            var model = new IndexModel
            {
                rtb_ReceiveMessage_Text = HttpContext.Session.GetString("rtb_ReceiveMessage_Text"),
                cmb_Port_Text = HttpContext.Session.GetString("cmb_Port_Text"),
                cmb_Port_Enabled = HttpContext.Session.GetString("cmb_Port_Enabled"),
                cmb_Port_Items = HttpContext.Session.GetObjectFromJson<List<string>>("cmb_Port_Items"),
                btn_Connect_Enabled = HttpContext.Session.GetString("btn_Connect_Enabled"),
                btn_Disconnect_Enabled = HttpContext.Session.GetString("btn_Disconnect_Enabled"),
                btn_SendMessage_Enabled = HttpContext.Session.GetString("btn_SendMessage_Enabled"),
                txt_SendMessage_Text = HttpContext.Session.GetString("txt_SendMessage_Text")
            };

            return View("Index", model);
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort SerialPort_Receive = (SerialPort)sender;

            string Received_Data = SerialPort_Receive.ReadExisting();

            Received_Data_Buffer += Received_Data;

            if (Received_Data_Buffer.Contains("\n"))
            {
                var currentText = HttpContext.Session.GetString("rtb_ReceiveMessage_Text");
                currentText += Received_Data_Buffer;
                HttpContext.Session.SetString("rtb_ReceiveMessage_Text", currentText);

                Received_Data_Buffer = "";
            }
        }
    }
}
