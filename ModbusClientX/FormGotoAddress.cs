using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusClientX
{
    public partial class FormGotoAddress : Form
    {
        public FormGotoAddress()
        {
            InitializeComponent();
        }

        /// <summary>
        /// selection of address to move to
        /// </summary>
        public int Address
        {
            get => Convert.ToInt32(txtAddress.Text);
            set => txtAddress.Text = value.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
