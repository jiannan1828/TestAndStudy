namespace MQTT
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Topic = new TextBox();
            btn_Subscribe = new Button();
            txt_SendMessage = new TextBox();
            btn_SendMessage = new Button();
            btn_Unsubscribe = new Button();
            rtb_ReceiveMessage = new RichTextBox();
            SuspendLayout();
            // 
            // txt_Topic
            // 
            txt_Topic.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Topic.Location = new Point(12, 12);
            txt_Topic.Name = "txt_Topic";
            txt_Topic.Size = new Size(152, 49);
            txt_Topic.TabIndex = 0;
            // 
            // btn_Subscribe
            // 
            btn_Subscribe.Location = new Point(170, 12);
            btn_Subscribe.Name = "btn_Subscribe";
            btn_Subscribe.Size = new Size(124, 49);
            btn_Subscribe.TabIndex = 1;
            btn_Subscribe.Text = "訂閱";
            btn_Subscribe.UseVisualStyleBackColor = true;
            btn_Subscribe.Click += btn_Subscribe_Click;
            // 
            // txt_SendMessage
            // 
            txt_SendMessage.Font = new Font("Microsoft JhengHei UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_SendMessage.Location = new Point(12, 67);
            txt_SendMessage.Name = "txt_SendMessage";
            txt_SendMessage.Size = new Size(282, 49);
            txt_SendMessage.TabIndex = 2;
            // 
            // btn_SendMessage
            // 
            btn_SendMessage.Location = new Point(300, 67);
            btn_SendMessage.Name = "btn_SendMessage";
            btn_SendMessage.Size = new Size(124, 49);
            btn_SendMessage.TabIndex = 3;
            btn_SendMessage.Text = "發送";
            btn_SendMessage.UseVisualStyleBackColor = true;
            btn_SendMessage.Click += btn_SendMessage_Click;
            // 
            // btn_Unsubscribe
            // 
            btn_Unsubscribe.Location = new Point(300, 12);
            btn_Unsubscribe.Name = "btn_Unsubscribe";
            btn_Unsubscribe.Size = new Size(124, 49);
            btn_Unsubscribe.TabIndex = 4;
            btn_Unsubscribe.Text = "取消訂閱";
            btn_Unsubscribe.UseVisualStyleBackColor = true;
            // 
            // rtb_ReceiveMessage
            // 
            rtb_ReceiveMessage.Location = new Point(12, 122);
            rtb_ReceiveMessage.Name = "rtb_ReceiveMessage";
            rtb_ReceiveMessage.Size = new Size(412, 561);
            rtb_ReceiveMessage.TabIndex = 5;
            rtb_ReceiveMessage.Text = "";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 695);
            Controls.Add(rtb_ReceiveMessage);
            Controls.Add(btn_Unsubscribe);
            Controls.Add(btn_SendMessage);
            Controls.Add(txt_SendMessage);
            Controls.Add(btn_Subscribe);
            Controls.Add(txt_Topic);
            Name = "Frm_Main";
            Text = "MQTT";
            Load += Frm_Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Topic;
        private Button btn_Subscribe;
        private TextBox txt_SendMessage;
        private Button btn_SendMessage;
        private Button btn_Unsubscribe;
        private RichTextBox rtb_ReceiveMessage;
    }
}
