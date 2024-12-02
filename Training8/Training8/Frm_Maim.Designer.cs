namespace Training8
{
    partial class Frm_Maim
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
            txt_OpenPythonFilePath = new TextBox();
            btn_PythonPath = new Button();
            btn_OK = new Button();
            SuspendLayout();
            // 
            // txt_OpenPythonFilePath
            // 
            txt_OpenPythonFilePath.Font = new Font("Microsoft JhengHei UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_OpenPythonFilePath.Location = new Point(12, 12);
            txt_OpenPythonFilePath.Name = "txt_OpenPythonFilePath";
            txt_OpenPythonFilePath.Size = new Size(693, 75);
            txt_OpenPythonFilePath.TabIndex = 1;
            // 
            // btn_PythonPath
            // 
            btn_PythonPath.Location = new Point(711, 12);
            btn_PythonPath.Name = "btn_PythonPath";
            btn_PythonPath.Size = new Size(76, 75);
            btn_PythonPath.TabIndex = 2;
            btn_PythonPath.Text = "...";
            btn_PythonPath.UseVisualStyleBackColor = true;
            btn_PythonPath.Click += btn_PythonPath_Click;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(793, 12);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(169, 75);
            btn_OK.TabIndex = 3;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // Frm_Maim
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 98);
            Controls.Add(btn_OK);
            Controls.Add(btn_PythonPath);
            Controls.Add(txt_OpenPythonFilePath);
            Name = "Frm_Maim";
            Text = "Call Python 練習";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_OpenPythonFilePath;
        private Button btn_PythonPath;
        private Button btn_OK;
    }
}
