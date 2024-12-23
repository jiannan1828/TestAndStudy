namespace CS2PYImage
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
            img_Camera = new Emgu.CV.UI.ImageBox();
            btn_Capture = new Button();
            btn_CS2PYImage = new Button();
            btn_CS2PYJson = new Button();
            ((System.ComponentModel.ISupportInitialize)img_Camera).BeginInit();
            SuspendLayout();
            // 
            // img_Camera
            // 
            img_Camera.Location = new Point(12, 12);
            img_Camera.Name = "img_Camera";
            img_Camera.Size = new Size(773, 577);
            img_Camera.SizeMode = PictureBoxSizeMode.Zoom;
            img_Camera.TabIndex = 2;
            img_Camera.TabStop = false;
            // 
            // btn_Capture
            // 
            btn_Capture.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Capture.Location = new Point(12, 595);
            btn_Capture.Name = "btn_Capture";
            btn_Capture.Size = new Size(165, 92);
            btn_Capture.TabIndex = 3;
            btn_Capture.Text = "拍照";
            btn_Capture.UseVisualStyleBackColor = true;
            btn_Capture.Click += btn_Capture_Click;
            // 
            // btn_CS2PYImage
            // 
            btn_CS2PYImage.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CS2PYImage.Location = new Point(183, 596);
            btn_CS2PYImage.Name = "btn_CS2PYImage";
            btn_CS2PYImage.Size = new Size(276, 92);
            btn_CS2PYImage.TabIndex = 4;
            btn_CS2PYImage.Text = "傳送影像";
            btn_CS2PYImage.UseVisualStyleBackColor = true;
            btn_CS2PYImage.Click += btn_CS2PYImage_Click;
            // 
            // btn_CS2PYJson
            // 
            btn_CS2PYJson.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CS2PYJson.Location = new Point(465, 596);
            btn_CS2PYJson.Name = "btn_CS2PYJson";
            btn_CS2PYJson.Size = new Size(276, 92);
            btn_CS2PYJson.TabIndex = 5;
            btn_CS2PYJson.Text = "傳送Json";
            btn_CS2PYJson.UseVisualStyleBackColor = true;
            btn_CS2PYJson.Click += btn_CS2PYJson_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 700);
            Controls.Add(btn_CS2PYJson);
            Controls.Add(btn_CS2PYImage);
            Controls.Add(btn_Capture);
            Controls.Add(img_Camera);
            Name = "Frm_Main";
            Text = "CSharp Python Image";
            FormClosing += Frm_Main_FormClosing;
            Load += Frm_Main_Load;
            ((System.ComponentModel.ISupportInitialize)img_Camera).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox img_Camera;
        private Button btn_Capture;
        private Button btn_CS2PYImage;
        private Button btn_CS2PYJson;
    }
}
