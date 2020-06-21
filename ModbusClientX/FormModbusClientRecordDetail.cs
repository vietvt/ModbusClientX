using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace ModbusClientX
{
    public partial class FormModbusClientRecordDetail : Form
    {
        readonly ModbusData dataObject;
        public FormModbusClientRecordDetail(ModbusData record, ModbusClient c)
        {
            InitializeComponent();
            dataObject = record;
            dataObject.ObjectHasChanged += R_ObjectHasChanged;
            this.propertyGridModbusDetail.SelectedObject = dataObject;
            
            client = c;
        }

        private void R_ObjectHasChanged(object sender, EventArgs e)
        {
            this.btnWrite.Enabled = this.dataObject.HasChanged;
        }

        readonly ModbusClient client;
        private void propertyGridModbusDetail_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            this.propertyGridModbusDetail.Refresh();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                var o = this.propertyGridModbusDetail.SelectedObject as ModbusData;
                o?.WriteToDevice(client);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormModbusClientRecordDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataObject.ObjectHasChanged -= R_ObjectHasChanged;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dataObject.HasChanged)
            {
                try
                {
                    var r = MessageBox.Show("Write changes to device?", "Confirmation", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK)
                    {
                        dataObject.WriteToDevice(client);
                    }
                    else
                    {
                        dataObject.CancelChange();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    
}
