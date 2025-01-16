namespace PerspectiveTransform
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
            btn_PerspectiveTransform = new Button();
            lbl_Original = new Label();
            lbl_PerspectiveTransform = new Label();
            pic_Original = new PictureBox();
            pic_PerspectiveTransform = new PictureBox();
            lbl_H = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_Original).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_PerspectiveTransform).BeginInit();
            SuspendLayout();
            // 
            // btn_PerspectiveTransform
            // 
            btn_PerspectiveTransform.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_PerspectiveTransform.Location = new Point(144, 469);
            btn_PerspectiveTransform.Margin = new Padding(2);
            btn_PerspectiveTransform.Name = "btn_PerspectiveTransform";
            btn_PerspectiveTransform.Size = new Size(166, 73);
            btn_PerspectiveTransform.TabIndex = 1;
            btn_PerspectiveTransform.Text = "透視變換";
            btn_PerspectiveTransform.UseVisualStyleBackColor = true;
            btn_PerspectiveTransform.Click += btn_PerspectiveTransform_Click;
            // 
            // lbl_Original
            // 
            lbl_Original.AutoSize = true;
            lbl_Original.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Original.Location = new Point(180, 15);
            lbl_Original.Margin = new Padding(2, 0, 2, 0);
            lbl_Original.Name = "lbl_Original";
            lbl_Original.Size = new Size(56, 25);
            lbl_Original.TabIndex = 3;
            lbl_Original.Text = "原圖";
            // 
            // lbl_PerspectiveTransform
            // 
            lbl_PerspectiveTransform.AutoSize = true;
            lbl_PerspectiveTransform.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PerspectiveTransform.Location = new Point(545, 15);
            lbl_PerspectiveTransform.Margin = new Padding(2, 0, 2, 0);
            lbl_PerspectiveTransform.Name = "lbl_PerspectiveTransform";
            lbl_PerspectiveTransform.Size = new Size(100, 25);
            lbl_PerspectiveTransform.TabIndex = 4;
            lbl_PerspectiveTransform.Text = "透視變換";
            // 
            // pic_Original
            // 
            pic_Original.Location = new Point(9, 43);
            pic_Original.Margin = new Padding(2);
            pic_Original.Name = "pic_Original";
            pic_Original.Size = new Size(389, 395);
            pic_Original.TabIndex = 5;
            pic_Original.TabStop = false;
            // 
            // pic_PerspectiveTransform
            // 
            pic_PerspectiveTransform.Location = new Point(403, 43);
            pic_PerspectiveTransform.Margin = new Padding(2);
            pic_PerspectiveTransform.Name = "pic_PerspectiveTransform";
            pic_PerspectiveTransform.Size = new Size(389, 395);
            pic_PerspectiveTransform.TabIndex = 6;
            pic_PerspectiveTransform.TabStop = false;
            // 
            // lbl_H
            // 
            lbl_H.AutoSize = true;
            lbl_H.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_H.Location = new Point(433, 469);
            lbl_H.Name = "lbl_H";
            lbl_H.Size = new Size(61, 23);
            lbl_H.TabIndex = 7;
            lbl_H.Text = "label1";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 636);
            Controls.Add(lbl_H);
            Controls.Add(pic_PerspectiveTransform);
            Controls.Add(pic_Original);
            Controls.Add(lbl_PerspectiveTransform);
            Controls.Add(lbl_Original);
            Controls.Add(btn_PerspectiveTransform);
            Margin = new Padding(2);
            Name = "Frm_Main";
            Text = "透視變換投影";
            ((System.ComponentModel.ISupportInitialize)pic_Original).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_PerspectiveTransform).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_PerspectiveTransform;
        private Label lbl_Original;
        private Label lbl_PerspectiveTransform;
        private PictureBox pic_Original;
        private PictureBox pic_PerspectiveTransform;
        private Label lbl_H;
    }
}
