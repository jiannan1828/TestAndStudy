using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

using System.Drawing.Imaging;
using System.IO.MemoryMappedFiles;

namespace CS2PYImage
{
    public partial class Frm_Main : Form
    {
        private VideoCapture capture;  // 捕獲攝像頭
        private Mat frame = new Mat();              // 當前影像幀
        private MemoryMappedFile mmf = null;

        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            // 创建共享内存
            mmf = MemoryMappedFile.CreateOrOpen("SharedMemory", 10 * 1024 * 1024);

            // 初始化攝像頭捕獲
            capture = new VideoCapture(0);  // 0 是第一個攝像頭，若有多個攝像頭可選擇不同的編號

            if (!capture.IsOpened)
            {
                MessageBox.Show("無法打開攝像頭！");
                return;
            }

            Application.Idle += ProcessFrame; // 當應用程式閒置時, 處理影像
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            capture.Read(frame);

            if (!frame.IsEmpty)
            {
                img_Camera.Image = frame;
            }
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            capture.Dispose(); // 释放攝像頭
            mmf?.Dispose(); // 释放共享内存
        }

        private void btn_Capture_Click(object sender, EventArgs e)
        {
            if (frame != null)
            {
                string filePath = @"C:\Users\r417t\Desktop\CCP_Contact_Probes\CS2PYImage\image.png";

                frame.Save(filePath);

                MessageBox.Show("影像已成功保存！");
            }
            else
            {
                MessageBox.Show("目前沒有影像可供保存！");
            }
        }

        private void btn_SharedMemory_Click(object sender, EventArgs e)
        {
            if (frame != null)
            {
                // 創建一個 VectorOfByte 來儲存編碼後的影像資料
                using (var vectorOfByte = new Emgu.CV.Util.VectorOfByte()) //宣告一個動態大小的字節
                {
                    // 使用 CvInvoke.Imencode 編碼影像並儲存到 VectorOfByte
                    bool success = CvInvoke.Imencode(".png", frame, vectorOfByte);

                    if (success)
                    {
                        // 将 VectorOfByte 转换为 byte[] 数组
                        byte[] imageBytes = vectorOfByte.ToArray();

                        // 将字节数据写入共享内存
                        using (var accessor = mmf.CreateViewAccessor())
                        {
                            // 将图像字节数组写入共享内存
                            accessor.WriteArray(0, imageBytes, 0, imageBytes.Length);

                            MessageBox.Show("成功寫入共享記憶體");
                        }
                    }
                    else
                    {
                        MessageBox.Show("影像編碼失敗！");
                    }
                }
            }
            else
            {
                MessageBox.Show("目前沒有影像可供保存！");
            }
        }
    }
}
