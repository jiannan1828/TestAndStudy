// �ϥ� NuGet �U���� ���O�w�]�Ҧp System.IO.Ports�^�ɡA���u�|�Q�w�˨��e�M�פ��A
// �åB���|�۰ʥ]�t�b��L�M�פ��A�Y�ϧA�q�@�ӱM�פޥΥt�@�ӱM�סC
// �o�]�N�O������A�|�b DLL �M�� ���J�� System.IO.Ports ���O�w�䤣�쪺���~�C
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
