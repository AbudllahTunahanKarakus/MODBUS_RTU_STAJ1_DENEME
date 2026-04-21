using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using EasyModbus.Exceptions;
namespace Deneme1
{
    public partial class Form1 : Form
    {
        ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBaglantıAc_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient = new ModbusClient(txtServerIpAdres.Text,port:502);
                modbusClient.Connect();
                lblBaglantıDurumu.Text = "Bağlantı Açıldı";
                tmrModbusTcpIp.Enabled = true;//tımerı başlattık 
            }
            catch (Exception ex)
            {
                lblBaglantıDurumu.Text = ex.ToString(); 
            }


            
        }

        private void btnBaglantıKapat_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
            lblBaglantıDurumu.Text = "Bağlantı Kapalı";
            tmrModbusTcpIp.Enabled = false;
        }

        private void tmrModbusTcpIp_Tick(object sender, EventArgs e)
        {

            modbusClient.WriteSingleCoil(startingAddress: 0, chcTrue0.Checked);
            modbusClient.WriteSingleCoil(startingAddress: 1, chcTrue1.Checked);
            modbusClient.WriteSingleCoil(startingAddress: 2, chcTrue2.Checked);
            modbusClient.WriteSingleCoil(startingAddress: 3, chcTrue3.Checked);
            modbusClient.WriteSingleCoil(startingAddress: 4, chcTrue4.Checked);
            modbusClient.WriteSingleCoil(startingAddress: 5, chcTrue5.Checked);




            /* modbusClient.WriteSingleCoil(startingAddress:0,true);
            modbusClient.WriteSingleCoil(startingAddress: 3, true);
            modbusClient.WriteMultipleCoils(startingAddress: 4, values:new[] { false, true, true, false });


            modbusClient.WriteSingleRegister(startingAddress: 0, 31);
            modbusClient.WriteMultipleRegisters(startingAddress: 6, values: new[] { 12, 13, 14, 15 });
            */




            /*tmrModbusTcpIp.Enabled = false;
            int[] readHoldingRegister= modbusClient.ReadHoldingRegisters(startingAddress: 0, quantity: 8);
            bool[] readCoils = modbusClient.ReadCoils(startingAddress: 0, quantity: 8);
            txtHoldingRegister0.Text = readHoldingRegister[0].ToString();
            txtHoldingRegister1.Text = readHoldingRegister[1].ToString();
            txtHoldingRegister2.Text = readHoldingRegister[2].ToString();
            txtHoldingRegister3.Text = readHoldingRegister[3].ToString();
            txtHoldingRegister4.Text = readHoldingRegister[4].ToString();
            txtHoldingRegister5.Text = readHoldingRegister[5].ToString();
            txtHoldingRegister6.Text = readHoldingRegister[6].ToString();
            txtHoldingRegister7.Text = readHoldingRegister[7].ToString();

            txtCoils0.Text = readCoils[0].ToString();
            txtCoils1.Text = readCoils[1].ToString();
            txtCoils2.Text = readCoils[2].ToString();
            txtCoils3.Text = readCoils[3].ToString();
            txtCoils4.Text = readCoils[4].ToString();
            txtCoils5.Text = readCoils[5].ToString();
            txtCoils6.Text = readCoils[6].ToString();
            txtCoils7.Text = readCoils[7].ToString();

            tmrModbusTcpIp.Enabled= true;*/


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtServerIpAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}
