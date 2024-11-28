namespace Training4
{
    partial class frm_Change1
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
            lbl_Change1 = new Label();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(12, 97);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(158, 78);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(176, 97);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(158, 78);
            btn_Cancel.TabIndex = 1;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Change1
            // 
            lbl_Change1.AutoSize = true;
            lbl_Change1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_Change1.Location = new Point(67, 39);
            lbl_Change1.Name = "lbl_Change1";
            lbl_Change1.Size = new Size(220, 35);
            lbl_Change1.TabIndex = 2;
            lbl_Change1.Text = "是否將標籤改為1";
            // 
            // frm_Change1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 187);
            Controls.Add(lbl_Change1);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Name = "frm_Change1";
            Text = "frm_Change1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Button btn_Cancel;
        private Label lbl_Change1;
    }
}