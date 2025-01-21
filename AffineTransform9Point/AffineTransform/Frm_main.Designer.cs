namespace AffineTransform
{
    partial class Frm_main
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
            btn_Transform = new Button();
            txt_TestPointX = new TextBox();
            txt_TestPointY = new TextBox();
            txt_ResultPointX = new TextBox();
            txt_ResultPointY = new TextBox();
            SuspendLayout();
            // 
            // btn_Transform
            // 
            btn_Transform.Font = new Font("新細明體", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_Transform.Location = new Point(88, 133);
            btn_Transform.Name = "btn_Transform";
            btn_Transform.Size = new Size(163, 80);
            btn_Transform.TabIndex = 0;
            btn_Transform.Text = "轉換";
            btn_Transform.UseVisualStyleBackColor = true;
            btn_Transform.Click += btn_Transform_Click;
            // 
            // txt_TestPointX
            // 
            txt_TestPointX.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TestPointX.Location = new Point(45, 70);
            txt_TestPointX.Name = "txt_TestPointX";
            txt_TestPointX.Size = new Size(125, 39);
            txt_TestPointX.TabIndex = 1;
            // 
            // txt_TestPointY
            // 
            txt_TestPointY.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_TestPointY.Location = new Point(198, 70);
            txt_TestPointY.Name = "txt_TestPointY";
            txt_TestPointY.Size = new Size(125, 39);
            txt_TestPointY.TabIndex = 2;
            // 
            // txt_ResultPointX
            // 
            txt_ResultPointX.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ResultPointX.Location = new Point(45, 239);
            txt_ResultPointX.Name = "txt_ResultPointX";
            txt_ResultPointX.ReadOnly = true;
            txt_ResultPointX.Size = new Size(125, 39);
            txt_ResultPointX.TabIndex = 3;
            // 
            // txt_ResultPointY
            // 
            txt_ResultPointY.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ResultPointY.Location = new Point(198, 239);
            txt_ResultPointY.Name = "txt_ResultPointY";
            txt_ResultPointY.ReadOnly = true;
            txt_ResultPointY.Size = new Size(125, 39);
            txt_ResultPointY.TabIndex = 4;
            // 
            // Frm_main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 355);
            Controls.Add(txt_ResultPointY);
            Controls.Add(txt_ResultPointX);
            Controls.Add(txt_TestPointY);
            Controls.Add(txt_TestPointX);
            Controls.Add(btn_Transform);
            Name = "Frm_main";
            Text = "Affine轉換";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Transform;
        private TextBox txt_TestPointX;
        private TextBox txt_TestPointY;
        private TextBox txt_ResultPointX;
        private TextBox txt_ResultPointY;
    }
}
