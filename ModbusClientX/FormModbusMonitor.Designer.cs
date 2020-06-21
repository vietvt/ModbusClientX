namespace ModbusClientX
{
    partial class FormModbusMonitor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewHoldingRegister = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCoil = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartMonitor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStopMonitor = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.holdingRegisterDecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingRegisterBinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHoldingRegister = new System.Windows.Forms.BindingSource(this.components);
            this.coilValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceCoil = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoldingRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoil)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHoldingRegister
            // 
            this.dataGridViewHoldingRegister.AllowUserToAddRows = false;
            this.dataGridViewHoldingRegister.AllowUserToDeleteRows = false;
            this.dataGridViewHoldingRegister.AutoGenerateColumns = false;
            this.dataGridViewHoldingRegister.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewHoldingRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoldingRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Address,
            this.AdressHex,
            this.holdingRegisterDecDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.holdingRegisterBinDataGridViewTextBoxColumn});
            this.dataGridViewHoldingRegister.DataSource = this.bindingSourceHoldingRegister;
            this.dataGridViewHoldingRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHoldingRegister.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHoldingRegister.Name = "dataGridViewHoldingRegister";
            this.dataGridViewHoldingRegister.ReadOnly = true;
            this.dataGridViewHoldingRegister.Size = new System.Drawing.Size(393, 398);
            this.dataGridViewHoldingRegister.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 89;
            // 
            // AdressHex
            // 
            this.AdressHex.DataPropertyName = "AdressHex";
            this.AdressHex.HeaderText = "Adress (Hex)";
            this.AdressHex.Name = "AdressHex";
            this.AdressHex.ReadOnly = true;
            this.AdressHex.Width = 82;
            // 
            // dataGridViewCoil
            // 
            this.dataGridViewCoil.AllowUserToAddRows = false;
            this.dataGridViewCoil.AllowUserToDeleteRows = false;
            this.dataGridViewCoil.AutoGenerateColumns = false;
            this.dataGridViewCoil.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.coilValueDataGridViewCheckBoxColumn});
            this.dataGridViewCoil.DataSource = this.bindingSourceCoil;
            this.dataGridViewCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCoil.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCoil.Name = "dataGridViewCoil";
            this.dataGridViewCoil.ReadOnly = true;
            this.dataGridViewCoil.Size = new System.Drawing.Size(383, 398);
            this.dataGridViewCoil.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "Address";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "AdressHex";
            this.dataGridViewTextBoxColumn10.HeaderText = "Adress (Hex)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnOption
            // 
            this.btnOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOption.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnOption.Location = new System.Drawing.Point(8, 416);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(102, 38);
            this.btnOption.TabIndex = 63;
            this.btnOption.Text = "Option";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnClose.Location = new System.Drawing.Point(401, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 38);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartMonitor
            // 
            this.btnStartMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartMonitor.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnStartMonitor.Location = new System.Drawing.Point(116, 416);
            this.btnStartMonitor.Name = "btnStartMonitor";
            this.btnStartMonitor.Size = new System.Drawing.Size(137, 38);
            this.btnStartMonitor.TabIndex = 65;
            this.btnStartMonitor.Text = "Start Monitor";
            this.btnStartMonitor.UseVisualStyleBackColor = true;
            this.btnStartMonitor.Click += new System.EventHandler(this.btnStartMonitor_Click);
            // 
            // btnStopMonitor
            // 
            this.btnStopMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopMonitor.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnStopMonitor.Location = new System.Drawing.Point(259, 416);
            this.btnStopMonitor.Name = "btnStopMonitor";
            this.btnStopMonitor.Size = new System.Drawing.Size(137, 38);
            this.btnStopMonitor.TabIndex = 66;
            this.btnStopMonitor.Text = "Stop Monitor";
            this.btnStopMonitor.UseVisualStyleBackColor = true;
            this.btnStopMonitor.Click += new System.EventHandler(this.btnStopMonitor_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(8, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewHoldingRegister);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCoil);
            this.splitContainer1.Size = new System.Drawing.Size(780, 398);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 67;
            // 
            // holdingRegisterDecDataGridViewTextBoxColumn
            // 
            this.holdingRegisterDecDataGridViewTextBoxColumn.DataPropertyName = "HoldingRegisterDec";
            this.holdingRegisterDecDataGridViewTextBoxColumn.HeaderText = "Holding Register";
            this.holdingRegisterDecDataGridViewTextBoxColumn.Name = "holdingRegisterDecDataGridViewTextBoxColumn";
            this.holdingRegisterDecDataGridViewTextBoxColumn.ReadOnly = true;
            this.holdingRegisterDecDataGridViewTextBoxColumn.Width = 147;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HoldingRegisterHex";
            this.dataGridViewTextBoxColumn1.HeaderText = "Holding Register (Hex)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 132;
            // 
            // holdingRegisterBinDataGridViewTextBoxColumn
            // 
            this.holdingRegisterBinDataGridViewTextBoxColumn.DataPropertyName = "HoldingRegisterBin";
            this.holdingRegisterBinDataGridViewTextBoxColumn.HeaderText = "Holding Register (Binary)";
            this.holdingRegisterBinDataGridViewTextBoxColumn.Name = "holdingRegisterBinDataGridViewTextBoxColumn";
            this.holdingRegisterBinDataGridViewTextBoxColumn.ReadOnly = true;
            this.holdingRegisterBinDataGridViewTextBoxColumn.Width = 154;
            // 
            // bindingSourceHoldingRegister
            // 
            this.bindingSourceHoldingRegister.AllowNew = false;
            this.bindingSourceHoldingRegister.DataSource = typeof(ModbusClientX.HoldingRegister);
            this.bindingSourceHoldingRegister.Sort = "Address ASC";
            // 
            // coilValueDataGridViewCheckBoxColumn
            // 
            this.coilValueDataGridViewCheckBoxColumn.DataPropertyName = "CoilValue";
            this.coilValueDataGridViewCheckBoxColumn.HeaderText = "CoilValue";
            this.coilValueDataGridViewCheckBoxColumn.Name = "coilValueDataGridViewCheckBoxColumn";
            this.coilValueDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSourceCoil
            // 
            this.bindingSourceCoil.AllowNew = false;
            this.bindingSourceCoil.DataSource = typeof(ModbusClientX.Coil);
            this.bindingSourceCoil.Sort = "Address ASC";
            // 
            // FormModbusMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnStopMonitor);
            this.Controls.Add(this.btnStartMonitor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOption);
            this.Name = "FormModbusMonitor";
            this.Text = "Modbus Monitor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoil)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoldingRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceHoldingRegister;
        private System.Windows.Forms.BindingSource bindingSourceCoil;
        private System.Windows.Forms.DataGridView dataGridViewHoldingRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingRegisterDecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingRegisterBinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coilValueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStartMonitor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStopMonitor;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}