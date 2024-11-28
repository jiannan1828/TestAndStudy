namespace Training3
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
            lbl_Task1 = new Label();
            lbl_Task2 = new Label();
            btn_Task1 = new Button();
            btn_Task2 = new Button();
            SuspendLayout();
            // 
            // lbl_Task1
            // 
            lbl_Task1.AutoSize = true;
            lbl_Task1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_Task1.Location = new Point(82, 79);
            lbl_Task1.Name = "lbl_Task1";
            lbl_Task1.Size = new Size(31, 35);
            lbl_Task1.TabIndex = 0;
            lbl_Task1.Text = "0";
            // 
            // lbl_Task2
            // 
            lbl_Task2.AutoSize = true;
            lbl_Task2.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_Task2.Location = new Point(238, 79);
            lbl_Task2.Name = "lbl_Task2";
            lbl_Task2.Size = new Size(31, 35);
            lbl_Task2.TabIndex = 1;
            lbl_Task2.Text = "0";
            // 
            // btn_Task1
            // 
            btn_Task1.Location = new Point(40, 153);
            btn_Task1.Name = "btn_Task1";
            btn_Task1.Size = new Size(111, 71);
            btn_Task1.TabIndex = 2;
            btn_Task1.Text = "執行序1";
            btn_Task1.UseVisualStyleBackColor = true;
            btn_Task1.Click += btn_Task1_Click;
            // 
            // btn_Task2
            // 
            btn_Task2.Location = new Point(191, 153);
            btn_Task2.Name = "btn_Task2";
            btn_Task2.Size = new Size(111, 71);
            btn_Task2.TabIndex = 3;
            btn_Task2.Text = "執行序2";
            btn_Task2.UseVisualStyleBackColor = true;
            btn_Task2.Click += btn_Task2_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 310);
            Controls.Add(btn_Task2);
            Controls.Add(btn_Task1);
            Controls.Add(lbl_Task2);
            Controls.Add(lbl_Task1);
            Name = "frm_Main";
            Text = "執行緒練習";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Task1;
        private Label lbl_Task2;
        private Button btn_Task1;
        private Button btn_Task2;
    }
}
