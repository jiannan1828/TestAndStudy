using NModbus;
using NModbus.Serial;
using System.Net.Sockets;
using System.Text;
using System.IO.Ports;

namespace ModbusRTU
{
    public partial class Frm_Main : Form
    {
        SerialPort RS232 = new SerialPort();
        public Frm_Main()
        {
            InitializeComponent();

            String[] port_Enable = SerialPort.GetPortNames();
            foreach (var item in port_Enable)
            {
                cmb_Port.Items.Add(item);
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            var factory = new ModbusFactory();
            var master = factory.CreateRtuMaster(RS232);

            List<int> readDatas = new List<int>();

            dgv_Read.Rows.Clear();
            readDatas.Clear();

            switch (cmb_ReadType.Text)
            {
                case "�u��":
                    try
                    {
                        bool[] coils = master.ReadCoils(
                            byte.Parse(txt_SlaveAddress.Text),
                            ushort.Parse(txt_ReadAddress.Text),
                            ushort.Parse(txt_NumberOfPoint.Text)
                        );

                        readDatas.AddRange(new int[coils.Length]); // �ϥΫ��w�j�p��l��

                        for (int i = 0; i < coils.Length; i++)
                        {
                            readDatas[i] = coils[i] ? 1 : 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ū���u����~: {ex.Message}");
                    }

                    break;

                case "������J":
                    try
                    {
                        bool[] inputs = master.ReadInputs(
                            byte.Parse(txt_SlaveAddress.Text),
                            ushort.Parse(txt_ReadAddress.Text),
                            ushort.Parse(txt_NumberOfPoint.Text)
                        );

                        readDatas.AddRange(new int[inputs.Length]); // �ϥΫ��w�j�p��l��

                        for (int i = 0; i < inputs.Length; i++)
                        {
                            readDatas[i] = inputs[i] ? 1 : 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ū��������J���~: {ex.Message}");
                    }

                    break;

                case "�O���Ȧs��":
                    try
                    {
                        ushort[] holdingRegisters = master.ReadHoldingRegisters(
                            byte.Parse(txt_SlaveAddress.Text),
                            ushort.Parse(txt_ReadAddress.Text),
                            ushort.Parse(txt_NumberOfPoint.Text)
                        );

                        readDatas.AddRange(new int[holdingRegisters.Length]); // �ϥΫ��w�j�p��l��

                        for (int i = 0; i < holdingRegisters.Length; i++)
                        {
                            readDatas[i] = holdingRegisters[i];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ū���O���Ȧs�����~: {ex.Message}");
                    }

                    break;

                case "��J�Ȧs��":
                    try
                    {
                        ushort[] inputRegisters = master.ReadInputRegisters(
                            byte.Parse(txt_SlaveAddress.Text),
                            ushort.Parse(txt_ReadAddress.Text),
                            ushort.Parse(txt_NumberOfPoint.Text)
                        );

                        readDatas.AddRange(new int[inputRegisters.Length]); // �ϥΫ��w�j�p��l��

                        for (int i = 0; i < inputRegisters.Length; i++)
                        {
                            readDatas[i] = inputRegisters[i];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ū����J�Ȧs�����~: {ex.Message}");
                    }
                    break;

                default:
                    break;
            }

            for (int i = 0; i < readDatas.Count; i++)
            {

                dgv_Read.Rows.Add(
                    int.Parse(txt_ReadAddress.Text) + i,
                    readDatas[i]
                );
            }
        }
        
        private void btn_Write_Click(object sender, EventArgs e)
        {
            using (var client = new TcpClient("127.0.0.1", 502))
            {
                var factory = new ModbusFactory();
                var master = factory.CreateMaster(client);

                switch (cmb_WriteType.Text)
                {
                    case "�u��":
                        try
                        {
                            master.WriteSingleCoil(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_WriteAddress.Text),
                                bool.Parse(txt_WriteValue.Text)
                            );

                            MessageBox.Show("�g�J�u�馨�\");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"�g�J�u����~: {ex.Message}");
                        }

                        break;


                    case "�O���Ȧs��":

                        try
                        {
                            master.WriteSingleRegister(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_WriteAddress.Text),
                                ushort.Parse(txt_WriteValue.Text)
                            );

                            MessageBox.Show($"�g�J�O���Ȧs�����\");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"�g�J�O���Ȧs�����~: {ex.Message}");
                        }

                        break;

                    default:
                        break;
                }
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
                RS232.StopBits = StopBits.One;
                //�L�_�������
                RS232.Parity = Parity.None;
                RS232.ReadTimeout = 100;
                RS232.Open();

                // �p�G serialPort �}�Ҧ��\
                if (RS232.IsOpen)
                {
                    MessageBox.Show("��" + cmb_Port.Text + "�}�Ҧ��\");

                    cmb_Port.Enabled = false;
                    btn_Connect.Enabled = false;
                    btn_Disconnect.Enabled = true;
                    btn_Read.Enabled = true;
                    btn_Write.Enabled = true;
                }
                else
                {
                    MessageBox.Show("��" + cmb_Port.Text + "�}�ҥ���");
                    return;
                }
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
            btn_Disconnect.Enabled = false;
            btn_Read.Enabled = false;
            btn_Write.Enabled = false;
        }

        private void cmb_Port_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Connect.Enabled = true;
        }
    }
}
