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
            ColumnName = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            PosX = new DataGridViewTextBoxColumn();
            PosY = new DataGridViewTextBoxColumn();
            Diameter = new DataGridViewTextBoxColumn();
            Place = new DataGridViewTextBoxColumn();
            Remove = new DataGridViewTextBoxColumn();
            Replace = new DataGridViewTextBoxColumn();
            Display = new DataGridViewTextBoxColumn();
            Enable = new DataGridViewTextBoxColumn();
            Reserve1 = new DataGridViewTextBoxColumn();
            Reserve2 = new DataGridViewTextBoxColumn();
            Reserve3 = new DataGridViewTextBoxColumn();
            Reserve4 = new DataGridViewTextBoxColumn();
            Reserve5 = new DataGridViewTextBoxColumn();
            lbl_MousePos = new Label();
            menuStrip1 = new MenuStrip();
            檔案ToolStripMenuItem = new ToolStripMenuItem();
            開啟檔案ToolStripMenuItem = new ToolStripMenuItem();
            儲存檔案ToolStripMenuItem = new ToolStripMenuItem();
            dXFToolStripMenuItem = new ToolStripMenuItem();
            jSONToolStripMenuItem = new ToolStripMenuItem();
            pic_Dxf = new PictureBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Dxf).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Dxf).BeginInit();
            SuspendLayout();
            // 
            // dgv_Dxf
            // 
            dgv_Dxf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Dxf.Columns.AddRange(new DataGridViewColumn[] { ColumnName, Id, PosX, PosY, Diameter, Place, Remove, Replace, Display, Enable, Reserve1, Reserve2, Reserve3, Reserve4, Reserve5 });
            dgv_Dxf.Location = new Point(12, 94);
            dgv_Dxf.Name = "dgv_Dxf";
            dgv_Dxf.RowHeadersWidth = 82;
            dgv_Dxf.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Dxf.Size = new Size(409, 800);
            dgv_Dxf.TabIndex = 3;
            dgv_Dxf.CellMouseEnter += dgv_Dxf_CellMouseEnter;
            dgv_Dxf.CellMouseLeave += dgv_Dxf_CellMouseLeave;
            dgv_Dxf.RowPostPaint += dgv_DxfDatas_RowPostPaint;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "名稱";
            ColumnName.Name = "ColumnName";
            // 
            // Id
            // 
            Id.HeaderText = "編號";
            Id.Name = "Id";
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
            // Place
            // 
            Place.HeaderText = "放置";
            Place.Name = "Place";
            // 
            // Remove
            // 
            Remove.HeaderText = "移除";
            Remove.Name = "Remove";
            // 
            // Replace
            // 
            Replace.HeaderText = "置換";
            Replace.Name = "Replace";
            // 
            // Display
            // 
            Display.HeaderText = "顯示";
            Display.Name = "Display";
            // 
            // Enable
            // 
            Enable.HeaderText = "啟用";
            Enable.Name = "Enable";
            // 
            // Reserve1
            // 
            Reserve1.HeaderText = "保留1";
            Reserve1.Name = "Reserve1";
            // 
            // Reserve2
            // 
            Reserve2.HeaderText = "保留2";
            Reserve2.Name = "Reserve2";
            // 
            // Reserve3
            // 
            Reserve3.HeaderText = "保留3";
            Reserve3.Name = "Reserve3";
            // 
            // Reserve4
            // 
            Reserve4.HeaderText = "保留4";
            Reserve4.Name = "Reserve4";
            // 
            // Reserve5
            // 
            Reserve5.HeaderText = "保留5";
            Reserve5.Name = "Reserve5";
            // 
            // lbl_MousePos
            // 
            lbl_MousePos.AutoSize = true;
            lbl_MousePos.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_MousePos.Location = new Point(427, 906);
            lbl_MousePos.Name = "lbl_MousePos";
            lbl_MousePos.Size = new Size(197, 35);
            lbl_MousePos.TabIndex = 5;
            lbl_MousePos.Text = "當前滑鼠座標 : ";
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
            pic_Dxf.Location = new Point(427, 94);
            pic_Dxf.Name = "pic_Dxf";
            pic_Dxf.Size = new Size(800, 800);
            pic_Dxf.TabIndex = 0;
            pic_Dxf.TabStop = false;
            pic_Dxf.Paint += pic_DxfDatas_Paint;
            pic_Dxf.MouseDown += pic_DxfDatas_MouseDown;
            pic_Dxf.MouseMove += pic_DxfDatas_MouseMove;
            pic_Dxf.MouseWheel += pic_DxfDatas_MouseWheel;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(12, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 42);
            textBox1.TabIndex = 8;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1584, 961);
            Controls.Add(textBox1);
            Controls.Add(pic_Dxf);
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private ToolStripMenuItem dXFToolStripMenuItem;
        private ToolStripMenuItem jSONToolStripMenuItem;
        private PictureBox pic_Dxf;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn PosX;
        private DataGridViewTextBoxColumn PosY;
        private DataGridViewTextBoxColumn Diameter;
        private DataGridViewTextBoxColumn Place;
        private DataGridViewTextBoxColumn Remove;
        private DataGridViewTextBoxColumn Replace;
        private DataGridViewTextBoxColumn Display;
        private DataGridViewTextBoxColumn Enable;
        private DataGridViewTextBoxColumn Reserve1;
        private DataGridViewTextBoxColumn Reserve2;
        private DataGridViewTextBoxColumn Reserve3;
        private DataGridViewTextBoxColumn Reserve4;
        private DataGridViewTextBoxColumn Reserve5;
        private TextBox textBox1;
    }
}
