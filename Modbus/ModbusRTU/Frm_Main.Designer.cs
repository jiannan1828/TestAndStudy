using System.Windows.Forms;
using System.Xml.Linq;

namespace ModbusRTU
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
            lbl_SlaveAdress = new Label();
            txt_SlaveAddress = new TextBox();
            lbl_ReadAddress = new Label();
            txt_ReadAddress = new TextBox();
            lbl_NumberOfPoint = new Label();
            txt_NumberOfPoint = new TextBox();
            cmb_ReadType = new ComboBox();
            lbl_ReadType = new Label();
            dgv_Read = new DataGridView();
            Address = new DataGridViewTextBoxColumn();
            Value = new DataGridViewTextBoxColumn();
            grp_Read = new GroupBox();
            btn_Read = new Button();
            grp_Write = new GroupBox();
            btn_Write = new Button();
            txt_WriteAddress = new TextBox();
            lbl_WriteType = new Label();
            lbl_WriteAddress = new Label();
            cmb_WriteType = new ComboBox();
            txt_WriteValue = new TextBox();
            lbl_WriteValue = new Label();
            cmb_Port = new ComboBox();
            btn_Connect = new Button();
            btn_Disconnect = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Read).BeginInit();
            grp_Read.SuspendLayout();
            grp_Write.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_SlaveAdress
            // 
            lbl_SlaveAdress.AutoSize = true;
            lbl_SlaveAdress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SlaveAdress.Location = new Point(21, 129);
            lbl_SlaveAdress.Name = "lbl_SlaveAdress";
            lbl_SlaveAdress.Size = new Size(135, 33);
            lbl_SlaveAdress.TabIndex = 0;
            lbl_SlaveAdress.Text = "從機地址";
            // 
            // txt_SlaveAddress
            // 
            txt_SlaveAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SlaveAddress.Location = new Point(162, 132);
            txt_SlaveAddress.Name = "txt_SlaveAddress";
            txt_SlaveAddress.Size = new Size(176, 39);
            txt_SlaveAddress.TabIndex = 1;
            // 
            // lbl_ReadAddress
            // 
            lbl_ReadAddress.AutoSize = true;
            lbl_ReadAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ReadAddress.Location = new Point(18, 89);
            lbl_ReadAddress.Name = "lbl_ReadAddress";
            lbl_ReadAddress.Size = new Size(135, 33);
            lbl_ReadAddress.TabIndex = 2;
            lbl_ReadAddress.Text = "讀取位置";
            // 
            // txt_ReadAddress
            // 
            txt_ReadAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ReadAddress.Location = new Point(159, 86);
            txt_ReadAddress.Name = "txt_ReadAddress";
            txt_ReadAddress.Size = new Size(176, 39);
            txt_ReadAddress.TabIndex = 3;
            // 
            // lbl_NumberOfPoint
            // 
            lbl_NumberOfPoint.AutoSize = true;
            lbl_NumberOfPoint.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NumberOfPoint.Location = new Point(18, 134);
            lbl_NumberOfPoint.Name = "lbl_NumberOfPoint";
            lbl_NumberOfPoint.Size = new Size(135, 33);
            lbl_NumberOfPoint.TabIndex = 4;
            lbl_NumberOfPoint.Text = "讀取個數";
            // 
            // txt_NumberOfPoint
            // 
            txt_NumberOfPoint.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_NumberOfPoint.Location = new Point(159, 131);
            txt_NumberOfPoint.Name = "txt_NumberOfPoint";
            txt_NumberOfPoint.Size = new Size(176, 39);
            txt_NumberOfPoint.TabIndex = 5;
            // 
            // cmb_ReadType
            // 
            cmb_ReadType.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_ReadType.FormattingEnabled = true;
            cmb_ReadType.Items.AddRange(new object[] { "線圈", "離散輸入", "保持暫存器", "輸入暫存器" });
            cmb_ReadType.Location = new Point(159, 40);
            cmb_ReadType.Name = "cmb_ReadType";
            cmb_ReadType.Size = new Size(176, 40);
            cmb_ReadType.TabIndex = 6;
            // 
            // lbl_ReadType
            // 
            lbl_ReadType.AutoSize = true;
            lbl_ReadType.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ReadType.Location = new Point(18, 43);
            lbl_ReadType.Name = "lbl_ReadType";
            lbl_ReadType.Size = new Size(75, 33);
            lbl_ReadType.TabIndex = 7;
            lbl_ReadType.Text = "類型";
            // 
            // dgv_Read
            // 
            dgv_Read.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Read.Columns.AddRange(new DataGridViewColumn[] { Address, Value });
            dgv_Read.Location = new Point(372, 195);
            dgv_Read.Name = "dgv_Read";
            dgv_Read.RowHeadersWidth = 51;
            dgv_Read.Size = new Size(303, 459);
            dgv_Read.TabIndex = 8;
            // 
            // Address
            // 
            Address.HeaderText = "地址";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Value
            // 
            Value.HeaderText = "值";
            Value.MinimumWidth = 6;
            Value.Name = "Value";
            Value.Width = 125;
            // 
            // grp_Read
            // 
            grp_Read.Controls.Add(btn_Read);
            grp_Read.Controls.Add(txt_ReadAddress);
            grp_Read.Controls.Add(lbl_ReadType);
            grp_Read.Controls.Add(lbl_ReadAddress);
            grp_Read.Controls.Add(cmb_ReadType);
            grp_Read.Controls.Add(txt_NumberOfPoint);
            grp_Read.Controls.Add(lbl_NumberOfPoint);
            grp_Read.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_Read.Location = new Point(15, 177);
            grp_Read.Name = "grp_Read";
            grp_Read.Size = new Size(351, 231);
            grp_Read.TabIndex = 9;
            grp_Read.TabStop = false;
            grp_Read.Text = "讀取";
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(97, 176);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(130, 48);
            btn_Read.TabIndex = 8;
            btn_Read.Text = "讀取";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // grp_Write
            // 
            grp_Write.Controls.Add(btn_Write);
            grp_Write.Controls.Add(txt_WriteAddress);
            grp_Write.Controls.Add(lbl_WriteType);
            grp_Write.Controls.Add(lbl_WriteAddress);
            grp_Write.Controls.Add(cmb_WriteType);
            grp_Write.Controls.Add(txt_WriteValue);
            grp_Write.Controls.Add(lbl_WriteValue);
            grp_Write.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_Write.Location = new Point(15, 414);
            grp_Write.Name = "grp_Write";
            grp_Write.Size = new Size(351, 240);
            grp_Write.TabIndex = 10;
            grp_Write.TabStop = false;
            grp_Write.Text = "寫入";
            // 
            // btn_Write
            // 
            btn_Write.Enabled = false;
            btn_Write.Location = new Point(97, 184);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(130, 48);
            btn_Write.TabIndex = 8;
            btn_Write.Text = "寫入";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // txt_WriteAddress
            // 
            txt_WriteAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_WriteAddress.Location = new Point(159, 94);
            txt_WriteAddress.Name = "txt_WriteAddress";
            txt_WriteAddress.Size = new Size(176, 39);
            txt_WriteAddress.TabIndex = 3;
            // 
            // lbl_WriteType
            // 
            lbl_WriteType.AutoSize = true;
            lbl_WriteType.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WriteType.Location = new Point(18, 48);
            lbl_WriteType.Name = "lbl_WriteType";
            lbl_WriteType.Size = new Size(75, 33);
            lbl_WriteType.TabIndex = 7;
            lbl_WriteType.Text = "類型";
            // 
            // lbl_WriteAddress
            // 
            lbl_WriteAddress.AutoSize = true;
            lbl_WriteAddress.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WriteAddress.Location = new Point(18, 94);
            lbl_WriteAddress.Name = "lbl_WriteAddress";
            lbl_WriteAddress.Size = new Size(135, 33);
            lbl_WriteAddress.TabIndex = 2;
            lbl_WriteAddress.Text = "寫入位置";
            // 
            // cmb_WriteType
            // 
            cmb_WriteType.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmb_WriteType.FormattingEnabled = true;
            cmb_WriteType.Items.AddRange(new object[] { "線圈", "離散輸入", "保持暫存器", "輸入暫存器" });
            cmb_WriteType.Location = new Point(159, 45);
            cmb_WriteType.Name = "cmb_WriteType";
            cmb_WriteType.Size = new Size(176, 40);
            cmb_WriteType.TabIndex = 6;
            // 
            // txt_WriteValue
            // 
            txt_WriteValue.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_WriteValue.Location = new Point(159, 139);
            txt_WriteValue.Name = "txt_WriteValue";
            txt_WriteValue.Size = new Size(176, 39);
            txt_WriteValue.TabIndex = 5;
            // 
            // lbl_WriteValue
            // 
            lbl_WriteValue.AutoSize = true;
            lbl_WriteValue.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_WriteValue.Location = new Point(18, 142);
            lbl_WriteValue.Name = "lbl_WriteValue";
            lbl_WriteValue.Size = new Size(135, 33);
            lbl_WriteValue.TabIndex = 4;
            lbl_WriteValue.Text = "寫入數值";
            // 
            // cmb_Port
            // 
            cmb_Port.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 136);
            cmb_Port.FormattingEnabled = true;
            cmb_Port.Location = new Point(20, 24);
            cmb_Port.Name = "cmb_Port";
            cmb_Port.Size = new Size(181, 43);
            cmb_Port.TabIndex = 11;
            cmb_Port.SelectedIndexChanged += cmb_Port_SelectedIndexChanged;
            // 
            // btn_Connect
            // 
            btn_Connect.Enabled = false;
            btn_Connect.Location = new Point(207, 19);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(130, 48);
            btn_Connect.TabIndex = 12;
            btn_Connect.Text = "連接";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_Disconnect
            // 
            btn_Disconnect.Enabled = false;
            btn_Disconnect.Location = new Point(344, 19);
            btn_Disconnect.Margin = new Padding(4);
            btn_Disconnect.Name = "btn_Disconnect";
            btn_Disconnect.Size = new Size(118, 48);
            btn_Disconnect.TabIndex = 13;
            btn_Disconnect.Text = "斷開";
            btn_Disconnect.UseVisualStyleBackColor = true;
            btn_Disconnect.Click += btn_Disconnect_Click;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 687);
            Controls.Add(btn_Disconnect);
            Controls.Add(btn_Connect);
            Controls.Add(cmb_Port);
            Controls.Add(grp_Write);
            Controls.Add(grp_Read);
            Controls.Add(lbl_SlaveAdress);
            Controls.Add(dgv_Read);
            Controls.Add(txt_SlaveAddress);
            Name = "Frm_Main";
            Text = "Modbus ";
            ((System.ComponentModel.ISupportInitialize)dgv_Read).EndInit();
            grp_Read.ResumeLayout(false);
            grp_Read.PerformLayout();
            grp_Write.ResumeLayout(false);
            grp_Write.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grp_HoldingRegister;
        private Label lbl_SlaveAdress;
        private Label lbl_ReadAddress;
        private TextBox txt_SlaveAddress;
        private TextBox txt_ReadAddress;
        private Label lbl_NumberOfPoint;
        private TextBox txt_NumberOfPoint;
        private ComboBox cmb_ReadType;
        private Label lbl_ReadType;
        private DataGridView dgv_Read;
        private GroupBox grp_Read;
        private Button btn_Read;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Value;
        private GroupBox grp_Write;
        private Button btn_Write;
        private TextBox txt_WriteAddress;
        private Label lbl_WriteType;
        private Label lbl_WriteAddress;
        private ComboBox cmb_WriteType;
        private TextBox txt_WriteValue;
        private Label lbl_WriteValue;
        private ComboBox cmb_Port;
        private Button btn_Connect;
        private Button btn_Disconnect;
    }
}

