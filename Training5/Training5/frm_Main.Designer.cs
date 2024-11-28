namespace Training5
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
            pic_Draw = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_Draw).BeginInit();
            SuspendLayout();
            // 
            // pic_Draw
            // 
            pic_Draw.BackColor = SystemColors.ControlLightLight;
            pic_Draw.Location = new Point(12, 12);
            pic_Draw.Name = "pic_Draw";
            pic_Draw.Size = new Size(487, 464);
            pic_Draw.TabIndex = 0;
            pic_Draw.TabStop = false;
            pic_Draw.Paint += pic_Draw_Paint;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 488);
            Controls.Add(pic_Draw);
            Name = "frm_Main";
            Text = "畫圖練習";
            ((System.ComponentModel.ISupportInitialize)pic_Draw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_Draw;
    }
}
