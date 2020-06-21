using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using EasyModbus;
using Newtonsoft.Json;

namespace ModbusClientX
{
    public partial class FormModbusClient : Form
    {
        private readonly List<bool> coils = new List<bool>();

        
        private MethodInvoker function;
        private readonly StringBuilder logs = new StringBuilder();
        private ModbusClient ModbusClient;
        private readonly List<int> registers = new List<int>();


        private int startAddress, numberOfAddress;
        
        public FormModbusClient()
        {
            InitializeComponent();
            ModbusClient = new ModbusClient();

            ModbusClient.ReceiveDataChanged += UpdateReceiveData;
            ModbusClient.SendDataChanged += UpdateSendData;
            ModbusClient.ConnectedChanged += UpdateConnectedChanged;

            InitGrid();
            //(cbbParity.SelectedIndex, cbbSelectComPort.SelectedIndex, cbbStopbits.SelectedIndex)
            //    = (0, 0, 0);
            //this.cbbSelectComPort.SelectedIndex = 0;
            //this.cbbParity.SelectedIndex = 0;
            //this.cbbStopbits.SelectedIndex = 0;

            enableControl();
        }

        private void InitGrid()
        {
            bindingSourceCoil.DataSource = ModbusDataCollectionService.Coils;
            bindingSourceDiscreteInput.DataSource = ModbusDataCollectionService.DiscreteInputs;
            bindingSourceHoldingRegister.DataSource = ModbusDataCollectionService.HoldingRegisters;
            bindingSourceInputRegister.DataSource = ModbusDataCollectionService.InputRegisters;
            ModbusFunctionChanged(tabPageHoldingRegister, null);
            
            //PrepareShowingAddress();
        }

        private void UpdateReceiveData(object sender)
        {
            var receiveData = "Rx: " + BitConverter.ToString(ModbusClient.receiveData).Replace("-", " ") +
                              Environment.NewLine;
            WriteLog(receiveData);
        }

        private void UpdateSendData(object sender)
        {
            var sendData = "Tx: " + BitConverter.ToString(ModbusClient.sendData).Replace("-", " ") +
                           Environment.NewLine;
            WriteLog(sendData);
        }

        private void UpdateConnectedChanged(object sender)
        {
            enableControl();
        }
        void enableControl()
        {
            if (ModbusClient.Connected)
                lblStatus.Text = "Connected to Server";
            //txtConnectedStatus.BackColor = Color.Green;
            else
                lblStatus.Text = "Not Connected to Server";

            var enb = ModbusClient.Connected;
            this.TabControlFunction.Enabled = enb;
            this.btnSendCommand.Enabled = enb;
        }

        DataGridView selectedGridView;
        private void ModbusFunctionChanged(object sender, EventArgs e)
        {
            
            if (TabControlFunction.SelectedTab == tabPageCoil)
            {
                function = ReadCoils;
                selectedGridView = dataGridViewCoil;
            }
            else if (TabControlFunction.SelectedTab == tabPageDiscreteInput)
            {
                function = ReadDiscreteInputs;
                selectedGridView = dataGridViewDiscreteInput;

            }
            else if (TabControlFunction.SelectedTab == tabPageHoldingRegister)
            {
                function = ReadHoldingRegisters;
                selectedGridView = dataGridViewHoldingRegister;
            }
            else if (TabControlFunction.SelectedTab == tabPageInputRegister)
            {
                function = ReadInputRegisters;
                selectedGridView = dataGridViewInputRegister;
            }
            selectedGridView.Focus();
            txtStartAddress.Text = selectedGridView.FirstDisplayedScrollingRowIndex.ToString();
        }
       
        private void ReadCoils()
        {
            ModbusDataCollectionService.ReadCoils(ModbusClient, startAddress, numberOfAddress);
        }

        private void ReadDiscreteInputs()
        {
            ModbusDataCollectionService.ReadDiscreteInputs(ModbusClient, startAddress, numberOfAddress);
        }

