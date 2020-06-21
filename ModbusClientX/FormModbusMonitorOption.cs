using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ModbusClientX
{
    public partial class FormModbusMonitorOption : Form
    {
        const string DEFAULT_OPTION_FILE = "DefaultModbusOption.json";
        public FormModbusMonitorOption()
        {
            InitializeComponent();            

        }

        internal ModbusMonitorOptionData OptionData
        {
            get => this.propertyGridOption.SelectedObject as ModbusMonitorOptionData;
            set => propertyGridOption.SelectedObject = value;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OptionData.PopulateList();
            this.DialogResult = DialogResult.OK;
            this.Close();
            this.Dispose();
        }

        private void openOptionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                using (StreamReader r = new StreamReader(openFileDialog1.FileName))
                {
                    string json = r.ReadToEnd();
                    JsonConvert.PopulateObject(json, OptionData);
                    this.propertyGridOption.Refresh();
                }
            }
        }

        private void saveOptionFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = JsonConvert.SerializeObject(OptionData);
                System.IO.File.WriteAllText(saveFileDialog1.FileName, json);
                MessageBox.Show("Option file saved");
            }
        }

        private void FormModbusMonitorOption_Load(object sender, EventArgs e)
        {
            var p = Application.StartupPath + @"\" + DEFAULT_OPTION_FILE;
            if (File.Exists(p))
            {
                using (StreamReader r = new StreamReader(p))
                {
                    string json = r.ReadToEnd();
                    JsonConvert.PopulateObject(json, OptionData);
                }
            }
        }

        private void FormModbusMonitorOption_FormClosing(object sender, FormClosingEventArgs e)
        {
            var p = Application.StartupPath + @"\" + DEFAULT_OPTION_FILE;
            string json = JsonConvert.SerializeObject(OptionData);
            System.IO.File.WriteAllText(p, json);
            

        }
    }
}
