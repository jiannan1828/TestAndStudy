using System.IO;

namespace NeedleViewer
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
            dgv_NeedleInfo = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
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
            pic_Needles = new PictureBox();
            txt_Name = new TextBox();
            label1 = new Label();
            grp_NeedleInfo = new GroupBox();
            btn_Update = new Button();
            txt_Index = new TextBox();
            lbl_Index = new Label();
            chk_Enable = new CheckBox();
            chk_Display = new CheckBox();
            chk_Replace = new CheckBox();
            chk_Remove = new CheckBox();
            chk_Place = new CheckBox();
            txt_Diameter = new TextBox();
            lbl_Diameter = new Label();
            txt_PosX = new TextBox();
            txt_PosY = new TextBox();
            lbl_Pos = new Label();
            txt_Id = new TextBox();
            lbl_Id = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_NeedleInfo).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Needles).BeginInit();
            grp_NeedleInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_NeedleInfo
            // 
            dgv_NeedleInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_NeedleInfo.Columns.AddRange(new DataGridViewColumn[] { Index, ColumnName, Id, PosX, PosY, Diameter, Place, Remove, Replace, Display, Enable, Reserve1, Reserve2, Reserve3, Reserve4, Reserve5 });
            dgv_NeedleInfo.Location = new Point(12, 352);
            dgv_NeedleInfo.Name = "dgv_NeedleInfo";
            dgv_NeedleInfo.RowHeadersVisible = false;
            dgv_NeedleInfo.RowHeadersWidth = 82;
            dgv_NeedleInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_NeedleInfo.Size = new Size(409, 504);
            dgv_NeedleInfo.TabIndex = 3;
            dgv_NeedleInfo.CellMouseEnter += dgv_Dxf_CellMouseEnter;
            dgv_NeedleInfo.CellMouseLeave += dgv_Dxf_CellMouseLeave;
            // 
            // Index
            // 
            Index.HeaderText = "流水號";
            Index.MinimumWidth = 10;
            Index.Name = "Index";
            Index.Width = 200;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "名稱";
            ColumnName.MinimumWidth = 10;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 200;
            // 
            // Id
            // 
            Id.HeaderText = "編號";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.Width = 200;
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
            Place.MinimumWidth = 10;
            Place.Name = "Place";
            Place.Width = 200;
            // 
            // Remove
            // 
            Remove.HeaderText = "移除";
            Remove.MinimumWidth = 10;
            Remove.Name = "Remove";
            Remove.Width = 200;
            // 
            // Replace
            // 
            Replace.HeaderText = "置換";
            Replace.MinimumWidth = 10;
            Replace.Name = "Replace";
            Replace.Width = 200;
            // 
            // Display
            // 
            Display.HeaderText = "顯示";
            Display.MinimumWidth = 10;
            Display.Name = "Display";
            Display.Width = 200;
            // 
            // Enable
            // 
            Enable.HeaderText = "啟用";
            Enable.MinimumWidth = 10;
            Enable.Name = "Enable";
            Enable.Width = 200;
            // 
            // Reserve1
            // 
            Reserve1.HeaderText = "保留1";
            Reserve1.MinimumWidth = 10;
            Reserve1.Name = "Reserve1";
            Reserve1.Width = 200;
            // 
            // Reserve2
            // 
            Reserve2.HeaderText = "保留2";
            Reserve2.MinimumWidth = 10;
            Reserve2.Name = "Reserve2";
            Reserve2.Width = 200;
            // 
            // Reserve3
            // 
            Reserve3.HeaderText = "保留3";
            Reserve3.MinimumWidth = 10;
            Reserve3.Name = "Reserve3";
            Reserve3.Width = 200;
            // 
            // Reserve4
            // 
            Reserve4.HeaderText = "保留4";
            Reserve4.MinimumWidth = 10;
            Reserve4.Name = "Reserve4";
            Reserve4.Width = 200;
            // 
            // Reserve5
            // 
            Reserve5.HeaderText = "保留5";
            Reserve5.MinimumWidth = 10;
            Reserve5.Name = "Reserve5";
            Reserve5.Width = 200;
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
            menuStrip1.ImageScalingSize = new Size(32, 32);
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
            儲存檔案ToolStripMenuItem.Name = "儲存檔案ToolStripMenuItem";
            儲存檔案ToolStripMenuItem.Size = new Size(198, 40);
            儲存檔案ToolStripMenuItem.Text = "儲存檔案";
            儲存檔案ToolStripMenuItem.Click += 儲存檔案ToolStripMenuItem_Click;
            // 
            // pic_Needles
            // 
            pic_Needles.BackColor = Color.Honeydew;
            pic_Needles.BorderStyle = BorderStyle.Fixed3D;
            pic_Needles.Location = new Point(427, 58);
            pic_Needles.Name = "pic_Needles";
            pic_Needles.Size = new Size(800, 800);
            pic_Needles.TabIndex = 0;
            pic_Needles.TabStop = false;
            pic_Needles.Paint += pic_DxfDatas_Paint;
            pic_Needles.MouseDown += pic_DxfDatas_MouseDown;
            pic_Needles.MouseMove += pic_DxfDatas_MouseMove;
            pic_Needles.MouseWheel += pic_DxfDatas_MouseWheel;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Name.Location = new Point(74, 76);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(85, 42);
            txt_Name.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 82);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 9;
            label1.Text = "名稱";
            // 
            // grp_NeedleInfo
            // 
            grp_NeedleInfo.BackColor = Color.FloralWhite;
            grp_NeedleInfo.Controls.Add(btn_Update);
            grp_NeedleInfo.Controls.Add(txt_Index);
            grp_NeedleInfo.Controls.Add(lbl_Index);
            grp_NeedleInfo.Controls.Add(chk_Enable);
            grp_NeedleInfo.Controls.Add(chk_Display);
            grp_NeedleInfo.Controls.Add(chk_Replace);
            grp_NeedleInfo.Controls.Add(chk_Remove);
            grp_NeedleInfo.Controls.Add(chk_Place);
            grp_NeedleInfo.Controls.Add(txt_Diameter);
            grp_NeedleInfo.Controls.Add(lbl_Diameter);
            grp_NeedleInfo.Controls.Add(txt_PosX);
            grp_NeedleInfo.Controls.Add(txt_PosY);
            grp_NeedleInfo.Controls.Add(lbl_Pos);
            grp_NeedleInfo.Controls.Add(txt_Id);
            grp_NeedleInfo.Controls.Add(lbl_Id);
            grp_NeedleInfo.Controls.Add(label1);
            grp_NeedleInfo.Controls.Add(txt_Name);
            grp_NeedleInfo.Font = new Font("微軟正黑體", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 136);
            grp_NeedleInfo.Location = new Point(12, 51);
            grp_NeedleInfo.Margin = new Padding(2);
            grp_NeedleInfo.Name = "grp_NeedleInfo";
            grp_NeedleInfo.Padding = new Padding(2);
            grp_NeedleInfo.Size = new Size(393, 285);
            grp_NeedleInfo.TabIndex = 10;
            grp_NeedleInfo.TabStop = false;
            grp_NeedleInfo.Text = "植針資訊";
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.LightCoral;
            btn_Update.Enabled = false;
            btn_Update.Location = new Point(246, 222);
            btn_Update.Margin = new Padding(2);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(105, 50);
            btn_Update.TabIndex = 24;
            btn_Update.Text = "更新";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // txt_Index
            // 
            txt_Index.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Index.Location = new Point(96, 32);
            txt_Index.Name = "txt_Index";
            txt_Index.ReadOnly = true;
            txt_Index.Size = new Size(85, 42);
            txt_Index.TabIndex = 23;
            // 
            // lbl_Index
            // 
            lbl_Index.AutoSize = true;
            lbl_Index.Location = new Point(15, 38);
            lbl_Index.Margin = new Padding(2, 0, 2, 0);
            lbl_Index.Name = "lbl_Index";
            lbl_Index.Size = new Size(78, 28);
            lbl_Index.TabIndex = 22;
            lbl_Index.Text = "流水號";
            // 
            // chk_Enable
            // 
            chk_Enable.Appearance = Appearance.Button;
            chk_Enable.AutoSize = true;
            chk_Enable.Location = new Point(271, 183);
            chk_Enable.Margin = new Padding(2);
            chk_Enable.Name = "chk_Enable";
            chk_Enable.Size = new Size(66, 38);
            chk_Enable.TabIndex = 21;
            chk_Enable.Text = "啟用";
            chk_Enable.UseVisualStyleBackColor = true;
            // 
            // chk_Display
            // 
            chk_Display.Appearance = Appearance.Button;
            chk_Display.AutoSize = true;
            chk_Display.Location = new Point(271, 146);
            chk_Display.Margin = new Padding(2);
            chk_Display.Name = "chk_Display";
            chk_Display.Size = new Size(66, 38);
            chk_Display.TabIndex = 20;
            chk_Display.Text = "顯示";
            chk_Display.UseVisualStyleBackColor = true;
            // 
            // chk_Replace
            // 
            chk_Replace.Appearance = Appearance.Button;
            chk_Replace.AutoSize = true;
            chk_Replace.Location = new Point(271, 108);
            chk_Replace.Margin = new Padding(2);
            chk_Replace.Name = "chk_Replace";
            chk_Replace.Size = new Size(66, 38);
            chk_Replace.TabIndex = 19;
            chk_Replace.Text = "置換";
            chk_Replace.UseVisualStyleBackColor = true;
            // 
            // chk_Remove
            // 
            chk_Remove.Appearance = Appearance.Button;
            chk_Remove.AutoSize = true;
            chk_Remove.Location = new Point(271, 71);
            chk_Remove.Margin = new Padding(2);
            chk_Remove.Name = "chk_Remove";
            chk_Remove.Size = new Size(66, 38);
            chk_Remove.TabIndex = 18;
            chk_Remove.Text = "移除";
            chk_Remove.UseVisualStyleBackColor = true;
            // 
            // chk_Place
            // 
            chk_Place.Appearance = Appearance.Button;
            chk_Place.AutoSize = true;
            chk_Place.Location = new Point(271, 32);
            chk_Place.Margin = new Padding(2);
            chk_Place.Name = "chk_Place";
            chk_Place.Size = new Size(66, 38);
            chk_Place.TabIndex = 17;
            chk_Place.Text = "放置";
            chk_Place.UseVisualStyleBackColor = true;
            // 
            // txt_Diameter
            // 
            txt_Diameter.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Diameter.Location = new Point(74, 208);
            txt_Diameter.Name = "txt_Diameter";
            txt_Diameter.ReadOnly = true;
            txt_Diameter.Size = new Size(85, 42);
            txt_Diameter.TabIndex = 16;
            // 
            // lbl_Diameter
            // 
            lbl_Diameter.AutoSize = true;
            lbl_Diameter.Location = new Point(15, 214);
            lbl_Diameter.Margin = new Padding(2, 0, 2, 0);
            lbl_Diameter.Name = "lbl_Diameter";
            lbl_Diameter.Size = new Size(56, 28);
            lbl_Diameter.TabIndex = 15;
            lbl_Diameter.Text = "直徑";
            // 
            // txt_PosX
            // 
            txt_PosX.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_PosX.Location = new Point(74, 164);
            txt_PosX.Name = "txt_PosX";
            txt_PosX.ReadOnly = true;
            txt_PosX.Size = new Size(85, 42);
            txt_PosX.TabIndex = 14;
            // 
            // txt_PosY
            // 
            txt_PosY.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_PosY.Location = new Point(163, 164);
            txt_PosY.Name = "txt_PosY";
            txt_PosY.ReadOnly = true;
            txt_PosY.Size = new Size(85, 42);
            txt_PosY.TabIndex = 13;
            // 
            // lbl_Pos
            // 
            lbl_Pos.AutoSize = true;
            lbl_Pos.Location = new Point(15, 170);
            lbl_Pos.Margin = new Padding(2, 0, 2, 0);
            lbl_Pos.Name = "lbl_Pos";
            lbl_Pos.Size = new Size(56, 28);
            lbl_Pos.TabIndex = 12;
            lbl_Pos.Text = "座標";
            // 
            // txt_Id
            // 
            txt_Id.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Id.Location = new Point(74, 120);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(85, 42);
            txt_Id.TabIndex = 11;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Location = new Point(15, 126);
            lbl_Id.Margin = new Padding(2, 0, 2, 0);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(56, 28);
            lbl_Id.TabIndex = 10;
            lbl_Id.Text = "編號";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1584, 961);
            Controls.Add(grp_NeedleInfo);
            Controls.Add(pic_Needles);
            Controls.Add(lbl_MousePos);
            Controls.Add(dgv_NeedleInfo);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Frm_Main";
            Text = "NeedleViewer";
            Load += Frm_Main_Load;
            Paint += Frm_Main_Paint;
            ((System.ComponentModel.ISupportInitialize)dgv_NeedleInfo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Needles).EndInit();
            grp_NeedleInfo.ResumeLayout(false);
            grp_NeedleInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColumnHeader col_PointPos1;
        private DataGridView dgv_NeedleInfo;
        private Label lbl_MousePos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 檔案ToolStripMenuItem;
        private ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private ToolStripMenuItem 儲存檔案ToolStripMenuItem;
        private PictureBox pic_Needles;
        private TextBox txt_Name;
        private Label label1;
        private GroupBox grp_NeedleInfo;
        private TextBox txt_Id;
        private Label lbl_Id;
        private Label lbl_Pos;
        private TextBox txt_Diameter;
        private Label lbl_Diameter;
        private TextBox txt_PosX;
        private TextBox txt_PosY;
        private CheckBox chk_Replace;
        private CheckBox chk_Remove;
        private CheckBox chk_Place;
        private TextBox txt_Index;
        private Label lbl_Index;
        private CheckBox chk_Enable;
        private CheckBox chk_Display;
        private Button btn_Update;
        private DataGridViewTextBoxColumn Index;
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
    }
}
