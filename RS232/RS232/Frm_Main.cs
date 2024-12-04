using System.IO.Ports; // �s���� .NET Framework ���]�t IOPorts �\��, �n�ۦ�U���{���w

namespace RS232
{
    public partial class Frm_Main : Form
    {
        SerialPort RS232 = new SerialPort();
        String[] processedMessage;

        // �s�W�@�� Buffer, ���ݱ�������Ÿ�
        string Received_Data_Buffer = "";

        public Frm_Main()
        {
            InitializeComponent();

            btn_Connect.Enabled = false;
            btn_SendMessage.Enabled = false;

            // �o��i�Ϊ��s����, ����ܦb cmb �W
            String[] port_Enable = SerialPort.GetPortNames();
            foreach (var item in port_Enable)
            {
                cmb_Port.Items.Add(item);
            }

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //�i�S�v
                RS232.BaudRate = 9600;
                //��Ʀ�
                RS232.DataBits = 8;
                RS232.PortName = cmb_Port.Text;
                //��Ӱ����
                RS232.StopBits = System.IO.Ports.StopBits.One;
                //�L�_�������
                RS232.Parity = System.IO.Ports.Parity.None;
                RS232.ReadTimeout = 100;
                RS232.Open();

                // �p�G serialPort �}�Ҧ��\
                if (RS232.IsOpen)
                {
                    MessageBox.Show("��" + cmb_Port.Text + "�}�Ҧ��\");

                    cmb_Port.Enabled = false;
                    btn_Connect.Enabled = false;
                    btn_SendMessage.Enabled = true;
                }
                else
                {
                    MessageBox.Show("��" + cmb_Port.Text + "�}�ҥ���");
                    return;
                }

                //�K�[�ƥ�B�z�{�ǥH��ť��f��Ʊ���
                RS232.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                RS232.Dispose();
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            RS232.Dispose();

            cmb_Port.Enabled = true;
            btn_Connect.Enabled = true;
            btn_SendMessage.Enabled = false;
        }

        private void cmb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Connect.Enabled = true;
        }

        private void btn_SendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                // ���Ƽg�J���ɭ�, �|Ĳ�o SerialDataReceivedEventHandler �ƥ�,
                // �ð����� DataReceivedHandler
                RS232.Write(txt_SendMessage.Text + "\n");
            }
            catch (Exception ex)
            {
                RS232.Dispose(); MessageBox.Show(ex.Message);
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            // �B�Ψƥ�ǹL�Ӫ����, ���O�� SerialPort
            SerialPort SerialPort_Receive = (SerialPort)sender;

            // Ū�� RS232 �Ҧ��w��F�����
            string Received_Data = SerialPort_Receive.ReadExisting();

            // �N��F����ƥ[��w�Ĥ�
            Received_Data_Buffer += Received_Data;

            // ���p�˴��촫��Ÿ�
            if (Received_Data_Buffer.Contains("\n"))
            {
                // �N�����������ܦb richtextbox �W
                rtb_ReceiveMessage.Invoke(new Action(() =>
                {
                    rtb_ReceiveMessage.AppendText(Received_Data_Buffer);

                    processedMessage = processMessage(Received_Data_Buffer);

                    foreach (string line in processedMessage)
                    {
                        rtb_ProcessedMessage.AppendText(line);
                    }
                }));

                // �M�� buffer
                Received_Data_Buffer = "";
            }
        }

        private string[] processMessage(string Message)
        {
            if (Message.Contains("abc"))
            {
                MessageBox.Show("�r�ꤤ�t��abc");
            }
            Message = Message.Trim('{','}'); // �h������{ }
            Message = Message.Replace("\"","").Replace(" ","").Replace("{","").Replace("}", "").Replace(":"," -> ".Replace("\n","")); // �h�� " �Ů�
            processedMessage = Message.Split(','); // �H , ������
            return processedMessage;
        }

        private void btn_CleanRtb_Click(object sender, EventArgs e)
        {
            rtb_ReceiveMessage.Clear();
            rtb_ProcessedMessage.Clear();
        }
    }
}
