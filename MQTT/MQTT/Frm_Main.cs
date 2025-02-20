using MQTTnet;
using System.Text;

namespace MQTT
{
    public partial class Frm_Main : Form
    {
        private IMqttClient mqttClient;

        private List<string> subscribedTopics = new List<string>(); // �x�s�w�q�\���D�D

        public Frm_Main()
        {
            InitializeComponent();
        }

        private async void Frm_Main_Load(object sender, EventArgs e)
        {
            // �Ы� MQTT �Ȥ��
            var factory = new MqttClientFactory();
            mqttClient = factory.CreateMqttClient();

            // �]�w�s���Ѽ�
            var options = new MqttClientOptionsBuilder()
                .WithClientId("192.168.0.101")
                .WithTcpServer("192.168.0.100", 1883) // �]�w���A���� IP �a�}�M�ݤf��
                .Build();

            // �s���� MQTT ���A��
            await mqttClient.ConnectAsync(options, CancellationToken.None);

            mqttClient.ApplicationMessageReceivedAsync += MQTT_ReceiveMessage;

        }
        private async void btn_Subscribe_Click(object sender, EventArgs e)
        {
            string topic = txt_Topic.Text.Trim();

            if (string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("�п�J MQTT �D�D!", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!subscribedTopics.Contains(topic)) // �קK���ƭq�\
            {
                await mqttClient.SubscribeAsync(topic); // ���ݭq�\����, �~�|����U�@��{���X
                subscribedTopics.Add(topic);
                rtb_ReceiveMessage.AppendText($"���\�q�\�D�D: {topic}{Environment.NewLine}");
            }
            else
            {
                rtb_ReceiveMessage.AppendText($"�w�g�q�\�L�ӥD�D: {topic}{Environment.NewLine}");
            }
        }

        private Task MQTT_ReceiveMessage(MqttApplicationMessageReceivedEventArgs e)
        {
            var message = e.ApplicationMessage;
            var payload = System.Text.Encoding.UTF8.GetString(message.Payload);

            // �ϥ� Invoke ��k�ӽT�O�b UI �u�{�W��s RichTextBox
            if (rtb_ReceiveMessage.InvokeRequired)
            {
                rtb_ReceiveMessage.Invoke(new Action(() => rtb_ReceiveMessage.AppendText($"�����쪺�T��: {payload} �ӦۥD�D: {message.Topic}{Environment.NewLine}")));
            }
            else
            {
                rtb_ReceiveMessage.AppendText($"�����쪺�T��: {payload} �ӦۥD�D: {message.Topic}{Environment.NewLine}");
            }

            return Task.CompletedTask; // ��^�w����������
        }

        private async void btn_SendMessage_Click(object sender, EventArgs e)
        {
            string topic = txt_Topic.Text.Trim(); // �q TextBox ����D�D
            string messageContent = txt_SendMessage.Text.Trim(); // �q TextBox ����������e

            if (string.IsNullOrEmpty(topic) || string.IsNullOrEmpty(messageContent))
            {
                MessageBox.Show("�п�J�D�D�M�������e!", "���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // �Ы� MQTT ����
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic) // �]�w�D�D
                .WithPayload(messageContent) // �]�w�������e
                .Build();

            // �o�e������ MQTT ���A��
            await mqttClient.PublishAsync(message, CancellationToken.None);

            rtb_ReceiveMessage.AppendText($"���\�o�e�T��: {messageContent} �D�D: {topic}{Environment.NewLine}");
        }
    }
}
