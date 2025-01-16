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
            components = new System.ComponentModel.Container();
            btn_PerspectiveTransform = new Button();
            lbl_Original = new Label();
            lbl_PerspectiveTransform = new Label();
            img_Original = new Emgu.CV.UI.ImageBox();
            img_PerspectiveTransform = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)img_Original).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_PerspectiveTransform).BeginInit();
            SuspendLayout();
            // 
            // btn_PerspectiveTransform
            // 
            btn_PerspectiveTransform.Font = new Font("新細明體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            btn_PerspectiveTransform.Location = new Point(397, 575);
            btn_PerspectiveTransform.Name = "btn_PerspectiveTransform";
            btn_PerspectiveTransform.Size = new Size(213, 93);
            btn_PerspectiveTransform.TabIndex = 1;
            btn_PerspectiveTransform.Text = "透視變換";
            btn_PerspectiveTransform.UseVisualStyleBackColor = true;
            btn_PerspectiveTransform.Click += btn_PerspectiveTransform_Click;
            // 
            // lbl_Original
            // 
            lbl_Original.AutoSize = true;
            lbl_Original.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Original.Location = new Point(232, 19);
            lbl_Original.Name = "lbl_Original";
            lbl_Original.Size = new Size(71, 33);
            lbl_Original.TabIndex = 3;
            lbl_Original.Text = "原圖";
            // 
            // lbl_PerspectiveTransform
            // 
            lbl_PerspectiveTransform.AutoSize = true;
            lbl_PerspectiveTransform.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PerspectiveTransform.Location = new Point(701, 19);
            lbl_PerspectiveTransform.Name = "lbl_PerspectiveTransform";
            lbl_PerspectiveTransform.Size = new Size(127, 33);
            lbl_PerspectiveTransform.TabIndex = 4;
            lbl_PerspectiveTransform.Text = "透視變換";
            // 
            // img_Original
            // 
            img_Original.Location = new Point(11, 60);
            img_Original.Name = "img_Original";
            img_Original.Size = new Size(500, 500);
            img_Original.TabIndex = 2;
            img_Original.TabStop = false;
            // 
            // img_PerspectiveTransform
            // 
            img_PerspectiveTransform.Location = new Point(517, 60);
            img_PerspectiveTransform.Name = "img_PerspectiveTransform";
            img_PerspectiveTransform.Size = new Size(500, 500);
            img_PerspectiveTransform.TabIndex = 5;
            img_PerspectiveTransform.TabStop = false;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 697);
            Controls.Add(img_PerspectiveTransform);
            Controls.Add(img_Original);
            Controls.Add(lbl_PerspectiveTransform);
            Controls.Add(lbl_Original);
            Controls.Add(btn_PerspectiveTransform);
            Name = "Frm_Main";
            Text = "透視變換投影";
            ((System.ComponentModel.ISupportInitialize)img_Original).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_PerspectiveTransform).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_PerspectiveTransform;
        private Label lbl_Original;
        private Label lbl_PerspectiveTransform;
        private Emgu.CV.UI.ImageBox img_Original;
        private Emgu.CV.UI.ImageBox img_PerspectiveTransform;
    }
}
