namespace Training4
{
    partial class frm_Change3
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
            txt_Change3 = new TextBox();
            btn_OK = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // txt_Change3
            // 
            txt_Change3.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Change3.Location = new Point(12, 12);
            txt_Change3.Name = "txt_Change3";
            txt_Change3.Size = new Size(262, 129);
            txt_Change3.TabIndex = 0;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(280, 12);
            btn_OK.Name = "btn_OK";
            btn_OK.RightToLeft = RightToLeft.No;
            btn_OK.Size = new Size(145, 58);
            btn_OK.TabIndex = 1;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(280, 83);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(145, 58);
            btn_Cancel.TabIndex = 2;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // frm_Change3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 152);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_OK);
            Controls.Add(txt_Change3);
            Name = "frm_Change3";
            Text = "frm_Change3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Change3;
        private Button btn_OK;
        private Button btn_Cancel;
    }
}