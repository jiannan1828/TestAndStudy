namespace Training6
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
            panel1 = new Panel();
            pic_Draw = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Draw).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(pic_Draw);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 929);
            panel1.TabIndex = 0;
            // 
            // pic_Draw
            // 
            pic_Draw.Location = new Point(0, 0);
            pic_Draw.Name = "pic_Draw";
            pic_Draw.Size = new Size(2000, 2000);
            pic_Draw.TabIndex = 0;
            pic_Draw.TabStop = false;
            pic_Draw.Paint += pic_Draw_Paint;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 929);
            Controls.Add(panel1);
            Name = "Frm_Main";
            Text = "ScrollBar練習";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Draw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pic_Draw;
    }
}
