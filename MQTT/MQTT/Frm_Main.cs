using MQTTnet;
using System.Text;

namespace MQTT
{
    public partial class Frm_Main : Form
    {
        private IMqttClient mqttClient;

        private List<string> subscribedTopics = new List<string>(); // 儲存已訂閱的主題

        public Frm_Main()
        {
            InitializeComponent();
        }

        private async void Frm_Main_Load(object sender, EventArgs e)
        {
            // 創建 MQTT 客戶端
            var factory = new MqttClientFactory();
            mqttClient = factory.CreateMqttClient();

            // 設定連接參數
            var options = new MqttClientOptionsBuilder()
                .WithClientId("192.168.0.101")
                .WithTcpServer("192.168.0.100", 1883) // 設定伺服器的 IP 地址和端口號
                .Build();

            // 連接到 MQTT 伺服器
            await mqttClient.ConnectAsync(options, CancellationToken.None);

            mqttClient.ApplicationMessageReceivedAsync += MQTT_ReceiveMessage;

        }
        private async void btn_Subscribe_Click(object sender, EventArgs e)
        {
            string topic = txt_Topic.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("請輸入 MQTT 主題!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!subscribedTopics.Contains(topic)) // 避免重複訂閱
            {
                await mqttClient.SubscribeAsync(topic); // 等待訂閱完成, 才會執行下一行程式碼
                subscribedTopics.Add(topic);
                rtb_ReceiveMessage.AppendText($"成功訂閱主題: {topic}{Environment.NewLine}");
            }
            else
            {
                rtb_ReceiveMessage.AppendText($"已經訂閱過該主題: {topic}{Environment.NewLine}");
            }
        }

        private Task MQTT_ReceiveMessage(MqttApplicationMessageReceivedEventArgs e)
        {
            var message = e.ApplicationMessage;
            var payload = System.Text.Encoding.UTF8.GetString(message.Payload);

            // 使用 Invoke 方法來確保在 UI 線程上更新 RichTextBox
            if (rtb_ReceiveMessage.InvokeRequired)
            {
                rtb_ReceiveMessage.Invoke(new Action(() => rtb_ReceiveMessage.AppendText($"接收到的訊息: {payload} 來自主題: {message.Topic}{Environment.NewLine}")));
            }
            else
            {
                rtb_ReceiveMessage.AppendText($"接收到的訊息: {payload} 來自主題: {message.Topic}{Environment.NewLine}");
            }

            return Task.CompletedTask; // 返回已完成的任務
        }

        private async void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string topic = txt_Topic.Text.Trim(); // 從 TextBox 獲取主題
            string messageContent = txt_SendMessage.Text.Trim(); // 從 TextBox 獲取消息內容

            if (string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("請輸入主題和消息內容!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 創建 MQTT 消息
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic) // 設定主題
                .WithPayload(messageContent) // 設定消息內容
                .Build();

            // 發送消息到 MQTT 伺服器
            await mqttClient.PublishAsync(message, CancellationToken.None);

            rtb_ReceiveMessage.AppendText($"成功發送訊息: {messageContent} 主題: {topic}{Environment.NewLine}");
        }
    }
}
