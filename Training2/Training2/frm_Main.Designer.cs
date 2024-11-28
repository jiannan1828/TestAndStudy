namespace Training2
{
    partial class frm_Main : Form
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
            btn_add = new Button();
            btn_minus = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            txt_num1 = new TextBox();
            txt_num2 = new TextBox();
            txt_equal = new TextBox();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(64, 125);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(116, 55);
            btn_add.TabIndex = 0;
            btn_add.Text = "加法";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(186, 125);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(116, 55);
            btn_minus.TabIndex = 1;
            btn_minus.Text = "減法";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_minus_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(64, 186);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(116, 55);
            btn_multiply.TabIndex = 2;
            btn_multiply.Text = "乘法";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.Location = new Point(186, 186);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(116, 55);
            btn_divide.TabIndex = 3;
            btn_divide.Text = "除法";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // txt_num1
            // 
            txt_num1.Location = new Point(12, 12);
            txt_num1.Name = "txt_num1";
            txt_num1.Size = new Size(100, 23);
            txt_num1.TabIndex = 4;
            // 
            // txt_num2
            // 
            txt_num2.Location = new Point(118, 12);
            txt_num2.Name = "txt_num2";
            txt_num2.Size = new Size(100, 23);
            txt_num2.TabIndex = 5;
            // 
            // txt_equal
            // 
            txt_equal.Location = new Point(254, 12);
            txt_equal.Name = "txt_equal";
            txt_equal.Size = new Size(100, 23);
            txt_equal.TabIndex = 6;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 326);
            Controls.Add(txt_equal);
            Controls.Add(txt_num2);
            Controls.Add(txt_num1);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_minus);
            Controls.Add(btn_add);
            Name = "frm_Main";
            Text = "計算機";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_minus;
        private Button btn_multiply;
        private Button btn_divide;
        private TextBox txt_num1;
        private TextBox txt_num2;
        private TextBox txt_equal;
    }
}
