using System.IO;

namespace DxfReader
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
            dgv_Dxf = new DataGridView();
            PosX = new DataGridViewTextBoxColumn();
            PosY = new DataGridViewTextBoxColumn();
            Diameter = new DataGridViewTextBoxColumn();
            lbl_MousePos = new Label();
            cmb_Filter = new ComboBox();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開啟檔案ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            dXFToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            pic_Dxf = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Dxf).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Dxf).BeginInit();
            SuspendLayout();
            // 
            // dgv_Dxf
            // 
            dgv_Dxf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Dxf.Columns.AddRange(new DataGridViewColumn[] { PosX, PosY, Diameter });
            dgv_Dxf.Location = new Point(12, 166);
            dgv_Dxf.Name = "dgv_Dxf";
            dgv_Dxf.RowHeadersWidth = 82;
            dgv_Dxf.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Dxf.Size = new Size(498, 701);
            dgv_Dxf.TabIndex = 3;
            dgv_Dxf.RowPostPaint += dgv_DxfDatas_RowPostPaint;
            // 
            // PosX
            // 
            PosX.HeaderText = "座標X";
            PosX.MinimumWidth = 10;
            PosX.Name = "PosX";
            PosX.Width = 125;
            // 
            // PosY
            // 
            PosY.HeaderText = "座標Y";
            PosY.MinimumWidth = 10;
            PosY.Name = "PosY";
            PosY.Width = 125;
            // 
            // Diameter
            // 
            Diameter.HeaderText = "直徑";
            Diameter.MinimumWidth = 10;
            Diameter.Name = "Diameter";
            Diameter.Width = 200;
            // 
            // lbl_MousePos
            // 
            lbl_MousePos.AutoSize = true;
            lbl_MousePos.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_MousePos.Location = new Point(526, 870);
            lbl_MousePos.Name = "lbl_MousePos";
            lbl_MousePos.Size = new Size(197, 35);
            lbl_MousePos.TabIndex = 5;
            lbl_MousePos.Text = "當前滑鼠座標 : ";
            // 
            // cmb_Filter
            // 
            cmb_Filter.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmb_Filter.FormattingEnabled = true;
            cmb_Filter.Location = new Point(93, 110);
            cmb_Filter.Name = "cmb_Filter";
            cmb_Filter.Size = new Size(121, 43);
            cmb_Filter.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Thistle;
            menuStrip1.Items.AddRange(new ToolStripItem[] { 檔案ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1584, 43);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開啟檔案ToolStripMenuItem, 儲存檔案ToolStripMenuItem });
            檔案ToolStripMenuItem.Font = new Font("微軟正黑體", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            檔案ToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            檔案ToolStripMenuItem.Size = new Size(81, 39);
            檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            開啟檔案ToolStripMenuItem.Size = new Size(198, 40);
            開啟檔案ToolStripMenuItem.Text = "開啟檔案";
            開啟檔案ToolStripMenuItem.Click += 開啟檔案ToolStripMenuItem_Click;
            // 
            // 儲存檔案ToolStripMenuItem
            // 
            儲存檔案ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dXFToolStripMenuItem, jSONToolStripMenuItem });
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(198, 40);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            // 
            // dXFToolStripMenuItem
            // 
            dXFToolStripMenuItem.Name = "dXFToolStripMenuItem";
            dXFToolStripMenuItem.Size = new Size(161, 40);
            dXFToolStripMenuItem.Text = "DXF";
            // 
            // jSONToolStripMenuItem
            // 
            jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            jSONToolStripMenuItem.Size = new Size(161, 40);
            jSONToolStripMenuItem.Text = "JSON";
            // 
            // pic_Dxf
            // 
            pic_Dxf.BackColor = Color.Honeydew;
            pic_Dxf.BorderStyle = BorderStyle.Fixed3D;
            pic_Dxf.Location = new Point(516, 67);
            pic_Dxf.Name = "pic_Dxf";
            pic_Dxf.Size = new Size(800, 800);
            pic_Dxf.TabIndex = 0;
            pic_Dxf.TabStop = false;
            pic_Dxf.Paint += pic_DxfDatas_Paint;
            pic_Dxf.MouseDown += pic_DxfDatas_MouseDown;
            pic_Dxf.MouseMove += pic_DxfDatas_MouseMove;
            pic_Dxf.MouseWheel += pic_DxfDatas_MouseWheel;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1584, 961);
            Controls.Add(pic_Dxf);
            Controls.Add(cmb_Filter);
            Controls.Add(lbl_MousePos);
            Controls.Add(dgv_Dxf);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Frm_Main";
            Text = "讀取Dxf黨";
            Load += Frm_Main_Load;
            Paint += Frm_Main_Paint;
            ((System.ComponentModel.ISupportInitialize)dgv_Dxf).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Dxf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader col_PointPos1;
        private DataGridView dgv_Dxf;
        private Label lbl_MousePos;
        private DataGridViewTextBoxColumn PosX;
        private DataGridViewTextBoxColumn PosY;
        private DataGridViewTextBoxColumn Diameter;
        private ComboBox cmb_Filter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private ToolStripMenuItem dXFToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private PictureBox pic_Dxf;
    }
}