        private void ReadHoldingRegisters()
        {
            ModbusDataCollectionService.ReadHoldingRegisters(ModbusClient, startAddress, numberOfAddress);
        }

        private void ReadInputRegisters()
        {
            ModbusDataCollectionService.ReadInputRegisters(ModbusClient, startAddress, numberOfAddress);
        }

        

        private void startAddress_TextChanged(object sender, EventArgs e)
        {
            PrepareShowingAddress();
        }

        private void PrepareShowingAddress()
        {
            int i;
            var v = int.TryParse(txtStartAddress.Text, out i);
            if (i <0)
            {
                i = 0;
                txtStartAddress.Text = "0";
            }
            startAddress = i;
            
            if (selectedGridView !=null && selectedGridView.Rows.Count >i)
            {
                selectedGridView.FirstDisplayedScrollingRowIndex = i;
            }
            

            v = int.TryParse(txtNumberOfRecords.Text, out i);
            numberOfAddress = i;
            this.btnSendCommand.Text = "Read from " + txtStartAddress.Text + " to " + (startAddress + i - 1).ToString();

            
        }

        private void DataGridView_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll
                && txtStartAddress.Text != e.NewValue.ToString())
                txtStartAddress.Text = e.NewValue.ToString();
        }

        private void txtNumberOfRecords_TextChanged(object sender, EventArgs e)
        {
            PrepareShowingAddress();
            
        }


        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            //if (confirmWrite)
            //{
            //    var cf = MessageBox.Show("Confirm write to device?", "Confirmation", MessageBoxButtons.OKCancel,
            //        MessageBoxIcon.Warning);
            //    if (cf == DialogResult.Cancel) return;
            //}

            try
            {
                startAddress = int.Parse(txtStartAddress.Text);
                numberOfAddress = int.Parse(txtNumberOfRecords.Text);
                function.Invoke();

                bindingSourceCoil.ResetBindings(false); 
                bindingSourceDiscreteInput.ResetBindings(false);
                bindingSourceHoldingRegister.ResetBindings(false);
                bindingSourceInputRegister.ResetBindings(false);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Unable to connect to Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        ///     Show the modbus data in property editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModbusDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenDetailForm();
        }

        /// <summary>
        /// Open the detail form for modbus data editing
        /// </summary>
        private void OpenDetailForm()
        {
            var obj = selectedGridView.CurrentRow.DataBoundItem as ModbusData;
            var f = new FormModbusClientRecordDetail(obj, ModbusClient);
            f.ShowDialog();
            selectedGridView.Refresh();
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
            logs.Clear();
        }

        /// <summary>
        ///     log messages to txtLog
        /// </summary>
        /// <param name="log">log message</param>
        private void WriteLog(string log)
        {
            if (!chkLogMsg.Checked)
            {
                return;
            }
            if (txtLog.InvokeRequired)
            {
                var d1 = new writeLogDelegate(wlog);
                txtLog.Invoke(d1, log);
            }
            else
            {
                wlog(log);
            }

            void wlog(string _log)
            {
                var l = "*** " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss:ffff") + " ***"
                        + Environment.NewLine
                        + _log + Environment.NewLine;
                logs.Insert(0, l);
                txtLog.Text = logs.ToString();
            }
        }

        

        private void showSetting()
        {
            FormConnectionSetting f = new FormConnectionSetting(this.ModbusClient);
            f.ShowDialog();
        }

        private void connectionSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showSetting();
        }

        private void FormModbusClient_Load(object sender, EventArgs e)
        {
            showSetting();
        }

        private void chkEditMode_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridViewHoldingRegister.ReadOnly = !chkEditMode.Checked;
            this.dataGridViewCoil.ReadOnly = !chkEditMode.Checked;
            this.chkAutoWrite.Enabled = chkEditMode.Checked;
            this.btnWriteChanges.Enabled = !autoWrite;
            this.btnCancelAllChanges.Enabled = !autoWrite;
        }

        private void btnWriteChanges_Click(object sender, EventArgs e)
        {
            var c = MessageBox.Show("Confirm Write", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                ModbusDataCollectionService.WriteAllChanges(this.ModbusClient);
                selectedGridView.Refresh();
            }
            
        }

        private void btnCancelAllChanges_Click(object sender, EventArgs e)
        {
            ModbusDataCollectionService.CancelChanges(this.ModbusClient);
            bindingSourceCoil.ResetBindings(false);
            bindingSourceHoldingRegister.ResetBindings(false);
        }

        private void chkAutoWrite_CheckedChanged(object sender, EventArgs e)
        {
            autoWrite = chkAutoWrite.Checked;
            this.btnWriteChanges.Enabled = !autoWrite;
            this.btnCancelAllChanges.Enabled = !autoWrite;
        }

        /// <summary>
        /// indicate auto commit changes to device (sending write command) in inline edit mode
        /// </summary>
        bool autoWrite = false;

        
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // auto commit changes to device (sending write command) in inline edit mode
            if (autoWrite)
            {
                var v = sender as DataGridView;

                var o = v.Rows[e.RowIndex].DataBoundItem as ModbusData;
                if (o.HasChanged)
                {
                    try
                    {
                        o.WriteToDevice(this.ModbusClient);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // show form for chosing address to move to
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            {
                ShowAddressFindForm();
            }
            else if ((e.Control && e.KeyCode == Keys.O)
                || e.KeyCode == Keys.Enter)
            {
                OpenDetailForm();
            }
        }

        private void ShowAddressFindForm()
        {
            FormGotoAddress f = new FormGotoAddress();
            var i =  selectedGridView.CurrentRow.Index;
            f.Address = i;
            if (f.ShowDialog() == DialogResult.OK)
            {
                i = f.Address;
                selectedGridView.ClearSelection();
                selectedGridView.Rows[i].Selected = true;
                //g.FirstDisplayedScrollingRowIndex = i;
                var bind = selectedGridView.DataSource as BindingSource;
                bind.CurrencyManager.Position = i;
            }
        }

        private void TabControlFunction_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var g = sender as DataGridView;
            var r = g.Rows[e.RowIndex].DataBoundItem as ModbusData;
            if (r.HasChanged)
            {
                e.CellStyle.BackColor = Color.Orange;
            }
            else
            {
                e.CellStyle.BackColor = Color.WhiteSmoke;
            }
        }

        private void goToAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddressFindForm();
        }

        private void NavigationMenu_Click(object sender, EventArgs e)
        {
            if (sender == this.holdingRegisterToolStripMenuItem)
            {
                this.TabControlFunction.SelectedTab = tabPageHoldingRegister;
            }
            else if (sender == this.inputRegisterToolStripMenuItem)
            {
                this.TabControlFunction.SelectedTab = tabPageInputRegister;
            }
            else if (sender == this.coilToolStripMenuItem)
            {
                this.TabControlFunction.SelectedTab = tabPageCoil;
            }
            else if (sender == this.discreteInputToolStripMenuItem)
            {
                this.TabControlFunction.SelectedTab = tabPageDiscreteInput;
            }
        }

        private void toolStripMenuItemOpenDetail_Click(object sender, EventArgs e)
        {
            OpenDetailForm();
        }

        

        private void SwitchToNextTabPage()
        {
            var c = this.TabControlFunction.TabCount;
            if (this.TabControlFunction.SelectedIndex == c - 1)
            {
                this.TabControlFunction.SelectedIndex = 0;
            }
            else
            {
                this.TabControlFunction.SelectedIndex++;
            }
        }

        private void switchToNextTabPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchToNextTabPage();
        }

        private void modbusRecordMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormModbusMonitor(this.ModbusClient).Show();
        }

        private void chkLogMsg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private delegate void writeLogDelegate(string log);
    }
}