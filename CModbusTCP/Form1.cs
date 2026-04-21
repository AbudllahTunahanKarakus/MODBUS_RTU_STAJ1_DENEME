using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using EasyModbus;

namespace CModbusTCP
{
    public partial class Form1 : Form
    {
        ModbusClient ModClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click_Click(object sender, EventArgs e)
        {
            ModClient = new ModbusClient();
            ModClient.IPAddress=txtIp.Text;
            ModClient.Port =int.Parse(txtPort.Text);
            try 
            {
                ModClient.Connect();
                lblStatus.Text = "Connect";
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                grpRw.Enabled = true;
            }
            catch(Exception ex) 
            {
                lblStatus.Text = "Error! " + ex.ToString();
            }


        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ModClient.Disconnect();
            lblStatus.Text = "Disconnect";
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            grpRw.Enabled = false;

        }

        private void btnReadHolding_Click(object sender, EventArgs e)
        {
            int [] vals;
            vals = ModClient.ReadHoldingRegisters(int.Parse(txtRegister.Text),1);
            txtValue.Text = vals[0].ToString();
        }

        private void btnReadAnalog_Click(object sender, EventArgs e)
        {
            int[] vals;
            vals = ModClient.ReadInputRegisters(int.Parse(txtRegister.Text), 1);
            txtValue.Text = vals[0].ToString();
        }

        private void btnReadCoil_Click(object sender, EventArgs e)
        {
            bool [] vals;
            vals = ModClient.ReadDiscreteInputs(int.Parse(txtRegister.Text), 1);
            txtValue.Text = vals[0].ToString();
        }

        private void btnReadDigital_Click(object sender, EventArgs e)
        {
            bool [] vals;
            vals = ModClient.ReadDiscreteInputs(int.Parse(txtRegister.Text), 1);
            txtValue.Text= vals[0].ToString();
        }

        private void btnWriteHolding_Click(object sender, EventArgs e)
        {
            ModClient.WriteSingleRegister(int.Parse(txtRegister.Text), int.Parse(txtValue.Text));
        }
       
        private void btnWriteCoil_Click(object sender, EventArgs e)
        {
            ModClient.WriteSingleCoil(int.Parse(txtRegister.Text), bool.Parse(txtValue.Text));
        }
    }
}
