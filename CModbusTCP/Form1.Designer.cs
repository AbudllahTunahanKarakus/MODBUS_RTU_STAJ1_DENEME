namespace CModbusTCP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpRw = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegister = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnReadHolding = new System.Windows.Forms.Button();
            this.btnReadAnalog = new System.Windows.Forms.Button();
            this.btnReadCoil = new System.Windows.Forms.Button();
            this.btnReadDigital = new System.Windows.Forms.Button();
            this.btnWriteHolding = new System.Windows.Forms.Button();
            this.btnWriteCoil = new System.Windows.Forms.Button();
            this.grpRw.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(89, 6);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 2;
            this.txtIp.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(89, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "502";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnConnect.Location = new System.Drawing.Point(32, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(122, 37);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDisconnect.Location = new System.Drawing.Point(174, 81);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(117, 37);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(77, 425);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "-";
            // 
            // grpRw
            // 
            this.grpRw.Controls.Add(this.btnWriteCoil);
            this.grpRw.Controls.Add(this.btnWriteHolding);
            this.grpRw.Controls.Add(this.btnReadDigital);
            this.grpRw.Controls.Add(this.btnReadCoil);
            this.grpRw.Controls.Add(this.btnReadAnalog);
            this.grpRw.Controls.Add(this.btnReadHolding);
            this.grpRw.Controls.Add(this.txtValue);
            this.grpRw.Controls.Add(this.txtRegister);
            this.grpRw.Controls.Add(this.label5);
            this.grpRw.Controls.Add(this.label4);
            this.grpRw.Location = new System.Drawing.Point(12, 147);
            this.grpRw.Name = "grpRw";
            this.grpRw.Size = new System.Drawing.Size(602, 260);
            this.grpRw.TabIndex = 8;
            this.grpRw.TabStop = false;
            this.grpRw.Text = "Read/Write";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Register";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Value";
            // 
            // txtRegister
            // 
            this.txtRegister.Location = new System.Drawing.Point(142, 32);
            this.txtRegister.Name = "txtRegister";
            this.txtRegister.Size = new System.Drawing.Size(100, 20);
            this.txtRegister.TabIndex = 2;
            this.txtRegister.Text = "0";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(142, 157);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 3;
            // 
            // btnReadHolding
            // 
            this.btnReadHolding.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadHolding.Location = new System.Drawing.Point(142, 78);
            this.btnReadHolding.Name = "btnReadHolding";
            this.btnReadHolding.Size = new System.Drawing.Size(64, 46);
            this.btnReadHolding.TabIndex = 4;
            this.btnReadHolding.Text = "Read Holding";
            this.btnReadHolding.UseVisualStyleBackColor = false;
            this.btnReadHolding.Click += new System.EventHandler(this.btnReadHolding_Click);
            // 
            // btnReadAnalog
            // 
            this.btnReadAnalog.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadAnalog.Location = new System.Drawing.Point(224, 78);
            this.btnReadAnalog.Name = "btnReadAnalog";
            this.btnReadAnalog.Size = new System.Drawing.Size(64, 46);
            this.btnReadAnalog.TabIndex = 5;
            this.btnReadAnalog.Text = "Read Analog";
            this.btnReadAnalog.UseVisualStyleBackColor = false;
            this.btnReadAnalog.Click += new System.EventHandler(this.btnReadAnalog_Click);
            // 
            // btnReadCoil
            // 
            this.btnReadCoil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadCoil.Location = new System.Drawing.Point(307, 78);
            this.btnReadCoil.Name = "btnReadCoil";
            this.btnReadCoil.Size = new System.Drawing.Size(64, 46);
            this.btnReadCoil.TabIndex = 6;
            this.btnReadCoil.Text = "Read Coil";
            this.btnReadCoil.UseVisualStyleBackColor = false;
            this.btnReadCoil.Click += new System.EventHandler(this.btnReadCoil_Click);
            // 
            // btnReadDigital
            // 
            this.btnReadDigital.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReadDigital.Location = new System.Drawing.Point(389, 78);
            this.btnReadDigital.Name = "btnReadDigital";
            this.btnReadDigital.Size = new System.Drawing.Size(64, 46);
            this.btnReadDigital.TabIndex = 7;
            this.btnReadDigital.Text = "Read Digital";
            this.btnReadDigital.UseVisualStyleBackColor = false;
            this.btnReadDigital.Click += new System.EventHandler(this.btnReadDigital_Click);
            // 
            // btnWriteHolding
            // 
            this.btnWriteHolding.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWriteHolding.Location = new System.Drawing.Point(142, 195);
            this.btnWriteHolding.Name = "btnWriteHolding";
            this.btnWriteHolding.Size = new System.Drawing.Size(64, 47);
            this.btnWriteHolding.TabIndex = 8;
            this.btnWriteHolding.Text = "Write Holding";
            this.btnWriteHolding.UseVisualStyleBackColor = false;
            this.btnWriteHolding.Click += new System.EventHandler(this.btnWriteHolding_Click);
            // 
            // btnWriteCoil
            // 
            this.btnWriteCoil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnWriteCoil.Location = new System.Drawing.Point(307, 195);
            this.btnWriteCoil.Name = "btnWriteCoil";
            this.btnWriteCoil.Size = new System.Drawing.Size(64, 47);
            this.btnWriteCoil.TabIndex = 9;
            this.btnWriteCoil.Text = "Write Coil";
            this.btnWriteCoil.UseVisualStyleBackColor = false;
            this.btnWriteCoil.Click += new System.EventHandler(this.btnWriteCoil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.grpRw);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRw.ResumeLayout(false);
            this.grpRw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpRw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWriteCoil;
        private System.Windows.Forms.Button btnWriteHolding;
        private System.Windows.Forms.Button btnReadDigital;
        private System.Windows.Forms.Button btnReadCoil;
        private System.Windows.Forms.Button btnReadAnalog;
        private System.Windows.Forms.Button btnReadHolding;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtRegister;
    }
}

