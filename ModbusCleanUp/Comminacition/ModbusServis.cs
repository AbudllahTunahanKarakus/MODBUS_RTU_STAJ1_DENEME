using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using EasyModbus;

namespace ModbusCleanUp.Comminacition
{
    public class ModbusServis
    {
        public ModbusClient client;
        private bool isWriting = false;
        private int[] values;

        public bool IsConnected => client?.Connected ?? false;

        public ModbusServis()
        {
            client = new ModbusClient("COM2");   // kendi COM portun neyse

            client.Baudrate = 9600;
            client.Parity = System.IO.Ports.Parity.None;
            client.StopBits = System.IO.Ports.StopBits.One;
            client.ConnectionTimeout = 1000;
            

        }
        public void Connect(string port,int baudrate)
        {
            client.SerialPort = port;
            client.Baudrate=baudrate;
            client.Connect();
        }
        public void Disconnect() 
        {
            if (client.Connected)
                client.Disconnect();
        }
        public int[] ReadHolding(byte slaveId,int start,int count)
        {
            if (isWriting) return null;
            client.UnitIdentifier = slaveId;
            return client.ReadHoldingRegisters(start, count);
        }
        public bool WriteAndVerify(byte slaveId, int start, int[] values)
        {
            try
            {
                if (!client.Connected)
                    client.Connect();

                client.UnitIdentifier = slaveId;

                client.WriteMultipleRegisters(start, values);

                int[] read = client.ReadHoldingRegisters(start, values.Length);

                return values.SequenceEqual(read);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modbus Hatası: " + ex.Message);
                return false;
            }
        }
        public int[] ReadRegisters(byte slaveId, int start, int count)
        {
            try
            {
                if (!client.Connected)
                    client.Connect();

                client.UnitIdentifier = slaveId;

                return client.ReadHoldingRegisters(start, count);
            }
            catch
            {
                return null;
            }
        }


    }
}
