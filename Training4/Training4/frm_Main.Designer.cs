namespace Training4
{
    partial class frm_Main
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
            btn_Change1 = new Button();
            btn_Change2 = new Button();
            lbl_Change = new Label();
            btn_Change3 = new Button();
            SuspendLayout();
            // 
            // btn_Change1
            // 
            btn_Change1.Location = new Point(267, 12);
            btn_Change1.Name = "btn_Change1";
            btn_Change1.Size = new Size(190, 91);
            btn_Change1.TabIndex = 0;
            btn_Change1.Text = "將標籤改為1";
            btn_Change1.UseVisualStyleBackColor = true;
            btn_Change1.Click += btn_Change1_Click;
            // 
            // btn_Change2
            // 
            btn_Change2.Location = new Point(267, 109);
            btn_Change2.Name = "btn_Change2";
            btn_Change2.Size = new Size(190, 91);
            btn_Change2.TabIndex = 1;
            btn_Change2.Text = "將標籤改為2";
            btn_Change2.UseVisualStyleBackColor = true;
            btn_Change2.Click += btn_Change2_Click;
            // 
            // lbl_Change
            // 
            lbl_Change.AutoSize = true;
            lbl_Change.Font = new Font("Microsoft JhengHei UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_Change.Location = new Point(23, 51);
            lbl_Change.Name = "lbl_Change";
            lbl_Change.Size = new Size(108, 122);
            lbl_Change.TabIndex = 2;
            lbl_Change.Text = "0";
            // 
            // btn_Change3
            // 
            btn_Change3.Location = new Point(23, 206);
            btn_Change3.Name = "btn_Change3";
            btn_Change3.Size = new Size(434, 118);
            btn_Change3.TabIndex = 3;
            btn_Change3.Text = "自定義更改標籤";
            btn_Change3.UseVisualStyleBackColor = true;
            btn_Change3.Click += btn_Change3_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 336);
            Controls.Add(btn_Change3);
            Controls.Add(lbl_Change);
            Controls.Add(btn_Change2);
            Controls.Add(btn_Change1);
            Name = "frm_Main";
            Text = "多表單練習";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Change1;
        private Button btn_Change2;
        private Label lbl_Change;
        private Button btn_Change3;
    }
}
