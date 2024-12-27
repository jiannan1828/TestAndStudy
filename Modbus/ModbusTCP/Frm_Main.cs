using NModbus;
using System.Net.Sockets;
using System.Text;

namespace ModbusTCP
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            using (var client = new TcpClient("127.0.0.1", 502))
            {
                var factory = new ModbusFactory();
                var master = factory.CreateMaster(client);
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
    }
}
