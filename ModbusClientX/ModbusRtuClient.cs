using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace EasyModbusClientExample
{
    public class ModbusRtuClient: ModbusClient
    {
        private int baudRate = 9600;
        private int connectTimeout = 1000;

        private SerialPort serialport;
        private Parity parity = Parity.Even;
        private StopBits stopBits = StopBits.One;

        /// <summary>
        /// Constructor which determines the Serial-Port
        /// </summary>
        /// <param name="serialPort">Serial-Port Name e.G. "COM1"</param>
        public ModbusRtuClient(string serialPort)
        {
            
#if (!COMMERCIAL)
            Console.WriteLine("EasyModbus Client Library Version: " +
                              Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("Copyright (c) Stefan Rossmann Engineering Solutions");
            Console.WriteLine();
#endif
            this.serialport = new SerialPort();
            serialport.PortName = serialPort;
            serialport.BaudRate = baudRate;
            serialport.Parity = parity;
            serialport.StopBits = stopBits;
            serialport.WriteTimeout = 10000;
            serialport.ReadTimeout = connectTimeout;

            serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender,
            SerialDataReceivedEventArgs e)
        {
            serialport.DataReceived -= DataReceivedHandler;

            //while (receiveActive | dataReceived)
            //	System.Threading.Thread.Sleep(10);
            receiveActive = true;

            const long ticksWait = TimeSpan.TicksPerMillisecond * 2000; //((40*10000000) / this.baudRate);


            SerialPort sp = (SerialPort)sender;
            if (bytesToRead == 0)
            {
                sp.DiscardInBuffer();
                receiveActive = false;
                serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                return;
            }

            readBuffer = new byte[256];
            int numbytes = 0;
            int actualPositionToRead = 0;
            DateTime dateTimeLastRead = DateTime.Now;
            do
            {
                try
                {
                    dateTimeLastRead = DateTime.Now;
                    while ((sp.BytesToRead) == 0)
                    {
                        System.Threading.Thread.Sleep(10);
                        if ((DateTime.Now.Ticks - dateTimeLastRead.Ticks) > ticksWait)
                            break;
                    }

                    numbytes = sp.BytesToRead;


                    byte[] rxbytearray = new byte[numbytes];
                    sp.Read(rxbytearray, 0, numbytes);
                    Array.Copy(rxbytearray, 0, readBuffer, actualPositionToRead,
                        (actualPositionToRead + rxbytearray.Length) <= bytesToRead
                            ? rxbytearray.Length
                            : bytesToRead - actualPositionToRead);

                    actualPositionToRead = actualPositionToRead + rxbytearray.Length;
                }
                catch (Exception)
                {
                }

                if (bytesToRead <= actualPositionToRead)
                    break;

                if (DetectValidModbusFrame(readBuffer,
                        (actualPositionToRead < readBuffer.Length) ? actualPositionToRead : readBuffer.Length) |
                    bytesToRead <= actualPositionToRead)
                    break;
            } while ((DateTime.Now.Ticks - dateTimeLastRead.Ticks) < ticksWait);

            //10.000 Ticks in 1 ms

            receiveData = new byte[actualPositionToRead];
            Array.Copy(readBuffer, 0, receiveData, 0,
                (actualPositionToRead < readBuffer.Length) ? actualPositionToRead : readBuffer.Length);
            
            bytesToRead = 0;


            dataReceived = true;
            receiveActive = false;
            serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            OnReceiveDataChanged(this);

            //sp.DiscardInBuffer();
        }


        /// <summary>
        /// Establish connection to Master device in case of Modbus TCP. Opens COM-Port in case of Modbus RTU
        /// </summary>
        public override void Connect()
        {
            if (serialport != null)
            {
                if (!serialport.IsOpen)
                {
                    serialport.BaudRate = baudRate;
                    serialport.Parity = parity;
                    serialport.StopBits = stopBits;
                    serialport.WriteTimeout = 10000;
                    serialport.ReadTimeout = connectTimeout;
                    serialport.Open();
                    Connected = true;
                }

                OnConnectChanged(this);

                return;
            }

            
        }

        public override void Disconnect()
        {
            if (serialport != null)
            {
                if (serialport.IsOpen & !this.receiveActive)
                    serialport.Close();
                OnConnectChanged(this);
                return;
            }

            
            base.Disconnect();
        }
        ~ModbusRtuClient()
        {
            if (serialport != null)
            {
                if (serialport.IsOpen)
                    serialport.Close();
                return;
            }

        }

        public override bool[] ReadCoils(int startingAddress, int quantity)
        {
            if (serialport != null)
                if (!serialport.IsOpen)
                {
                    throw new EasyModbus.Exceptions.SerialPortNotOpenedException("serial port not opened");
                }

            byte[] data = PrepareSendingData(0x01, startingAddress, quantity);

            if (serialport != null)
            {
                dataReceived = false;
                if (quantity % 8 == 0)
                    bytesToRead = 5 + quantity / 8;
                else
                    bytesToRead = 6 + quantity / 8;
                //               serialport.ReceivedBytesThreshold = bytesToRead;
                serialport.Write(data, 6, 8);
                

                   sendData = new byte[8];
                    Array.Copy(data, 6, sendData, 0, 8);
                    OnSendDataChanged(this);
                

                data = new byte[2100];
                readBuffer = new byte[256];
                DateTime dateTimeSend = DateTime.Now;
                byte receivedUnitIdentifier = 0xFF;
                while (receivedUnitIdentifier != this.UnitIdentifier &
                       !((DateTime.Now.Ticks - dateTimeSend.Ticks) >
                         TimeSpan.TicksPerMillisecond * this.connectTimeout))
                {
                    while (dataReceived == false & !((DateTime.Now.Ticks - dateTimeSend.Ticks) >
                                                     TimeSpan.TicksPerMillisecond * this.connectTimeout))
                        System.Threading.Thread.Sleep(1);
                    data = new byte[2100];

                    Array.Copy(readBuffer, 0, data, 6, readBuffer.Length);
                    receivedUnitIdentifier = data[6];
                }

                if (receivedUnitIdentifier != this.UnitIdentifier)
                    data = new byte[2100];
                else
                    countRetries = 0;
            }

            return base.ReadCoils(startingAddress, quantity);
        }
    }
}
