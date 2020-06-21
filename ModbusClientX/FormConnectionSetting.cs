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
using EasyModbus;
using Newtonsoft.Json;

namespace ModbusClientX
{
    public partial class FormConnectionSetting : Form
    {
        public FormConnectionSetting(ModbusClient tcpClient)
        {
            InitializeComponent();
            client = tcpClient;
        }

        ModbusClient client
        {
            get => this.propertyGrid1.SelectedObject as ModbusClient;
            set => this.propertyGrid1.SelectedObject = value;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                client.Disconnect();
            }
            //if (v.ConnectionType == ModbusConnectionType.Ethernet)
            //{
            //    v.SerialPort = null;
            //}

            //else
            //{
            //    if (v.SerialPort == null)
            //    {
            //        throw new Exception("Serial port should not be null");
            //    }
            //}
            try
            {
                client.Connect();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTCP.Checked)
            {
                client.SerialPort = null;
                if (client.IPAddress == null)
                {
                    //client.IPAddress = "192.168.1.X";
                }
            }
            else if (radioButtonRTU.Checked )
            {
                if(client.SerialPort == null) client.SerialPort = "COM1";
                client.IPAddress = null;
            }
            this.propertyGrid1.Refresh();
        }

        private void SaveModbusClientParameters()
        {
            // Save Setting parameters
            string json = JsonConvert.SerializeObject(client);
            string path = Application.StartupPath + @"\config.json";
            File.WriteAllText(path, json);
        }
        private void LoadModbusClientParameters()
        {
            // Load Setting parameters
            string path = Application.StartupPath + @"\config.json";
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                JsonConvert.PopulateObject(json, this.client);
                if (this.client.SerialPort != null && client.SerialPort.Length >2)
                {
                    this.radioButtonRTU.Checked = true;
                }
                else
                {
                    this.radioButtonTCP.Checked = true;
                }
            }
        }

        private void FormConnectionSetting_Load(object sender, EventArgs e)
        {
            LoadModbusClientParameters();
        }

        private void FormConnectionSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveModbusClientParameters();
        }
    }
}
