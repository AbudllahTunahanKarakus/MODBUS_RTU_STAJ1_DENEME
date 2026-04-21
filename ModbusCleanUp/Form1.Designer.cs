namespace ModbusCleanUp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtBaudrate = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.timerRead = new System.Windows.Forms.Timer(this.components);
            this.txtVal01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVal02 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVal03 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVal4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVal5 = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblVal1 = new System.Windows.Forms.Label();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBaudrate
            // 
            this.txtBaudrate.Location = new System.Drawing.Point(350, 103);
            this.txtBaudrate.Name = "txtBaudrate";
            this.txtBaudrate.Size = new System.Drawing.Size(100, 20);
            this.txtBaudrate.TabIndex = 0;
            this.txtBaudrate.Text = "9600";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(350, 41);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "COM2";
            this.txtPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(350, 149);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connected";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(350, 178);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 3;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 344);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(329, 134);
            this.listBoxLog.TabIndex = 4;
            // 
            // timerRead
            // 
            this.timerRead.Interval = 1000;
            this.timerRead.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtVal01
            // 
            this.txtVal01.Location = new System.Drawing.Point(628, 54);
            this.txtVal01.Name = "txtVal01";
            this.txtVal01.Size = new System.Drawing.Size(100, 20);
            this.txtVal01.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUDRATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Values1";
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(79, 45);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(100, 20);
            this.txtStartAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "StartAdress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Values2";
            // 
            // txtVal02
            // 
            this.txtVal02.Location = new System.Drawing.Point(628, 91);
            this.txtVal02.Name = "txtVal02";
            this.txtVal02.Size = new System.Drawing.Size(100, 20);
            this.txtVal02.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(535, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Values3";
            // 
            // txtVal03
            // 
            this.txtVal03.Location = new System.Drawing.Point(628, 130);
            this.txtVal03.Name = "txtVal03";
            this.txtVal03.Size = new System.Drawing.Size(100, 20);
            this.txtVal03.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(535, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Values4";
            // 
            // txtVal4
            // 
            this.txtVal4.Location = new System.Drawing.Point(628, 171);
            this.txtVal4.Name = "txtVal4";
            this.txtVal4.Size = new System.Drawing.Size(100, 20);
            this.txtVal4.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Values5";
            // 
            // txtVal5
            // 
            this.txtVal5.Location = new System.Drawing.Point(628, 214);
            this.txtVal5.Name = "txtVal5";
            this.txtVal5.Size = new System.Drawing.Size(100, 20);
            this.txtVal5.TabIndex = 17;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(505, 344);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 19;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblVal1
            // 
            this.lblVal1.AutoSize = true;
            this.lblVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVal1.Location = new System.Drawing.Point(605, 344);
            this.lblVal1.Name = "lblVal1";
            this.lblVal1.Size = new System.Drawing.Size(30, 31);
            this.lblVal1.TabIndex = 20;
            this.lblVal1.Text = "0";
            // 
            // lblVal2
            // 
            this.lblVal2.AutoSize = true;
            this.lblVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVal2.Location = new System.Drawing.Point(665, 344);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(30, 31);
            this.lblVal2.TabIndex = 21;
            this.lblVal2.Text = "0";
            // 
            // lblVal3
            // 
            this.lblVal3.AutoSize = true;
            this.lblVal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVal3.Location = new System.Drawing.Point(726, 344);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(30, 31);
            this.lblVal3.TabIndex = 22;
            this.lblVal3.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 536);
            this.Controls.Add(this.lblVal3);
            this.Controls.Add(this.lblVal2);
            this.Controls.Add(this.lblVal1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtVal5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVal4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVal03);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVal02);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStartAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVal01);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtBaudrate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaudrate;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Timer timerRead;
        private System.Windows.Forms.TextBox txtVal01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVal02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVal03;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVal4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVal5;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblVal1;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal3;
    }
}

