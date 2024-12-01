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
            col_CirclePos = new ColumnHeader();
            col_Diameter = new ColumnHeader();
            lv_DXFCircles = new ListView();
            col_CircleNo = new ColumnHeader();
            tc_Entities = new TabControl();
            tp_Circles = new TabPage();
            tp_Points = new TabPage();
            lv_DXFPoints = new ListView();
            col_PointNo = new ColumnHeader();
            col_PointPos = new ColumnHeader();
            tc_Entities.SuspendLayout();
            tp_Circles.SuspendLayout();
            tp_Points.SuspendLayout();
            SuspendLayout();
            // 
            // txt_OpenDXFFile
            // 
            txt_OpenDXFFile.Font = new Font("Microsoft JhengHei UI", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 136);
            txt_OpenDXFFile.Location = new Point(12, 817);
            txt_OpenDXFFile.Name = "txt_OpenDXFFile";
            txt_OpenDXFFile.Size = new Size(1038, 103);
            txt_OpenDXFFile.TabIndex = 0;
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(1262, 820);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(200, 100);
            btn_OK.TabIndex = 1;
            btn_OK.Text = "確定";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // btn_OpenDXFFile
            // 
            btn_OpenDXFFile.Location = new Point(1056, 820);
            btn_OpenDXFFile.Name = "btn_OpenDXFFile";
            btn_OpenDXFFile.Size = new Size(200, 100);
            btn_OpenDXFFile.TabIndex = 2;
            btn_OpenDXFFile.Text = "...";
            btn_OpenDXFFile.UseVisualStyleBackColor = true;
            btn_OpenDXFFile.Click += btn_OpenDXFFile_Click;
            // 
            // col_CirclePos
            // 
            col_CirclePos.Text = "座標";
            col_CirclePos.Width = 500;
            // 
            // col_Diameter
            // 
            col_Diameter.Text = "直徑";
            col_Diameter.Width = 250;
            // 
            // lv_DXFCircles
            // 
            lv_DXFCircles.Columns.AddRange(new ColumnHeader[] { col_CircleNo, col_CirclePos, col_Diameter });
            lv_DXFCircles.FullRowSelect = true;
            lv_DXFCircles.GridLines = true;
            lv_DXFCircles.Location = new Point(0, 0);
            lv_DXFCircles.Name = "lv_DXFCircles";
            lv_DXFCircles.Size = new Size(1442, 747);
            lv_DXFCircles.TabIndex = 3;
            lv_DXFCircles.UseCompatibleStateImageBehavior = false;
            lv_DXFCircles.View = View.Details;
            // 
            // col_CircleNo
            // 
            col_CircleNo.Text = "圓形編號";
            col_CircleNo.Width = 150;
            // 
            // tc_Entities
            // 
            tc_Entities.Controls.Add(tp_Circles);
            tc_Entities.Controls.Add(tp_Points);
            tc_Entities.Location = new Point(12, 12);
            tc_Entities.Name = "tc_Entities";
            tc_Entities.SelectedIndex = 0;
            tc_Entities.Size = new Size(1450, 799);
            tc_Entities.TabIndex = 5;
            // 
            // tp_Circles
            // 
            tp_Circles.Controls.Add(lv_DXFCircles);
            tp_Circles.Location = new Point(8, 44);
            tp_Circles.Name = "tp_Circles";
            tp_Circles.Padding = new Padding(3);
            tp_Circles.Size = new Size(1434, 747);
            tp_Circles.TabIndex = 0;
            tp_Circles.Text = "圓形";
            tp_Circles.UseVisualStyleBackColor = true;
            // 
            // tp_Points
            // 
            tp_Points.Controls.Add(lv_DXFPoints);
            tp_Points.Location = new Point(8, 44);
            tp_Points.Name = "tp_Points";
            tp_Points.Padding = new Padding(3);
            tp_Points.Size = new Size(1434, 747);
            tp_Points.TabIndex = 1;
            tp_Points.Text = "點";
            tp_Points.UseVisualStyleBackColor = true;
            // 
            // lv_DXFPoints
            // 
            lv_DXFPoints.Columns.AddRange(new ColumnHeader[] { col_PointNo, col_PointPos });
            lv_DXFPoints.FullRowSelect = true;
            lv_DXFPoints.GridLines = true;
            lv_DXFPoints.Location = new Point(0, 0);
            lv_DXFPoints.Name = "lv_DXFPoints";
            lv_DXFPoints.Size = new Size(1434, 747);
            lv_DXFPoints.TabIndex = 0;
            lv_DXFPoints.UseCompatibleStateImageBehavior = false;
            lv_DXFPoints.View = View.Details;
            // 
            // col_PointNo
            // 
            col_PointNo.Text = "點編號";
            col_PointNo.Width = 150;
            // 
            // col_PointPos
            // 
            col_PointPos.Text = "座標";
            col_PointPos.Width = 500;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 929);
            Controls.Add(tc_Entities);
            Controls.Add(btn_OpenDXFFile);
            Controls.Add(btn_OK);
            Controls.Add(txt_OpenDXFFile);
            Name = "Frm_Main";
            Text = "讀取Dxf黨";
            tc_Entities.ResumeLayout(false);
            tp_Circles.ResumeLayout(false);
            tp_Points.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_OpenDXFFile;
        private Button btn_OK;
        private Button btn_OpenDXFFile;
        private ColumnHeader col_CirclePos;
        private ColumnHeader col_Diameter;
        private ListView lv_DXFCircles;
        private ColumnHeader col_CircleNo;
        private ComboBox comboBox1;
        private TabControl tc_Entities;
        private TabPage tp_Circles;
        private TabPage tp_Points;
        private ListView lv_DXFPoints;
        private ColumnHeader col_PointNo;
        private ColumnHeader col_PointPos1;
        private ColumnHeader col_PointPos;
    }
}
