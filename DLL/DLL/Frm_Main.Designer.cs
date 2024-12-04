namespace DLL
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
            btn_RS232 = new Button();
            SuspendLayout();
            // 
            // btn_RS232
            // 
            btn_RS232.Location = new Point(12, 12);
            btn_RS232.Name = "btn_RS232";
            btn_RS232.Size = new Size(128, 61);
            btn_RS232.TabIndex = 0;
            btn_RS232.Text = "RS232";
            btn_RS232.UseVisualStyleBackColor = true;
            btn_RS232.Click += btn_RS232_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_RS232);
            Name = "Frm_Main";
            Text = "DLL引用表單";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_RS232;
    }
}
