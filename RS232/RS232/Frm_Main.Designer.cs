namespace RS232
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
            cmb_Port = new ComboBox();
            btn_Connect = new Button();
            txt_SendMessage = new TextBox();
            btn_SendMessage = new Button();
            btn_Disconnect = new Button();
            rtb_ReceiveMessage = new RichTextBox();
            lbl_OriginalMessage = new Label();
            rtb_ProcessedMessage = new RichTextBox();
            lbl_ProcessedMessage = new Label();
            btn_CleanRtb = new Button();
            SuspendLayout();
            // 
            // cmb_Port
            // 
            cmb_Port.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmb_Port.FormattingEnabled = true;
            cmb_Port.Location = new Point(12, 12);
            cmb_Port.Name = "cmb_Port";
            cmb_Port.Size = new Size(164, 43);
            cmb_Port.TabIndex = 0;
            cmb_Port.SelectedIndexChanged += cmb_Port_SelectedIndexChanged;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(182, 12);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(92, 43);
            btn_Connect.TabIndex = 1;
            btn_Connect.Text = "連線";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // txt_SendMessage
            // 
            txt_SendMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_SendMessage.Location = new Point(12, 61);
            txt_SendMessage.Name = "txt_SendMessage";
            txt_SendMessage.Size = new Size(262, 42);
            txt_SendMessage.TabIndex = 2;
            // 
            // btn_SendMessage
            // 
            btn_SendMessage.Location = new Point(280, 61);
            btn_SendMessage.Name = "btn_SendMessage";
            btn_SendMessage.Size = new Size(92, 43);
            btn_SendMessage.TabIndex = 3;
            btn_SendMessage.Text = "傳送";
            btn_SendMessage.UseVisualStyleBackColor = true;
            btn_SendMessage.Click += btn_SendMessage_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Location = new Point(280, 12);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(92, 43);
            btn_Disconnect.TabIndex = 4;
            btn_Disconnect.Text = "斷開";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // rtb_ReceiveMessage
            // 
            rtb_ReceiveMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            rtb_ReceiveMessage.Location = new Point(12, 144);
            rtb_ReceiveMessage.Name = "rtb_ReceiveMessage";
            rtb_ReceiveMessage.Size = new Size(360, 405);
            rtb_ReceiveMessage.TabIndex = 5;
            rtb_ReceiveMessage.Text = "";
            // 
            // lbl_OriginalMessage
            // 
            lbl_OriginalMessage.AutoSize = true;
            lbl_OriginalMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_OriginalMessage.Location = new Point(129, 106);
            lbl_OriginalMessage.Name = "lbl_OriginalMessage";
            lbl_OriginalMessage.Size = new Size(123, 35);
            lbl_OriginalMessage.TabIndex = 6;
            lbl_OriginalMessage.Text = "原始訊息";
            // 
            // rtb_ProcessedMessage
            // 
            rtb_ProcessedMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            rtb_ProcessedMessage.Location = new Point(378, 144);
            rtb_ProcessedMessage.Name = "rtb_ProcessedMessage";
            rtb_ProcessedMessage.Size = new Size(360, 405);
            rtb_ProcessedMessage.TabIndex = 7;
            rtb_ProcessedMessage.Text = "";
            // 
            // lbl_ProcessedMessage
            // 
            lbl_ProcessedMessage.AutoSize = true;
            lbl_ProcessedMessage.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_ProcessedMessage.Location = new Point(492, 106);
            lbl_ProcessedMessage.Name = "lbl_ProcessedMessage";
            lbl_ProcessedMessage.Size = new Size(150, 35);
            lbl_ProcessedMessage.TabIndex = 8;
            lbl_ProcessedMessage.Text = "處理後訊息";
            // 
            // btn_CleanRtb
            // 
            btn_CleanRtb.Location = new Point(526, 36);
            btn_CleanRtb.Name = "btn_CleanRtb";
            btn_CleanRtb.Size = new Size(92, 43);
            btn_CleanRtb.TabIndex = 9;
            btn_CleanRtb.Text = "清空訊息";
            btn_CleanRtb.UseVisualStyleBackColor = true;
            btn_CleanRtb.Click += btn_CleanRtb_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btn_CleanRtb);
            Controls.Add(lbl_ProcessedMessage);
            Controls.Add(rtb_ProcessedMessage);
            Controls.Add(lbl_OriginalMessage);
            Controls.Add(rtb_ReceiveMessage);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_SendMessage);
            Controls.Add(txt_SendMessage);
            Controls.Add(btn_Connect);
            Controls.Add(cmb_Port);
            Name = "Frm_Main";
            Text = "RS232";
            TopLevel = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Port;
        private Button btn_Connect;
        private TextBox txt_SendMessage;
        private Button btn_SendMessage;
        private Button btn_Disconnect;
        private RichTextBox rtb_ReceiveMessage;
        private Label lbl_OriginalMessage;
        private RichTextBox rtb_ProcessedMessage;
        private Label lbl_ProcessedMessage;
        private Button btn_CleanRtb;
    }
}
