namespace 新人練習一
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
            btn_changeText = new Button();
            btn_changeLabelText = new Button();
            cmb_Select = new ComboBox();
            lbl_changeLabelText = new Label();
            SuspendLayout();
            // 
            // btn_changeText
            // 
            btn_changeText.Location = new Point(31, 33);
            btn_changeText.Name = "btn_changeText";
            btn_changeText.Size = new Size(165, 75);
            btn_changeText.TabIndex = 0;
            btn_changeText.Text = "0";
            btn_changeText.UseVisualStyleBackColor = true;
            btn_changeText.Click += btn_changeText_Click;
            // 
            // btn_changeLabelText
            // 
            btn_changeLabelText.Location = new Point(217, 33);
            btn_changeLabelText.Name = "btn_changeLabelText";
            btn_changeLabelText.Size = new Size(165, 75);
            btn_changeLabelText.TabIndex = 1;
            btn_changeLabelText.Text = "ChangeLabel";
            btn_changeLabelText.UseVisualStyleBackColor = true;
            btn_changeLabelText.Click += btn_changeLabelText_Click;
            // 
            // cmb_Select
            // 
            cmb_Select.FormattingEnabled = true;
            cmb_Select.Location = new Point(403, 33);
            cmb_Select.Name = "cmb_Select";
            cmb_Select.Size = new Size(138, 23);
            cmb_Select.TabIndex = 2;
            // 
            // lbl_changeLabelText
            // 
            lbl_changeLabelText.AutoSize = true;
            lbl_changeLabelText.Location = new Point(217, 131);
            lbl_changeLabelText.Name = "lbl_changeLabelText";
            lbl_changeLabelText.Size = new Size(14, 15);
            lbl_changeLabelText.TabIndex = 3;
            lbl_changeLabelText.Text = "0";
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_changeLabelText);
            Controls.Add(cmb_Select);
            Controls.Add(btn_changeLabelText);
            Controls.Add(btn_changeText);
            Name = "frm_Main";
            Text = "新人訓練一";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_changeText;
        private Button btn_changeLabelText;
        private ComboBox cmb_Select;
        private Label lbl_changeLabelText;
    }
}
