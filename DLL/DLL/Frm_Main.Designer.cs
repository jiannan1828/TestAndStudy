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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            RS232 = new RS232.Frm_Main();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_RS232
            // 
            btn_RS232.Location = new Point(15, 15);
            btn_RS232.Margin = new Padding(4);
            btn_RS232.Name = "btn_RS232";
            btn_RS232.Size = new Size(165, 77);
            btn_RS232.TabIndex = 0;
            btn_RS232.Text = "RS232";
            btn_RS232.UseVisualStyleBackColor = true;
            btn_RS232.Click += btn_RS232_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(213, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1237, 866);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RS232);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1229, 834);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // RS232
            // 
            RS232.ClientSize = new Size(1223, 828);
            RS232.Dock = DockStyle.Fill;
            RS232.FormBorderStyle = FormBorderStyle.None;
            RS232.Location = new Point(3, 3);
            RS232.Margin = new Padding(4, 4, 4, 4);
            RS232.Name = "RS232";
            RS232.Text = "RS232";
            RS232.Visible = false;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(757, 469);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 1153);
            Controls.Add(tabControl1);
            Controls.Add(btn_RS232);
            Margin = new Padding(4);
            Name = "Frm_Main";
            Text = "DLL引用表單";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_RS232;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RS232.Frm_Main RS232;
    }
}
