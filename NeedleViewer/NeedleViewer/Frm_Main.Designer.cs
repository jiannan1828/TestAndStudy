﻿using System.IO;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_Needles = new DataGridView();
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
            menu_NeedleViewer = new MenuStrip();
            tsmi_File = new ToolStripMenuItem();
            tsmi_OpenFile = new ToolStripMenuItem();
            tsmi_SaveFile = new ToolStripMenuItem();
            pic_Needles = new PictureBox();
            txt_Name = new TextBox();
            label1 = new Label();
            grp_NeedleInfo = new GroupBox();
            rad_Replace = new RadioButton();
            rad_Remove = new RadioButton();
            rad_Place = new RadioButton();
            lbl_Index = new Label();
            txt_Index = new TextBox();
            chk_Enable = new CheckBox();
            chk_Display = new CheckBox();
            txt_Diameter = new TextBox();
            lbl_Diameter = new Label();
            txt_PosX = new TextBox();
            txt_PosY = new TextBox();
            lbl_Pos = new Label();
            txt_Id = new TextBox();
            lbl_Id = new Label();
            grp_Search = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Needles).BeginInit();
            menu_NeedleViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Needles).BeginInit();
            grp_NeedleInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Needles
            // 
            dgv_Needles.AllowUserToAddRows = false;
            dgv_Needles.AllowUserToDeleteRows = false;
            dgv_Needles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("微軟正黑體", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 136);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Needles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Needles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Needles.Columns.AddRange(new DataGridViewColumn[] { Index, ColumnName, Id, PosX, PosY, Diameter, Place, Remove, Replace, Display, Enable, Reserve1, Reserve2, Reserve3, Reserve4, Reserve5 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_Needles.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_Needles.Location = new Point(11, 752);
            dgv_Needles.MultiSelect = false;
            dgv_Needles.Name = "dgv_Needles";
            dgv_Needles.ReadOnly = true;
            dgv_Needles.RowHeadersVisible = false;
            dgv_Needles.RowHeadersWidth = 82;
            dgv_Needles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Needles.Size = new Size(1453, 197);
            dgv_Needles.TabIndex = 3;
            dgv_Needles.CellMouseEnter += dgv_Needles_CellMouseEnter;
            dgv_Needles.CellMouseLeave += dgv_Needles_CellMouseLeave;
            dgv_Needles.SelectionChanged += dgv_Needles_SelectionChanged;
            // 
            // Index
            // 
            dataGridViewCellStyle2.Font = new Font("微軟正黑體", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Index.DefaultCellStyle = dataGridViewCellStyle2;
            Index.HeaderText = "流水號";
            Index.MinimumWidth = 10;
            Index.Name = "Index";
            Index.ReadOnly = true;
            Index.Width = 200;
            // 
            // ColumnName
            // 
            dataGridViewCellStyle3.Font = new Font("微軟正黑體", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnName.HeaderText = "名稱";
            ColumnName.MinimumWidth = 10;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 200;
            // 
            // Id
            // 
            Id.HeaderText = "編號";
            Id.MinimumWidth = 10;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 200;
            // 
            // PosX
            // 
            PosX.HeaderText = "座標X";
            PosX.MinimumWidth = 10;
            PosX.Name = "PosX";
            PosX.ReadOnly = true;
            PosX.Width = 125;
            // 
            // PosY
            // 
            PosY.HeaderText = "座標Y";
            PosY.MinimumWidth = 10;
            PosY.Name = "PosY";
            PosY.ReadOnly = true;
            PosY.Width = 125;
            // 
            // Diameter
            // 
            Diameter.HeaderText = "直徑";
            Diameter.MinimumWidth = 10;
            Diameter.Name = "Diameter";
            Diameter.ReadOnly = true;
            Diameter.Width = 200;
            // 
            // Place
            // 
            Place.HeaderText = "放置";
            Place.MinimumWidth = 10;
            Place.Name = "Place";
            Place.ReadOnly = true;
            Place.Width = 200;
            // 
            // Remove
            // 
            Remove.HeaderText = "移除";
            Remove.MinimumWidth = 10;
            Remove.Name = "Remove";
            Remove.ReadOnly = true;
            Remove.Width = 200;
            // 
            // Replace
            // 
            Replace.HeaderText = "置換";
            Replace.MinimumWidth = 10;
            Replace.Name = "Replace";
            Replace.ReadOnly = true;
            Replace.Width = 200;
            // 
            // Display
            // 
            Display.HeaderText = "顯示";
            Display.MinimumWidth = 10;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Width = 200;
            // 
            // Enable
            // 
            Enable.HeaderText = "啟用";
            Enable.MinimumWidth = 10;
            Enable.Name = "Enable";
            Enable.ReadOnly = true;
            Enable.Width = 200;
            // 
            // Reserve1
            // 
            Reserve1.HeaderText = "保留1";
            Reserve1.MinimumWidth = 10;
            Reserve1.Name = "Reserve1";
            Reserve1.ReadOnly = true;
            Reserve1.Width = 200;
            // 
            // Reserve2
            // 
            Reserve2.HeaderText = "保留2";
            Reserve2.MinimumWidth = 10;
            Reserve2.Name = "Reserve2";
            Reserve2.ReadOnly = true;
            Reserve2.Width = 200;
            // 
            // Reserve3
            // 
            Reserve3.HeaderText = "保留3";
            Reserve3.MinimumWidth = 10;
            Reserve3.Name = "Reserve3";
            Reserve3.ReadOnly = true;
            Reserve3.Width = 200;
            // 
            // Reserve4
            // 
            Reserve4.HeaderText = "保留4";
            Reserve4.MinimumWidth = 10;
            Reserve4.Name = "Reserve4";
            Reserve4.ReadOnly = true;
            Reserve4.Width = 200;
            // 
            // Reserve5
            // 
            Reserve5.HeaderText = "保留5";
            Reserve5.MinimumWidth = 10;
            Reserve5.Name = "Reserve5";
            Reserve5.ReadOnly = true;
            Reserve5.Width = 200;
            // 
            // lbl_MousePos
            // 
            lbl_MousePos.AutoSize = true;
            lbl_MousePos.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_MousePos.Location = new Point(1115, 711);
            lbl_MousePos.Name = "lbl_MousePos";
            lbl_MousePos.Size = new Size(130, 35);
            lbl_MousePos.TabIndex = 5;
            lbl_MousePos.Text = "滑鼠座標 ";
            // 
            // menu_NeedleViewer
            // 
            menu_NeedleViewer.BackColor = Color.Thistle;
            menu_NeedleViewer.ImageScalingSize = new Size(32, 32);
            menu_NeedleViewer.Items.AddRange(new ToolStripItem[] { tsmi_File });
            menu_NeedleViewer.Location = new Point(0, 0);
            menu_NeedleViewer.Name = "menu_NeedleViewer";
            menu_NeedleViewer.Size = new Size(1784, 43);
            menu_NeedleViewer.TabIndex = 7;
            menu_NeedleViewer.Text = "menuStrip1";
            // 
            // tsmi_File
            // 
            tsmi_File.DropDownItems.AddRange(new ToolStripItem[] { tsmi_OpenFile, tsmi_SaveFile });
            tsmi_File.Font = new Font("微軟正黑體", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 136);
            tsmi_File.ForeColor = SystemColors.ControlLightLight;
            tsmi_File.Name = "tsmi_File";
            tsmi_File.Size = new Size(81, 39);
            tsmi_File.Text = "檔案";
            // 
            // tsmi_OpenFile
            // 
            tsmi_OpenFile.Name = "tsmi_OpenFile";
            tsmi_OpenFile.Size = new Size(198, 40);
            tsmi_OpenFile.Text = "開啟檔案";
            tsmi_OpenFile.Click += tsmi_OpenFile_Click;
            // 
            // tsmi_SaveFile
            // 
            tsmi_SaveFile.Name = "tsmi_SaveFile";
            tsmi_SaveFile.Size = new Size(198, 40);
            tsmi_SaveFile.Text = "儲存檔案";
            tsmi_SaveFile.Click += tsmi_SaveFile_Click;
            // 
            // pic_Needles
            // 
            pic_Needles.BackColor = Color.Honeydew;
            pic_Needles.BorderStyle = BorderStyle.Fixed3D;
            pic_Needles.Location = new Point(409, 46);
            pic_Needles.Name = "pic_Needles";
            pic_Needles.Size = new Size(700, 700);
            pic_Needles.TabIndex = 0;
            pic_Needles.TabStop = false;
            pic_Needles.Paint += pic_Needles_Paint;
            pic_Needles.MouseDown += pic_Needles_MouseDown;
            pic_Needles.MouseMove += pic_Needles_MouseMove;
            pic_Needles.MouseWheel += pic_Needles_MouseWheel;
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Name.Location = new Point(74, 80);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(174, 42);
            txt_Name.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 84);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 34);
            label1.TabIndex = 9;
            label1.Text = "名稱";
            // 
            // grp_NeedleInfo
            // 
            grp_NeedleInfo.BackColor = Color.FloralWhite;
            grp_NeedleInfo.Controls.Add(rad_Replace);
            grp_NeedleInfo.Controls.Add(rad_Remove);
            grp_NeedleInfo.Controls.Add(rad_Place);
            grp_NeedleInfo.Controls.Add(lbl_Index);
            grp_NeedleInfo.Controls.Add(txt_Index);
            grp_NeedleInfo.Controls.Add(chk_Enable);
            grp_NeedleInfo.Controls.Add(chk_Display);
            grp_NeedleInfo.Controls.Add(txt_Diameter);
            grp_NeedleInfo.Controls.Add(lbl_Diameter);
            grp_NeedleInfo.Controls.Add(txt_PosX);
            grp_NeedleInfo.Controls.Add(txt_PosY);
            grp_NeedleInfo.Controls.Add(lbl_Pos);
            grp_NeedleInfo.Controls.Add(txt_Id);
            grp_NeedleInfo.Controls.Add(lbl_Id);
            grp_NeedleInfo.Controls.Add(label1);
            grp_NeedleInfo.Controls.Add(txt_Name);
            grp_NeedleInfo.Font = new Font("微軟正黑體", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            grp_NeedleInfo.Location = new Point(11, 46);
            grp_NeedleInfo.Margin = new Padding(2);
            grp_NeedleInfo.Name = "grp_NeedleInfo";
            grp_NeedleInfo.Padding = new Padding(2);
            grp_NeedleInfo.Size = new Size(393, 331);
            grp_NeedleInfo.TabIndex = 10;
            grp_NeedleInfo.TabStop = false;
            grp_NeedleInfo.Text = "植針資訊";
            // 
            // rad_Replace
            // 
            rad_Replace.AutoSize = true;
            rad_Replace.Location = new Point(290, 119);
            rad_Replace.Name = "rad_Replace";
            rad_Replace.Size = new Size(87, 38);
            rad_Replace.TabIndex = 2;
            rad_Replace.TabStop = true;
            rad_Replace.Text = "置換";
            rad_Replace.UseVisualStyleBackColor = true;
            // 
            // rad_Remove
            // 
            rad_Remove.AutoSize = true;
            rad_Remove.Location = new Point(290, 75);
            rad_Remove.Name = "rad_Remove";
            rad_Remove.Size = new Size(87, 38);
            rad_Remove.TabIndex = 1;
            rad_Remove.TabStop = true;
            rad_Remove.Text = "移除";
            rad_Remove.UseVisualStyleBackColor = true;
            // 
            // rad_Place
            // 
            rad_Place.AutoSize = true;
            rad_Place.Location = new Point(290, 31);
            rad_Place.Name = "rad_Place";
            rad_Place.Size = new Size(87, 38);
            rad_Place.TabIndex = 0;
            rad_Place.TabStop = true;
            rad_Place.Text = "放置";
            rad_Place.UseVisualStyleBackColor = true;
            // 
            // lbl_Index
            // 
            lbl_Index.AutoSize = true;
            lbl_Index.Location = new Point(4, 36);
            lbl_Index.Margin = new Padding(2, 0, 2, 0);
            lbl_Index.Name = "lbl_Index";
            lbl_Index.Size = new Size(96, 34);
            lbl_Index.TabIndex = 22;
            lbl_Index.Text = "流水號";
            // 
            // txt_Index
            // 
            txt_Index.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Index.Location = new Point(105, 32);
            txt_Index.Name = "txt_Index";
            txt_Index.ReadOnly = true;
            txt_Index.Size = new Size(143, 42);
            txt_Index.TabIndex = 23;
            // 
            // chk_Enable
            // 
            chk_Enable.Appearance = Appearance.Button;
            chk_Enable.AutoSize = true;
            chk_Enable.Location = new Point(290, 224);
            chk_Enable.Margin = new Padding(2);
            chk_Enable.Name = "chk_Enable";
            chk_Enable.Size = new Size(79, 44);
            chk_Enable.TabIndex = 21;
            chk_Enable.Text = "啟用";
            chk_Enable.UseVisualStyleBackColor = true;
            // 
            // chk_Display
            // 
            chk_Display.Appearance = Appearance.Button;
            chk_Display.AutoSize = true;
            chk_Display.Location = new Point(290, 176);
            chk_Display.Margin = new Padding(2);
            chk_Display.Name = "chk_Display";
            chk_Display.Size = new Size(79, 44);
            chk_Display.TabIndex = 20;
            chk_Display.Text = "顯示";
            chk_Display.UseVisualStyleBackColor = true;
            chk_Display.CheckedChanged += chk_Display_CheckedChanged;
            // 
            // txt_Diameter
            // 
            txt_Diameter.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Diameter.Location = new Point(74, 272);
            txt_Diameter.Name = "txt_Diameter";
            txt_Diameter.ReadOnly = true;
            txt_Diameter.Size = new Size(174, 42);
            txt_Diameter.TabIndex = 16;
            // 
            // lbl_Diameter
            // 
            lbl_Diameter.AutoSize = true;
            lbl_Diameter.Location = new Point(1, 278);
            lbl_Diameter.Margin = new Padding(2, 0, 2, 0);
            lbl_Diameter.Name = "lbl_Diameter";
            lbl_Diameter.Size = new Size(69, 34);
            lbl_Diameter.TabIndex = 15;
            lbl_Diameter.Text = "直徑";
            // 
            // txt_PosX
            // 
            txt_PosX.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_PosX.Location = new Point(74, 176);
            txt_PosX.Name = "txt_PosX";
            txt_PosX.ReadOnly = true;
            txt_PosX.Size = new Size(174, 42);
            txt_PosX.TabIndex = 14;
            // 
            // txt_PosY
            // 
            txt_PosY.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_PosY.Location = new Point(74, 224);
            txt_PosY.Name = "txt_PosY";
            txt_PosY.ReadOnly = true;
            txt_PosY.Size = new Size(174, 42);
            txt_PosY.TabIndex = 13;
            // 
            // lbl_Pos
            // 
            lbl_Pos.AutoSize = true;
            lbl_Pos.Location = new Point(1, 181);
            lbl_Pos.Margin = new Padding(2, 0, 2, 0);
            lbl_Pos.Name = "lbl_Pos";
            lbl_Pos.Size = new Size(69, 34);
            lbl_Pos.TabIndex = 12;
            lbl_Pos.Text = "座標";
            // 
            // txt_Id
            // 
            txt_Id.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_Id.Location = new Point(74, 128);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(174, 42);
            txt_Id.TabIndex = 11;
            // 
            // lbl_Id
            // 
            lbl_Id.AutoSize = true;
            lbl_Id.Location = new Point(4, 133);
            lbl_Id.Margin = new Padding(2, 0, 2, 0);
            lbl_Id.Name = "lbl_Id";
            lbl_Id.Size = new Size(69, 34);
            lbl_Id.TabIndex = 10;
            lbl_Id.Text = "編號";
            // 
            // grp_Search
            // 
            grp_Search.BackColor = Color.FloralWhite;
            grp_Search.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            grp_Search.Location = new Point(12, 382);
            grp_Search.Name = "grp_Search";
            grp_Search.Size = new Size(391, 364);
            grp_Search.TabIndex = 11;
            grp_Search.TabStop = false;
            grp_Search.Text = "搜尋";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1784, 961);
            Controls.Add(grp_Search);
            Controls.Add(grp_NeedleInfo);
            Controls.Add(pic_Needles);
            Controls.Add(lbl_MousePos);
            Controls.Add(dgv_Needles);
            Controls.Add(menu_NeedleViewer);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            MainMenuStrip = menu_NeedleViewer;
            Margin = new Padding(2);
            Name = "Frm_Main";
            Text = "NeedleViewer";
            Load += Frm_Main_Load;
            SizeChanged += Frm_Main_SizeChanged;
            Paint += Frm_Main_Paint;
            ((System.ComponentModel.ISupportInitialize)dgv_Needles).EndInit();
            menu_NeedleViewer.ResumeLayout(false);
            menu_NeedleViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Needles).EndInit();
            grp_NeedleInfo.ResumeLayout(false);
            grp_NeedleInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        public void Initialize_grp_NeedleInfo_ChildControlChanged_Listener(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.TextChanged += grp_NeedleInfo_ChildControlChanged;
                        break;

                    case RadioButton radioButton:
                        radioButton.CheckedChanged += grp_NeedleInfo_ChildControlChanged;
                        break;

                    case CheckBox checkBox:
                        checkBox.CheckedChanged += grp_NeedleInfo_ChildControlChanged;
                        break;

                    default:
                        break;
                }
            }
        }

        #endregion
        private ColumnHeader col_PointPos1;
        private DataGridView dgv_Needles;
        private Label lbl_MousePos;
        private MenuStrip menu_NeedleViewer;
        private ToolStripMenuItem tsmi_File;
        private ToolStripMenuItem tsmi_OpenFile;
        private ToolStripMenuItem tsmi_SaveFile;
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
        private TextBox txt_Index;
        private Label lbl_Index;
        private CheckBox chk_Enable;
        private CheckBox chk_Display;
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
        private GroupBox grp_Search;
        private RadioButton rad_Place;
        private RadioButton rad_Replace;
        private RadioButton rad_Remove;
    }
}
