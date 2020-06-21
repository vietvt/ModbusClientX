using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace ModbusClientX
{
    public partial class FormModbusMonitor : Form
    {
        ModbusClient client;
        ModbusMonitorOptionData data;
        public FormModbusMonitor(ModbusClient c)
        {
            InitializeComponent();
            client = c;
            data = new ModbusMonitorOptionData();
            this.bindingSourceHoldingRegister.DataSource = data.HoldingRegisters;
            this.bindingSourceCoil.DataSource = data.Coils;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() => {
                foreach (var c in data.Coils)
                {
                    c.ReadFromDevice(client);
                }
                foreach (var h in data.HoldingRegisters)
                {
                    h.ReadFromDevice(client);
                }
                bindingSourceCoil.ResetBindings(false);
                bindingSourceHoldingRegister.ResetBindings(false);
                dataGridViewHoldingRegister.Update();
                dataGridViewCoil.Update();
            });
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            using (FormModbusMonitorOption o = new FormModbusMonitorOption())
            {

                o.OptionData = data;

                if (o.ShowDialog() == DialogResult.OK)
                {                    
                    this.timer1.Interval = data.RefreshInterval;
                    //bindingSourceCoil.ResetBindings(false);
                    //bindingSourceHoldingRegister.ResetBindings(false);
                    dataGridViewHoldingRegister.Update();
                    dataGridViewCoil.Update();
                }
            }
        }

        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        
        private void btnStopMonitor_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
