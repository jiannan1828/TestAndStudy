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

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //波特率
                RS232.BaudRate = 9600;
                //資料位
                RS232.DataBits = 8;
                RS232.PortName = cmb_Port.Text;
                //兩個停止位
                RS232.StopBits = StopBits.One;
                //無奇偶校驗位
                RS232.Parity = Parity.None;
                RS232.ReadTimeout = 100;
                RS232.Open();

                // 如果 serialPort 開啟成功
                if (RS232.IsOpen)
                {
                    MessageBox.Show("埠" + cmb_Port.Text + "開啟成功");

                    cmb_Port.Enabled = false;
                    btn_Connect.Enabled = false;
                    btn_Disconnect.Enabled = true;
                    btn_Read.Enabled = true;
                    btn_Write.Enabled = true;
                }
                else
                {
                    MessageBox.Show("埠" + cmb_Port.Text + "開啟失敗");
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
