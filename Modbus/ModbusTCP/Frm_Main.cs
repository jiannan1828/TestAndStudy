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
                    case "線圈":
                        try
                        {
                            bool[] coils = master.ReadCoils(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_ReadAddress.Text),
                                ushort.Parse(txt_NumberOfPoint.Text)
                            );

                            readDatas.AddRange(new int[coils.Length]); // 使用指定大小初始化

                            for (int i = 0; i < coils.Length; i++)
                            {
                                readDatas[i] = coils[i] ? 1 : 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"讀取線圈錯誤: {ex.Message}");
                        }

                        break;

                    case "離散輸入":
                        try
                        {
                            bool[] inputs = master.ReadInputs(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_ReadAddress.Text),
                                ushort.Parse(txt_NumberOfPoint.Text)
                            );

                            readDatas.AddRange(new int[inputs.Length]); // 使用指定大小初始化

                            for (int i = 0; i < inputs.Length; i++)
                            {
                                readDatas[i] = inputs[i] ? 1 : 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"讀取離散輸入錯誤: {ex.Message}");
                        }

                        break;

                    case "保持暫存器":
                        try
                        {
                            ushort[] holdingRegisters = master.ReadHoldingRegisters(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_ReadAddress.Text),
                                ushort.Parse(txt_NumberOfPoint.Text)
                            );

                            readDatas.AddRange(new int[holdingRegisters.Length]); // 使用指定大小初始化

                            for (int i = 0; i < holdingRegisters.Length; i++)
                            {
                                readDatas[i] = holdingRegisters[i];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"讀取保持暫存器錯誤: {ex.Message}");
                        }

                        break;

                    case "輸入暫存器":
                        try
                        {
                            ushort[] inputRegisters = master.ReadInputRegisters(
                                byte.Parse(txt_SlaveAddress.Text),
                                ushort.Parse(txt_ReadAddress.Text),
                                ushort.Parse(txt_NumberOfPoint.Text)
                            );

                            readDatas.AddRange(new int[inputRegisters.Length]); // 使用指定大小初始化

                            for (int i = 0; i < inputRegisters.Length; i++)
                            {
                                readDatas[i] = inputRegisters[i];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"讀取輸入暫存器錯誤: {ex.Message}");
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
                    case "線圈":
                        try
                        {
                            master.WriteSingleCoil(
                                byte.Parse(txt_SlaveAddress.Text),   
                                ushort.Parse(txt_WriteAddress.Text), 
                                bool.Parse(txt_WriteValue.Text)           
                            );

                            MessageBox.Show("寫入線圈成功");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"寫入線圈錯誤: {ex.Message}");
                        }

                        break;


                    case "保持暫存器":

                        try
                        {
                            master.WriteSingleRegister(
                                byte.Parse(txt_SlaveAddress.Text),  
                                ushort.Parse(txt_WriteAddress.Text), 
                                ushort.Parse(txt_WriteValue.Text)         
                            );

                            MessageBox.Show($"寫入保持暫存器成功");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"寫入保持暫存器錯誤: {ex.Message}");
                        }

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
