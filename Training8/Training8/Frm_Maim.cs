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
                    FileName = @"C:\Users\r417t\AppData\Local\Programs\Python\Python39\python.exe", // @ 表示 // 替換成 / 的意思
                    Arguments = $"\"{txt_OpenPythonFilePath.Text}\"", // \" 表示在字串中插入"的意思
                    RedirectStandardOutput = true, // 捕獲標準輸出
                    UseShellExecute = false, // 不使用命令提示字元執行程式
                    CreateNoWindow = true // 不顯示命令提示字元窗口
                };

                // 啟動 Python 腳本
                Process process = new Process
                {
                    StartInfo = startInfo
                };

                process.Start();

                string strPythonFileDatas = process.StandardOutput.ReadToEnd();

                MessageBox.Show(strPythonFileDatas);

                double[][] doublePythonFileDatas = JsonSerializer.Deserialize<double[][]>(strPythonFileDatas); // 將 JSON字串 反序列化為 double[][]

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
                MessageBox.Show($"讀取檔案時發生錯誤: {ex.Message}");
            }
        }
    }
}
