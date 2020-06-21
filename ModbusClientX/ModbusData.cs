using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusClientX
{
    public abstract class ModbusData : INotifyPropertyChanged
    {
        private int adress;
        private bool hasChanged;

        [Description("Memory Adress")]
        [ReadOnly(true)]
        [Category("Index")]
        public int Address { get => adress; set { adress = value; } }
        [Category("Index")]

        [Description("Memory Adress (Hexadecimal)")]
        public string AdressHex => IntToHex(Address);

        /// <summary>
        /// the original value, if cancel change command is called, then this value is restored
        /// </summary>
        [Browsable(false)]
        protected object OldValue { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.  
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            HasChanged = true;
        }
        protected string IntToHex(int i)
        {
            return i.ToString("X");
        }

        protected string IntToBin(int i)
        {
            String output = Convert.ToString(i, 2).PadLeft(16, char.Parse("0"));
            return output;
        }

        /// <summary>
        /// Send modbus write command
        /// </summary>
        /// <param name="client"></param>
        public virtual void WriteToDevice(EasyModbus.ModbusClient client)
        {

        }

        /// <summary>
        /// Send modbus read command
        /// </summary>
        /// <param name="client"></param>
        public virtual void ReadFromDevice(ModbusClient client)
        {

        }

        /// <summary>
        /// Cancel all changes and restore original values of the object
        /// </summary>
        public virtual void CancelChange()
        {

        }

        [Browsable(false)]
        internal bool HasChanged
        {
            get => hasChanged;
            set { hasChanged = value; ObjectHasChanged?.Invoke(this, null); }
        }
        public event EventHandler ObjectHasChanged;
    }

    public class Coil : ModbusData
    {
        private bool coil;
        [Category("Coil")]
        //[ReadOnly(true)]
        [Description("Coil value")]
        public bool CoilValue { get => coil; set {
                OldValue = coil;
                coil = value; NotifyPropertyChanged("CoilValue"); } 
        }

        public override void WriteToDevice(ModbusClient client)
        {
            if (HasChanged)
            {
                client.WriteSingleCoil(this.Address, CoilValue);
                HasChanged = false;
            }
        }
        public override void ReadFromDevice(ModbusClient client)
        {
            var v = client.ReadCoils(Address, 1);
            if (v!= null)
            {
                CoilValue = v.FirstOrDefault();
            }
        }
        public override void CancelChange()
        {
            CoilValue = (bool)OldValue;
            HasChanged = false;
        }
    }
    public class DiscreteInput : ModbusData
    {
        private bool coil;
        [Category("DiscreteInput")]
        [Description("Discrete input")]
        [ReadOnly(true)]
        public bool DiscreteInputValue { get => coil; set { coil = value; NotifyPropertyChanged("DiscreteInputValue"); } }

        public override void ReadFromDevice(ModbusClient client)
        {
            var v = client.ReadDiscreteInputs(Address, 1);
            if (v != null)
            {
                DiscreteInputValue = v.FirstOrDefault();
            }
        }

    }
    public class InputRegister : ModbusData
    {
        private int inputRegister;
        
        [Category("Input Register")]
        [ReadOnly(true)]
        [Description("Input Register Decimal Format")]
        public int InputRegisterDec { get => inputRegister; set { inputRegister = value; NotifyPropertyChanged("InputRegisterDec"); } }

        [Category("Input Register")]
        [Description("Input Register HexaDecimal Format")]
        public string InputRegisterHex => IntToHex(InputRegisterDec);
        [Category("Input Register")]
        [Description("Input Register Binary Format")]
        public string InputRegisterBin => IntToBin(InputRegisterDec);

        public override void ReadFromDevice(ModbusClient client)
        {
            var v = client.ReadInputRegisters(Address, 1);
            if (v != null)
            {
                InputRegisterDec = v.FirstOrDefault();
            }
        }

    }
    public class HoldingRegister : ModbusData
    {
        private int holdingRegister;

        //[ReadOnly(true)]
        [Category("Holding Register")]
        [Description("Holding Register Decimal Format")]
        public int HoldingRegisterDec
        {
            get => holdingRegister; 
            set
            {
                OldValue = holdingRegister;
                holdingRegister = value;
                NotifyPropertyChanged("HoldingRegisterDec");                
            }
        }
        [Category("Holding Register")]
        [Description("Holding Register HexaDecimal Format")]
        public string HoldingRegisterHex => IntToHex(HoldingRegisterDec);
        [Category("Holding Register")]
        [Description("Holding Register Binary Format")]
        public string HoldingRegisterBin => IntToBin(HoldingRegisterDec);
        public override void WriteToDevice(ModbusClient client)
        {
            if (HasChanged)
            {
                client.WriteSingleRegister(this.Address, HoldingRegisterDec);
                HasChanged = false;
            }
        }

        public override void ReadFromDevice(ModbusClient client)
        {
            var v = client.ReadHoldingRegisters(this.Address, 1);
            if (v!= null)
            {
                this.HoldingRegisterDec = v.FirstOrDefault();
            }

        }
        public override void CancelChange()
        {
            HoldingRegisterDec = (int)OldValue;
            HasChanged = false;
        }
    }

    internal static class ModbusDataCollectionService
    {
        static ModbusDataCollectionService()
        {
            for (int i = 0; i < UInt16.MaxValue; i++)
            {
                Coil c = new Coil() { Address = i };
                Coils.Add(c);

                InputRegister ir = new InputRegister() { Address = i };
                InputRegisters.Add(ir);

                HoldingRegister hr = new HoldingRegister() { Address = i };
                HoldingRegisters.Add(hr);

                DiscreteInput discrete = new DiscreteInput() { Address = i };
                DiscreteInputs.Add(discrete);
            }
        }

        public static IList<Coil> Coils { get; } = new List<Coil>();
        public static IList<DiscreteInput> DiscreteInputs { get; } = new List<DiscreteInput>();
        public static IList<InputRegister> InputRegisters { get; } = new List<InputRegister>();
        public static IList<HoldingRegister> HoldingRegisters { get; } = new List<HoldingRegister>();

        public static void ReadCoils(ModbusClient client, int startAddress, int numberOfValues)
        {
            var v = client.ReadCoils(startAddress, numberOfValues);
            if (v!= null)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    Coils[startAddress + i].CoilValue = v[i];
                    Coils[startAddress + i].HasChanged = false;
                }
            }
        }

        public static void ReadDiscreteInputs(ModbusClient client, int startAddress, int numberOfValues)
        {
            var v = client.ReadDiscreteInputs(startAddress, numberOfValues);
            if (v != null)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    DiscreteInputs[startAddress + i].DiscreteInputValue = v[i];
                    DiscreteInputs[startAddress + i].HasChanged = false;
                }
            }
        }

        public static void ReadInputRegisters(ModbusClient client, int startAddress, int numberOfValues)
        {
            var v = client.ReadInputRegisters(startAddress, numberOfValues);
            if (v != null)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    InputRegisters[startAddress + i].InputRegisterDec = v[i];
                    InputRegisters[startAddress + i].HasChanged = false;
                }
            }
        }

        public static void ReadHoldingRegisters(ModbusClient client, int startAddress, int numberOfValues)
        {
            var v = client.ReadHoldingRegisters(startAddress, numberOfValues);
            if (v != null)
            {
                for (int i = 0; i < v.Length; i++)
                {
                    HoldingRegisters[startAddress + i].HoldingRegisterDec = v[i];
                    HoldingRegisters[startAddress + i].HasChanged = false;
                }
            }
        }

        /// <summary>
        /// write all unchange adresses to device, one by one
        /// </summary>
        /// <param name="client"></param>
        public static void WriteAllChanges(ModbusClient client)
        {
            for (int i = 0; i < Coils.Count; i++)
            {
                var v = Coils[i];
                if (v.HasChanged)
                {
                    v.WriteToDevice(client);
                    Application.DoEvents();
                }
            }
            for (int i = 0; i < HoldingRegisters.Count; i++)
            {
                var v = HoldingRegisters[i];
                if (v.HasChanged)
                {
                    v.WriteToDevice(client);
                    Application.DoEvents();
                }
            }
        }

        public static void CancelChanges(ModbusClient client)
        {
            for (int i = 0; i < HoldingRegisters.Count; i++)
            {
                var v = HoldingRegisters[i];
                if (v.HasChanged)
                {
                    v.CancelChange();
                }
            }
            for (int i = 0; i < Coils.Count; i++)
            {
                var v = Coils[i];
                if (v.HasChanged)
                {
                    v.CancelChange();
                }
            }
        }

    }
    
}
