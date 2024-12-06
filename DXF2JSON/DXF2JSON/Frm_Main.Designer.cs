﻿using System.IO;

namespace Training7
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
            txt_OpenDXFFile = new TextBox();
            btn_OK = new Button();
            btn_OpenDXFFile = new Button();
            dgv_DXFDatas = new DataGridView();
            Index = new DataGridViewTextBoxColumn();
            PosX = new DataGridViewTextBoxColumn();
            PosY = new DataGridViewTextBoxColumn();
            Diameter = new DataGridViewTextBoxColumn();
            pnl_pic_DXFDatas = new Panel();
            pic_DXFDatas = new PictureBox();
            lbl_MousePos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_DXFDatas).BeginInit();
            pnl_pic_DXFDatas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_DXFDatas).BeginInit();
            SuspendLayout();
            // 
            // txt_OpenDXFFile
            // 
            txt_OpenDXFFile.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_OpenDXFFile.Location = new Point(13, 24);
            txt_OpenDXFFile.Margin = new Padding(4);
            txt_OpenDXFFile.Name = "txt_OpenDXFFile";
            txt_OpenDXFFile.Size = new Size(578, 89);
            txt_OpenDXFFile.TabIndex = 0;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(822, 24);
            btn_OK.Margin = new Padding(4);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(200, 100);
            btn_OK.TabIndex = 1;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_OpenDXFFile
            // 
            btn_OpenDXFFile.Location = new Point(614, 24);
            btn_OpenDXFFile.Margin = new Padding(4);
            btn_OpenDXFFile.Name = "btn_OpenDXFFile";
            btn_OpenDXFFile.Size = new Size(200, 100);
            btn_OpenDXFFile.TabIndex = 2;
            btn_OpenDXFFile.Text = "...";
            btn_OpenDXFFile.UseVisualStyleBackColor = true;
            btn_OpenDXFFile.Click += btn_OpenDXFFile_Click;
            // 
            // dgv_DXFDatas
            // 
            dgv_DXFDatas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DXFDatas.Columns.AddRange(new DataGridViewColumn[] { Index, PosX, PosY, Diameter });
            dgv_DXFDatas.Location = new Point(15, 134);
            dgv_DXFDatas.Margin = new Padding(6);
            dgv_DXFDatas.Name = "dgv_DXFDatas";
            dgv_DXFDatas.RowHeadersWidth = 82;
            dgv_DXFDatas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_DXFDatas.Size = new Size(996, 1513);
            dgv_DXFDatas.TabIndex = 3;
            // 
            // Index
            // 
            Index.HeaderText = "流水號";
            Index.MinimumWidth = 10;
            Index.Name = "Index";
            Index.Width = 75;
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
            // pnl_pic_DXFDatas
            // 
            pnl_pic_DXFDatas.AutoScroll = true;
            pnl_pic_DXFDatas.Controls.Add(pic_DXFDatas);
            pnl_pic_DXFDatas.Location = new Point(1032, 24);
            pnl_pic_DXFDatas.Margin = new Padding(6);
            pnl_pic_DXFDatas.Name = "pnl_pic_DXFDatas";
            pnl_pic_DXFDatas.Size = new Size(1800, 1800);
            pnl_pic_DXFDatas.TabIndex = 4;
            // 
            // pic_DXFDatas
            // 
            pic_DXFDatas.BackColor = Color.Honeydew;
            pic_DXFDatas.Location = new Point(0, 0);
            pic_DXFDatas.Margin = new Padding(6);
            pic_DXFDatas.Name = "pic_DXFDatas";
            pic_DXFDatas.Size = new Size(1800, 1800);
            pic_DXFDatas.TabIndex = 0;
            pic_DXFDatas.TabStop = false;
            pic_DXFDatas.Paint += pic_DXFDatas_Paint;
            pic_DXFDatas.MouseDown += pic_DXFDatas_MouseDown;
            pic_DXFDatas.MouseMove += pic_DXFDatas_MouseMove;
            pic_DXFDatas.MouseWheel += pic_DXFDatas_MouseWheel;
            // 
            // lbl_MousePos
            // 
            lbl_MousePos.AutoSize = true;
            lbl_MousePos.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbl_MousePos.Location = new Point(588, 1543);
            lbl_MousePos.Margin = new Padding(6, 0, 6, 0);
            lbl_MousePos.Name = "lbl_MousePos";
            lbl_MousePos.Size = new Size(393, 68);
            lbl_MousePos.TabIndex = 5;
            lbl_MousePos.Text = "當前滑鼠座標 : ";
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2944, 1799);
            Controls.Add(lbl_MousePos);
            Controls.Add(pnl_pic_DXFDatas);
            Controls.Add(dgv_DXFDatas);
            Controls.Add(btn_OpenDXFFile);
            Controls.Add(btn_OK);
            Controls.Add(txt_OpenDXFFile);
            Margin = new Padding(4);
            Name = "Frm_Main";
            Text = "讀取Dxf黨";
            ((System.ComponentModel.ISupportInitialize)dgv_DXFDatas).EndInit();
            pnl_pic_DXFDatas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_DXFDatas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_OpenDXFFile;
        private Button btn_OK;
        private Button btn_OpenDXFFile;
        private ComboBox comboBox1;
        private ColumnHeader col_PointPos1;
        private DataGridView dgv_DXFDatas;
        private Panel pnl_pic_DXFDatas;
        private PictureBox pic_DXFDatas;
        private DataGridViewTextBoxColumn Index;
        private DataGridViewTextBoxColumn PosX;
        private DataGridViewTextBoxColumn PosY;
        private DataGridViewTextBoxColumn Diameter;
        private Label lbl_MousePos;
    }
}
