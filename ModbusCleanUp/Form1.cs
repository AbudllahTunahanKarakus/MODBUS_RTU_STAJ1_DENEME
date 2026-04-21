using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModbusCleanUp.Comminacition;
using ModbusCleanUp.Logging;
using EasyModbus;

namespace ModbusCleanUp
{
    
    public partial class Form1 : Form
    {
        private int[] previousValues = new int[3];
        private bool firstRead=true;
        ModbusServis modbus = new ModbusServis();
        private void AddLog(string message, string type = "INFO")
        {
            string log = LogManager.Create(message, type);
            listBoxLog.Items.Add(log);
            listBoxLog.TopIndex=listBoxLog.Items.Count-1;

            if (listBoxLog.Items.Count > 200)
                listBoxLog.Items.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if(!modbus.IsConnected)
                {
                    lblVal1.ForeColor = Color.Red;
                    lblVal2.ForeColor = Color.Red;
                    lblVal3.ForeColor = Color.Red;
                    timerRead.Start();
                    AddLog("BAĞLANTI KOPTU", "ERROR");
                    return;
                }
                byte slaveId = 1;
                int startAddress = int.Parse(txtStartAddress.Text);
                int quantity = 3;

                int [] values= modbus.ReadRegisters(slaveId, startAddress, quantity);
                Label[] labels = { lblVal1, lblVal2, lblVal3 };
                for(int i=0;i<values.Length;i++)
                {
                    labels[i].Text = values[i].ToString();
                    if(!firstRead &&previousValues[i] != values[i])
                    {
                        labels[i].ForeColor= Color.Green;
                    }
                    else
                    {
                        labels[i].ForeColor= Color.Black;
                    }
                    previousValues[i] = values[i];
                }
            }
            catch (Exception ex)
            {
                timerRead.Stop();
                AddLog("Okuma HAtalıu: " + ex.Message, "ERROR");
            }
        
        }
            




            /*if(modbus.IsConnected)
            {
                var data = modbus.ReadHolding(1, 0, 3);
                if (data != null)
                    AddLog("Read OK");
            }
            */
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!modbus.IsConnected)
                {
                    modbus.Connect(txtPort.Text, int.Parse(txtBaudrate.Text));
                    AddLog("Bağlandı", "SUCCESS");
                }
                else
                {
                    modbus.Disconnect();
                    AddLog("Bağlantı Kesildi", "INFO");
                }
            }
            catch (Exception ex)
            {
                AddLog("Bağlantı HATASI: " + ex.Message, "ERROR");
            }
        }

        public void btnWrite_Click(object sender, EventArgs e)
        {
            if(modbus.IsConnected)
            {
                try
                {
                    byte slaveId = 1;
                    int startAddress = int.Parse(txtStartAddress.Text);

                    List<int> valueList = this.Controls.OfType<TextBox>().Where(t => t.Name.StartsWith("txtVal") &&
                    !string.IsNullOrWhiteSpace(t.Text)).
                    OrderBy(t => t.Name).
                    Select(t => int.Parse(t.Text)).
                    ToList();

                    if (valueList.Count == 0)
                    {
                        MessageBox.Show("Yazılcak değer yok!");
                        return;
                    }
                    int[] values = valueList.ToArray();
                    bool result = modbus.WriteAndVerify(slaveId, startAddress, values);
                    if (result)
                        AddLog("Dinamik Multi Write Başarılı", "SUCCESS");
                    else
                        AddLog("Doğrulama HATASI", "ERROR");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: " + ex.Message);
                }

            }
            else
            {
                AddLog("Bağlantı Olmadığı için Write Başarısız");
            }






            //--Coklu YAZIM AMA BOS kontrolu yok
            /*
            try
            {
                byte slaveId = 1;
                int startAddress = int.Parse(txtStartAddress.Text);

                int val1 = int.Parse(txtVal1.Text);
                int val2 = int.Parse(txtVal2.Text);
                int val3 = int.Parse(txtVal3.Text);


                int[] values = new int[] { val1,val2,val3 };

                bool result = modbus.WriteAndVerify(slaveId, startAddress, values);

                if (result)
                    AddLog("Write doğrulandı", "SUCCESS");
                else
                    AddLog("Write başarısız", "ERROR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form HATASI: "+ex.Message);
            }
            */
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                byte slaveId = 1;
                int startAddress = int.Parse(txtStartAddress.Text);

                int[] values = modbus.ReadRegisters(1, startAddress, 3);
                if (values != null) 
                {
                    lblVal1.Text = values[0].ToString();
                    lblVal2.Text = values[1].ToString();
                    lblVal3.Text = values[2].ToString();
                }
                else 
                {
                    AddLog("HATAAA");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Read HATASI" + ex.Message);
            }
        }
    }
}
