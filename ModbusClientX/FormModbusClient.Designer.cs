namespace ModbusClientX
{
    partial class FormModbusClient
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.txtNumberOfRecords = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkEditMode = new System.Windows.Forms.CheckBox();
            this.dataGridViewHoldingRegister = new System.Windows.Forms.DataGridView();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdressHex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingRegisterDecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holdingRegisterBinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHoldingRegister = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControlFunction = new System.Windows.Forms.TabControl();
            this.tabPageHoldingRegister = new System.Windows.Forms.TabPage();
            this.tabPageInputRegister = new System.Windows.Forms.TabPage();
            this.dataGridViewInputRegister = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputRegisterDecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputRegisterBinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceInputRegister = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageCoil = new System.Windows.Forms.TabPage();
            this.dataGridViewCoil = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coilValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceCoil = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageDiscreteInput = new System.Windows.Forms.TabPage();
            this.dataGridViewDiscreteInput = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discreteInputValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceDiscreteInput = new System.Windows.Forms.BindingSource(this.components);
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelAllChanges = new System.Windows.Forms.Button();
            this.btnWriteChanges = new System.Windows.Forms.Button();
            this.chkAutoWrite = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.holdingRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discreteInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToNextTabPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpenDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusRecordMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkLogMsg = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoldingRegister)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.TabControlFunction.SuspendLayout();
            this.tabPageHoldingRegister.SuspendLayout();
            this.tabPageInputRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInputRegister)).BeginInit();
            this.tabPageCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoil)).BeginInit();
            this.tabPageDiscreteInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscreteInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiscreteInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendCommand);
            this.groupBox2.Controls.Add(this.txtNumberOfRecords);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtStartAddress);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 91);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select  Addresses";
            // 
            // btnSendCommand
            // 
            this.btnSendCommand.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnSendCommand.Location = new System.Drawing.Point(283, 29);
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.Size = new System.Drawing.Size(253, 43);
            this.btnSendCommand.TabIndex = 62;
            this.btnSendCommand.Text = "Read";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.btnSendCommand_Click);
            // 
            // txtNumberOfRecords
            // 
            this.txtNumberOfRecords.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfRecords.Location = new System.Drawing.Point(149, 50);
            this.txtNumberOfRecords.Name = "txtNumberOfRecords";
            this.txtNumberOfRecords.Size = new System.Drawing.Size(117, 22);
            this.txtNumberOfRecords.TabIndex = 60;
            this.txtNumberOfRecords.Text = "10";
            this.txtNumberOfRecords.TextChanged += new System.EventHandler(this.txtNumberOfRecords_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(149, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "# of Adresses";
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartAddress.Location = new System.Drawing.Point(28, 50);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(106, 22);
            this.txtStartAddress.TabIndex = 58;
            this.txtStartAddress.Text = "1";
            this.txtStartAddress.TextChanged += new System.EventHandler(this.startAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Start address";
            // 
            // chkEditMode
            // 
            this.chkEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEditMode.Location = new System.Drawing.Point(10, 293);
            this.chkEditMode.Name = "chkEditMode";
            this.chkEditMode.Size = new System.Drawing.Size(138, 40);
            this.chkEditMode.TabIndex = 63;
            this.chkEditMode.Text = "Enabe &Inline Edit Mode";
            this.chkEditMode.CheckedChanged += new System.EventHandler(this.chkEditMode_CheckedChanged);
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
            this.dataGridViewHoldingRegister.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewHoldingRegister.Name = "dataGridViewHoldingRegister";
            this.dataGridViewHoldingRegister.ReadOnly = true;
            this.dataGridViewHoldingRegister.Size = new System.Drawing.Size(535, 256);
            this.dataGridViewHoldingRegister.TabIndex = 3;
            this.dataGridViewHoldingRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModbusDataGridView_CellDoubleClick);
            this.dataGridViewHoldingRegister.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridViewHoldingRegister.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridViewHoldingRegister.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridView_Scroll);
            this.dataGridViewHoldingRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
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
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip1.Size = new System.Drawing.Size(914, 22);
            this.statusStrip1.TabIndex = 63;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 17);
            this.lblStatus.Text = "...";
            // 
            // TabControlFunction
            // 
            this.TabControlFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlFunction.Controls.Add(this.tabPageHoldingRegister);
            this.TabControlFunction.Controls.Add(this.tabPageInputRegister);
            this.TabControlFunction.Controls.Add(this.tabPageCoil);
            this.TabControlFunction.Controls.Add(this.tabPageDiscreteInput);
            this.TabControlFunction.Location = new System.Drawing.Point(3, 3);
            this.TabControlFunction.Name = "TabControlFunction";
            this.TabControlFunction.SelectedIndex = 0;
            this.TabControlFunction.Size = new System.Drawing.Size(549, 291);
            this.TabControlFunction.TabIndex = 64;
            this.TabControlFunction.SelectedIndexChanged += new System.EventHandler(this.ModbusFunctionChanged);
            this.TabControlFunction.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlFunction_Selected);
            // 
            // tabPageHoldingRegister
            // 
            this.tabPageHoldingRegister.Controls.Add(this.dataGridViewHoldingRegister);
            this.tabPageHoldingRegister.Location = new System.Drawing.Point(4, 25);
            this.tabPageHoldingRegister.Name = "tabPageHoldingRegister";
            this.tabPageHoldingRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHoldingRegister.Size = new System.Drawing.Size(541, 262);
            this.tabPageHoldingRegister.TabIndex = 0;
            this.tabPageHoldingRegister.Text = "Holding Register";
            this.tabPageHoldingRegister.UseVisualStyleBackColor = true;
            // 
            // tabPageInputRegister
            // 
            this.tabPageInputRegister.Controls.Add(this.dataGridViewInputRegister);
            this.tabPageInputRegister.Location = new System.Drawing.Point(4, 22);
            this.tabPageInputRegister.Name = "tabPageInputRegister";
            this.tabPageInputRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInputRegister.Size = new System.Drawing.Size(541, 265);
            this.tabPageInputRegister.TabIndex = 1;
            this.tabPageInputRegister.Text = "Input Register";
            this.tabPageInputRegister.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInputRegister
            // 
            this.dataGridViewInputRegister.AllowUserToAddRows = false;
            this.dataGridViewInputRegister.AllowUserToDeleteRows = false;
            this.dataGridViewInputRegister.AutoGenerateColumns = false;
            this.dataGridViewInputRegister.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewInputRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.inputRegisterDecDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6,
            this.inputRegisterBinDataGridViewTextBoxColumn});
            this.dataGridViewInputRegister.DataSource = this.bindingSourceInputRegister;
            this.dataGridViewInputRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInputRegister.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInputRegister.Name = "dataGridViewInputRegister";
            this.dataGridViewInputRegister.ReadOnly = true;
            this.dataGridViewInputRegister.Size = new System.Drawing.Size(535, 259);
            this.dataGridViewInputRegister.TabIndex = 4;
            this.dataGridViewInputRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModbusDataGridView_CellDoubleClick);
            this.dataGridViewInputRegister.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridView_Scroll);
            this.dataGridViewInputRegister.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AdressHex";
            this.dataGridViewTextBoxColumn5.HeaderText = "Adress (Hex)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // inputRegisterDecDataGridViewTextBoxColumn
            // 
            this.inputRegisterDecDataGridViewTextBoxColumn.DataPropertyName = "InputRegisterDec";
            this.inputRegisterDecDataGridViewTextBoxColumn.HeaderText = "Input Register";
            this.inputRegisterDecDataGridViewTextBoxColumn.Name = "inputRegisterDecDataGridViewTextBoxColumn";
            this.inputRegisterDecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InputRegisterHex";
            this.dataGridViewTextBoxColumn6.HeaderText = "Input Register (Hex)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // inputRegisterBinDataGridViewTextBoxColumn
            // 
            this.inputRegisterBinDataGridViewTextBoxColumn.DataPropertyName = "InputRegisterBin";
            this.inputRegisterBinDataGridViewTextBoxColumn.HeaderText = "Input Register (Binary)";
            this.inputRegisterBinDataGridViewTextBoxColumn.Name = "inputRegisterBinDataGridViewTextBoxColumn";
            this.inputRegisterBinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceInputRegister
            // 
            this.bindingSourceInputRegister.AllowNew = false;
            this.bindingSourceInputRegister.DataSource = typeof(ModbusClientX.InputRegister);
            // 
            // tabPageCoil
            // 
            this.tabPageCoil.Controls.Add(this.dataGridViewCoil);
            this.tabPageCoil.Location = new System.Drawing.Point(4, 22);
            this.tabPageCoil.Name = "tabPageCoil";
            this.tabPageCoil.Size = new System.Drawing.Size(541, 265);
            this.tabPageCoil.TabIndex = 2;
            this.tabPageCoil.Text = "Coil";
            this.tabPageCoil.UseVisualStyleBackColor = true;
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
            this.dataGridViewCoil.Size = new System.Drawing.Size(541, 265);
            this.dataGridViewCoil.TabIndex = 4;
            this.dataGridViewCoil.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModbusDataGridView_CellDoubleClick);
            this.dataGridViewCoil.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridViewCoil.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridViewCoil.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridView_Scroll);
            this.dataGridViewCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
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
            // 
            // tabPageDiscreteInput
            // 
            this.tabPageDiscreteInput.Controls.Add(this.dataGridViewDiscreteInput);
            this.tabPageDiscreteInput.Location = new System.Drawing.Point(4, 22);
            this.tabPageDiscreteInput.Name = "tabPageDiscreteInput";
            this.tabPageDiscreteInput.Size = new System.Drawing.Size(541, 265);
            this.tabPageDiscreteInput.TabIndex = 3;
            this.tabPageDiscreteInput.Text = "Discrete Input";
            this.tabPageDiscreteInput.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDiscreteInput
            // 
            this.dataGridViewDiscreteInput.AllowUserToAddRows = false;
            this.dataGridViewDiscreteInput.AllowUserToDeleteRows = false;
            this.dataGridViewDiscreteInput.AutoGenerateColumns = false;
            this.dataGridViewDiscreteInput.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewDiscreteInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscreteInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.discreteInputValueDataGridViewCheckBoxColumn});
            this.dataGridViewDiscreteInput.DataSource = this.bindingSourceDiscreteInput;
            this.dataGridViewDiscreteInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiscreteInput.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDiscreteInput.Name = "dataGridViewDiscreteInput";
            this.dataGridViewDiscreteInput.ReadOnly = true;
            this.dataGridViewDiscreteInput.Size = new System.Drawing.Size(541, 265);
            this.dataGridViewDiscreteInput.TabIndex = 4;
            this.dataGridViewDiscreteInput.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ModbusDataGridView_CellDoubleClick);
            this.dataGridViewDiscreteInput.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGridView_Scroll);
            this.dataGridViewDiscreteInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn11.HeaderText = "Address";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "AdressHex";
            this.dataGridViewTextBoxColumn12.HeaderText = "Adress (Hex)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // discreteInputValueDataGridViewCheckBoxColumn
            // 
            this.discreteInputValueDataGridViewCheckBoxColumn.DataPropertyName = "DiscreteInputValue";
            this.discreteInputValueDataGridViewCheckBoxColumn.HeaderText = "Discrete Input";
            this.discreteInputValueDataGridViewCheckBoxColumn.Name = "discreteInputValueDataGridViewCheckBoxColumn";
            this.discreteInputValueDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSourceDiscreteInput
            // 
            this.bindingSourceDiscreteInput.AllowNew = false;
            this.bindingSourceDiscreteInput.DataSource = typeof(ModbusClientX.DiscreteInput);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(3, 28);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(324, 309);
            this.txtLog.TabIndex = 65;
            this.txtLog.Text = "";
            // 
            // btnClearLog
            // 
            this.btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLog.Location = new System.Drawing.Point(228, 0);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(99, 29);
            this.btnClearLog.TabIndex = 68;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 124);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelAllChanges);
            this.splitContainer1.Panel1.Controls.Add(this.btnWriteChanges);
            this.splitContainer1.Panel1.Controls.Add(this.chkAutoWrite);
            this.splitContainer1.Panel1.Controls.Add(this.chkEditMode);
            this.splitContainer1.Panel1.Controls.Add(this.TabControlFunction);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkLogMsg);
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearLog);
            this.splitContainer1.Size = new System.Drawing.Size(886, 340);
            this.splitContainer1.SplitterDistance = 555;
            this.splitContainer1.TabIndex = 69;
            // 
            // btnCancelAllChanges
            // 
            this.btnCancelAllChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelAllChanges.Enabled = false;
            this.btnCancelAllChanges.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnCancelAllChanges.Location = new System.Drawing.Point(439, 293);
            this.btnCancelAllChanges.Name = "btnCancelAllChanges";
            this.btnCancelAllChanges.Size = new System.Drawing.Size(109, 43);
            this.btnCancelAllChanges.TabIndex = 66;
            this.btnCancelAllChanges.Text = "&Cancel All Changes";
            this.btnCancelAllChanges.UseVisualStyleBackColor = true;
            this.btnCancelAllChanges.Click += new System.EventHandler(this.btnCancelAllChanges_Click);
            // 
            // btnWriteChanges
            // 
            this.btnWriteChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWriteChanges.Enabled = false;
            this.btnWriteChanges.Font = new System.Drawing.Font("Courier New", 10F);
            this.btnWriteChanges.Location = new System.Drawing.Point(334, 293);
            this.btnWriteChanges.Name = "btnWriteChanges";
            this.btnWriteChanges.Size = new System.Drawing.Size(99, 43);
            this.btnWriteChanges.TabIndex = 63;
            this.btnWriteChanges.Text = "&Write All Changes";
            this.btnWriteChanges.UseVisualStyleBackColor = true;
            this.btnWriteChanges.Click += new System.EventHandler(this.btnWriteChanges_Click);
            // 
            // chkAutoWrite
            // 
            this.chkAutoWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutoWrite.Enabled = false;
            this.chkAutoWrite.Location = new System.Drawing.Point(156, 293);
            this.chkAutoWrite.Name = "chkAutoWrite";
            this.chkAutoWrite.Size = new System.Drawing.Size(162, 40);
            this.chkAutoWrite.TabIndex = 65;
            this.chkAutoWrite.Text = "Enabe &Auto Write when Edit Inline";
            this.chkAutoWrite.CheckedChanged += new System.EventHandler(this.chkAutoWrite_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filleToolStripMenuItem,
            this.navigationToolStripMenuItem,
            this.monitorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filleToolStripMenuItem
            // 
            this.filleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionSettingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filleToolStripMenuItem.Name = "filleToolStripMenuItem";
            this.filleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.filleToolStripMenuItem.Text = "&File";
            // 
            // connectionSettingToolStripMenuItem
            // 
            this.connectionSettingToolStripMenuItem.Name = "connectionSettingToolStripMenuItem";
            this.connectionSettingToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.connectionSettingToolStripMenuItem.Text = "Connection Setting";
            this.connectionSettingToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToAddressToolStripMenuItem,
            this.toolStripMenuItem1,
            this.holdingRegisterToolStripMenuItem,
            this.inputRegisterToolStripMenuItem,
            this.coilToolStripMenuItem,
            this.discreteInputToolStripMenuItem,
            this.switchToNextTabPageToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemOpenDetail});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // goToAddressToolStripMenuItem
            // 
            this.goToAddressToolStripMenuItem.Name = "goToAddressToolStripMenuItem";
            this.goToAddressToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.goToAddressToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.goToAddressToolStripMenuItem.Text = "Go to Address";
            this.goToAddressToolStripMenuItem.Click += new System.EventHandler(this.goToAddressToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(251, 6);
            // 
            // holdingRegisterToolStripMenuItem
            // 
            this.holdingRegisterToolStripMenuItem.Name = "holdingRegisterToolStripMenuItem";
            this.holdingRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.H)));
            this.holdingRegisterToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.holdingRegisterToolStripMenuItem.Text = "Holding Register";
            this.holdingRegisterToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenu_Click);
            // 
            // inputRegisterToolStripMenuItem
            // 
            this.inputRegisterToolStripMenuItem.Name = "inputRegisterToolStripMenuItem";
            this.inputRegisterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.inputRegisterToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.inputRegisterToolStripMenuItem.Text = "Input Register";
            this.inputRegisterToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenu_Click);
            // 
            // coilToolStripMenuItem
            // 
            this.coilToolStripMenuItem.Name = "coilToolStripMenuItem";
            this.coilToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.coilToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.coilToolStripMenuItem.Text = "Coil";
            this.coilToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenu_Click);
            // 
            // discreteInputToolStripMenuItem
            // 
            this.discreteInputToolStripMenuItem.Name = "discreteInputToolStripMenuItem";
            this.discreteInputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.discreteInputToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.discreteInputToolStripMenuItem.Text = "Discrete Input";
            this.discreteInputToolStripMenuItem.Click += new System.EventHandler(this.NavigationMenu_Click);
            // 
            // switchToNextTabPageToolStripMenuItem
            // 
            this.switchToNextTabPageToolStripMenuItem.Name = "switchToNextTabPageToolStripMenuItem";
            this.switchToNextTabPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Tab)));
            this.switchToNextTabPageToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.switchToNextTabPageToolStripMenuItem.Text = "Switch To Next Tab Page";
            this.switchToNextTabPageToolStripMenuItem.Click += new System.EventHandler(this.switchToNextTabPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // toolStripMenuItemOpenDetail
            // 
            this.toolStripMenuItemOpenDetail.Name = "toolStripMenuItemOpenDetail";
            this.toolStripMenuItemOpenDetail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemOpenDetail.Size = new System.Drawing.Size(254, 22);
            this.toolStripMenuItemOpenDetail.Text = "Open Record Detail";
            this.toolStripMenuItemOpenDetail.Click += new System.EventHandler(this.toolStripMenuItemOpenDetail_Click);
            // 
            // monitorToolStripMenuItem
            // 
            this.monitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbusRecordMonitoringToolStripMenuItem});
            this.monitorToolStripMenuItem.Name = "monitorToolStripMenuItem";
            this.monitorToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.monitorToolStripMenuItem.Text = "Monitor";
            // 
            // modbusRecordMonitoringToolStripMenuItem
            // 
            this.modbusRecordMonitoringToolStripMenuItem.Name = "modbusRecordMonitoringToolStripMenuItem";
            this.modbusRecordMonitoringToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.modbusRecordMonitoringToolStripMenuItem.Text = "Modbus Records Monitoring";
            this.modbusRecordMonitoringToolStripMenuItem.Click += new System.EventHandler(this.modbusRecordMonitoringToolStripMenuItem_Click);
            // 
            // chkLogMsg
            // 
            this.chkLogMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLogMsg.Location = new System.Drawing.Point(14, 3);
            this.chkLogMsg.Name = "chkLogMsg";
            this.chkLogMsg.Size = new System.Drawing.Size(208, 22);
            this.chkLogMsg.TabIndex = 67;
            this.chkLogMsg.Text = "Enabe message Logging";
            this.chkLogMsg.CheckedChanged += new System.EventHandler(this.chkLogMsg_CheckedChanged);
            // 
            // FormModbusClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 489);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormModbusClient";
            this.Text = "Modbus Client X";
            this.Load += new System.EventHandler(this.FormModbusClient_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoldingRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHoldingRegister)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TabControlFunction.ResumeLayout(false);
            this.tabPageHoldingRegister.ResumeLayout(false);
            this.tabPageInputRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceInputRegister)).EndInit();
            this.tabPageCoil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCoil)).EndInit();
            this.tabPageDiscreteInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscreteInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiscreteInput)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewHoldingRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfRecords;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TabControl TabControlFunction;
        private System.Windows.Forms.TabPage tabPageHoldingRegister;
        private System.Windows.Forms.TabPage tabPageInputRegister;
        private System.Windows.Forms.BindingSource bindingSourceHoldingRegister;
        private System.Windows.Forms.BindingSource bindingSourceCoil;
        private System.Windows.Forms.BindingSource bindingSourceInputRegister;
        private System.Windows.Forms.BindingSource bindingSourceDiscreteInput;
        private System.Windows.Forms.TabPage tabPageCoil;
        private System.Windows.Forms.TabPage tabPageDiscreteInput;
        private System.Windows.Forms.DataGridView dataGridViewInputRegister;
        private System.Windows.Forms.DataGridView dataGridViewCoil;
        private System.Windows.Forms.DataGridView dataGridViewDiscreteInput;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdressHex;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingRegisterDecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn holdingRegisterBinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputRegisterDecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputRegisterBinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coilValueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discreteInputValueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkEditMode;
        private System.Windows.Forms.Button btnCancelAllChanges;
        private System.Windows.Forms.Button btnWriteChanges;
        private System.Windows.Forms.CheckBox chkAutoWrite;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToAddressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holdingRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discreteInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpenDetail;
        private System.Windows.Forms.ToolStripMenuItem switchToNextTabPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusRecordMonitoringToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkLogMsg;
    }
}