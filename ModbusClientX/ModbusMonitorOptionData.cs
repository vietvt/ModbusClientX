using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using EasyModbus;

namespace ModbusClientX
{
    internal class ModbusMonitorOptionData : INotifyPropertyChanged
    {
        Timer timer = new Timer();
        private string holdingRegisterString;
        private string coilString;
        internal ModbusMonitorOptionData()
        {
            
        }

        

        [Description("Input the Holding Register decimal addresses, separated by commas, space, | or /")]
        public string HoldingRegisterString { get => holdingRegisterString;
            set { holdingRegisterString = value;
                NotifyPropertyChanged();
            }
        }

        [Description("Input the Coil decimal addresses, separated by commas, space, | or /")]
        public string CoilString { get => coilString; 
            set
            {
                coilString = value;
                NotifyPropertyChanged();
            }
        }
        [Description("Indicate how often the program send read command (ms)")]
        public int RefreshInterval { get; set; } = 1000;

        internal List<HoldingRegister> HoldingRegisters { get; } = new List<HoldingRegister>();
        internal List<Coil> Coils { get; } = new List<Coil>();

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        internal void PopulateList()
        {
            HoldingRegisters.Clear();
            Coils.Clear();
            try
            {
                if (holdingRegisterString != null && holdingRegisterString.Length >0)
                {
                    var a = HoldingRegisterString.Split(char.Parse(","), char.Parse("/"), char.Parse(" "), char.Parse("|"));
                    a = a.Distinct().ToArray();
                    var arr = Array.ConvertAll(a, int.Parse).OrderBy(aa=>aa).ToArray();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        HoldingRegisters.Add(new HoldingRegister() { Address = arr[i]});
                    }
                }
                if (coilString != null && coilString.Length > 0)
                {
                    var a = coilString.Split(char.Parse(","), char.Parse("/"), char.Parse(" "), char.Parse("|"));
                    a = a.Distinct().ToArray();
                    var arr = Array.ConvertAll(a, int.Parse).OrderBy(aa => aa).ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        Coils.Add(new Coil() { Address = arr[i]});
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
