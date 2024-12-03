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
            pnl_Pic_Draw = new Panel();
            pic_Draw = new PictureBox();
            pnl_Pic_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Draw).BeginInit();
            SuspendLayout();
            // 
            // pnl_Pic_Draw
            // 
            pnl_Pic_Draw.AutoScroll = true;
            pnl_Pic_Draw.Controls.Add(pic_Draw);
            pnl_Pic_Draw.Dock = DockStyle.Fill;
            pnl_Pic_Draw.Location = new Point(0, 0);
            pnl_Pic_Draw.Name = "pnl_Pic_Draw";
            pnl_Pic_Draw.Size = new Size(974, 929);
            pnl_Pic_Draw.TabIndex = 0;
            // 
            // pic_Draw
            // 
            pic_Draw.Location = new Point(0, 0);
            pic_Draw.Name = "pic_Draw";
            pic_Draw.Size = new Size(2000, 2000);
            pic_Draw.TabIndex = 0;
            pic_Draw.TabStop = false;
            pic_Draw.Paint += pic_Draw_Paint;
            pic_Draw.MouseDown += pic_Draw_MouseDown;
            pic_Draw.MouseMove += pic_Draw_MouseMove;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 929);
            Controls.Add(pnl_Pic_Draw);
            Name = "Frm_Main";
            Text = "ScrollBar練習";
            pnl_Pic_Draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Draw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Pic_Draw;
        private PictureBox pic_Draw;
    }
}
