using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace EasyModbusClientExample
{

    public enum ModbusConnectionType
    {
        Ethernet,
        UDP,
    }

    public class ModbusTcpClient : ModbusClient
    {
        private string ipAddress = "127.0.0.1";
        private int port = 502;
        private TcpClient tcpClient;
        NetworkStream stream;

        /// <summary>
        /// Constructor which determines the Master ip-address and the Master Port.
        /// </summary>
        /// <param name="ipAddress">IP-Address of the Master device</param>
        /// <param name="port">Listening port of the Master device (should be 502)</param>
        public ModbusTcpClient(string ipAddress, int port)
        {

#if (!COMMERCIAL)
            Console.WriteLine("EasyModbus Client Library Version: " +
                              Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("Copyright (c) Stefan Rossmann Engineering Solutions");
            Console.WriteLine();
#endif
            this.ipAddress = ipAddress;
            this.port = port;
        }

        /// <summary>
        /// Gets or Sets the IP-Address of the Server.
        /// </summary>
        public string IPAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

        /// <summary>
        /// Gets or Sets the Port were the Modbus-TCP Server is reachable (Standard is 502).
        /// </summary>
        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public override void Connect()
        {

            Connect(this.IPAddress, this.Port);


        }
        /// <summary>
        /// Establish connection to Master device in case of Modbus TCP.
        /// </summary>
        public void Connect(string ipAddress, int port)
        {
            tcpClient = new TcpClient();
            var result = tcpClient.BeginConnect(ipAddress, port, null, null);
            var success = result.AsyncWaitHandle.WaitOne(ConnectionTimeout);
            if (!success)
            {
                throw new EasyModbus.Exceptions.ConnectionException("connection timed out");
            }

            tcpClient.EndConnect(result);

            //tcpClient = new TcpClient(ipAddress, port);
            stream = tcpClient.GetStream();
            stream.ReadTimeout = ConnectionTimeout;
            Connected = true;

            OnConnectChanged(this);
        }
        public override void Disconnect()
        {
            stream?.Close();
            tcpClient?.Close();
            base.Disconnect();
        }
        ~ModbusTcpClient()
        {
            stream?.Close();
            tcpClient?.Close();
        }

        public bool Available(int timeout)
        {
            // Ping's the local machine.
            System.Net.NetworkInformation.Ping pingSender = new System.Net.NetworkInformation.Ping();
            var address = System.Net.IPAddress.Parse(ipAddress);

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(data);

            // Wait 10 seconds for a reply.
            System.Net.NetworkInformation.PingReply reply = pingSender.Send(address, timeout, buffer);

            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                return true;
            else
                return false;
        }

        public override bool[] ReadCoils(int startingAddress, int quantity)
        {
            if (tcpClient == null)
            {
                throw new EasyModbus.Exceptions.ConnectionException("connection error");
            }

            byte[] data = PrepareSendingData(0x01, startingAddress, quantity);

            if (tcpClient.Client.Connected)
            {
                if (udpFlag)
                {
                    UdpClient udpClient = new UdpClient();
                    IPEndPoint endPoint = new IPEndPoint(System.Net.IPAddress.Parse(ipAddress), port);
                    udpClient.Send(data, data.Length - 2, endPoint);
                    portOut = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;
                    udpClient.Client.ReceiveTimeout = 5000;
                    endPoint = new IPEndPoint(System.Net.IPAddress.Parse(ipAddress), portOut);
                    data = udpClient.Receive(ref endPoint);
                }
                else
                {
                    stream.Write(data, 0, data.Length - 2);
                    if (debug)
                    {
                        byte[] debugData = new byte[data.Length - 2];
                        Array.Copy(data, 0, debugData, 0, data.Length - 2);
                        if (debug)
                            StoreLogData.Instance.Store("Send MocbusTCP-Data: " + BitConverter.ToString(debugData),
                                System.DateTime.Now);
                    }

                    if (SendDataChanged != null)
                    {
                        sendData = new byte[data.Length - 2];
                        Array.Copy(data, 0, sendData, 0, data.Length - 2);
                        SendDataChanged(this);
                    }

                    data = new Byte[2100];
                    int NumberOfBytes = stream.Read(data, 0, data.Length);
                    if (ReceiveDataChanged != null)
                    {
                        receiveData = new byte[NumberOfBytes];
                        Array.Copy(data, 0, receiveData, 0, NumberOfBytes);
                        if (debug)
                            StoreLogData.Instance.Store("Receive ModbusTCP-Data: " + BitConverter.ToString(receiveData),
                                System.DateTime.Now);
                        ReceiveDataChanged(this);
                    }
                }
            }

            return base.ReadCoils(startingAddress, quantity);
        }
    }
}
