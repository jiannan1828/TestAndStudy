using System;
using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;

namespace Training8
{
    public partial class Frm_Maim : Form
    {
        private OpenFileDialog openPythonFileDialog = new OpenFileDialog();

        public Frm_Maim()
        {
            InitializeComponent();
        }

        private void btn_PythonPath_Click(object sender, EventArgs e)
        {


            openPythonFileDialog.Filter = "Python Files (*.py)|*.py";

            if (openPythonFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_OpenPythonFilePath.Text = openPythonFileDialog.FileName;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Users\r417t\AppData\Local\Programs\Python\Python39\python.exe", // @ ��� // ������ / ���N��
                    Arguments = $"\"{txt_OpenPythonFilePath.Text}\"", // \" ��ܦb�r�ꤤ���J"���N��
                    RedirectStandardOutput = true, // ����зǿ�X
                    UseShellExecute = false, // ���ϥΩR�O���ܦr������{��
                    CreateNoWindow = true // ����ܩR�O���ܦr�����f
                };

                // �Ұ� Python �}��
                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();

                string strPythonFileDatas = process.StandardOutput.ReadToEnd();

                MessageBox.Show(strPythonFileDatas);

                double[][] doublePythonFileDatas = JsonSerializer.Deserialize<double[][]>(strPythonFileDatas); // �N JSON�r�� �ϧǦC�Ƭ� double[][]

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.WriteLine(doublePythonFileDatas[i][j]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ū���ɮ׮ɵo�Ϳ��~: {ex.Message}");
            }
        }
    }
}
