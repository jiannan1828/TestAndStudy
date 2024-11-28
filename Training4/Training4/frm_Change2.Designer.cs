namespace Training4
{
    partial class frm_Change2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_OK = new Button();
            btn_Cancel = new Button();
            lbl_Change2 = new Label();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(12, 76);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(147, 64);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(165, 76);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(147, 64);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Change2
            // 
            lbl_Change2.AutoSize = true;
            lbl_Change2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_Change2.Location = new Point(57, 26);
            lbl_Change2.Name = "lbl_Change2";
            lbl_Change2.Size = new Size(220, 35);
            lbl_Change2.TabIndex = 2;
            lbl_Change2.Text = "是否將標籤改為2";
            lbl_Change2.UseMnemonic = false;
            // 
            // frm_Change2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 156);
            Controls.Add(lbl_Change2);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Name = "frm_Change2";
            Text = "frm_Change2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Button btn_Cancel;
        private Label lbl_Change2;
    }
}