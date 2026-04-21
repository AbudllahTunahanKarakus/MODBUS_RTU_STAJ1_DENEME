using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Deneme2
{

    public partial class Form1 : Form
    {
        private bool isRunning = false;
        private ModbusClient modbusClient;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDataGonder_Click(object sender, EventArgs e)
        {
            isRunning = true;
            btnDataGonder.Enabled = false;

            modbusClient = new ModbusClient("Tuna", 502);
            modbusClient.Connect();

            string connectionString =
                "Data Source=TUNA; Initial Catalog=DENEME; Integrated Security=True;";

            while (isRunning)
            {
                int[] readHoldingRegisters =
                    modbusClient.ReadHoldingRegisters(0, 2);

                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(
                    "INSERT INTO KAYITLAR (Register1, Register2) VALUES (@Register1, @Register2)",
                    connection))
                {
                    command.Parameters.Add("@Register1", SqlDbType.Int).Value = readHoldingRegisters[0];
                    command.Parameters.Add("@Register2", SqlDbType.Int).Value = readHoldingRegisters[1];

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }

                await Task.Delay(5000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isRunning = false;
            btnDataGonder.Enabled = true;

            if (modbusClient != null && modbusClient.Connected)
                modbusClient.Disconnect();
        }
    }
}

