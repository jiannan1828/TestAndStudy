// 使用 NuGet 下載的 類別庫（例如 System.IO.Ports）時，它只會被安裝到當前專案中，
// 並且不會自動包含在其他專案中，即使你從一個專案引用另一個專案。
// 這也就是為什麼你會在 DLL 專案 中遇到 System.IO.Ports 類別庫找不到的錯誤。
using System.IO.Ports;
using RS232;

namespace DLL
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_RS232_Click(object sender, EventArgs e)
        {
            RS232.Frm_Main RS232 = new RS232.Frm_Main();
            RS232.Show();
        }
    }
}
