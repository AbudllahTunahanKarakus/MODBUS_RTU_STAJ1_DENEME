namespace Deneme1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerIpAdres = new System.Windows.Forms.TextBox();
            this.btnBaglantıAc = new System.Windows.Forms.Button();
            this.btnBaglantıKapat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBaglantıDurumu = new System.Windows.Forms.Label();
            this.tmrModbusTcpIp = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHoldingRegister0 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister1 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister3 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister2 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister5 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister4 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister7 = new System.Windows.Forms.TextBox();
            this.txtHoldingRegister6 = new System.Windows.Forms.TextBox();
            this.txtCoils7 = new System.Windows.Forms.TextBox();
            this.txtCoils6 = new System.Windows.Forms.TextBox();
            this.txtCoils5 = new System.Windows.Forms.TextBox();
            this.txtCoils4 = new System.Windows.Forms.TextBox();
            this.txtCoils3 = new System.Windows.Forms.TextBox();
            this.txtCoils2 = new System.Windows.Forms.TextBox();
            this.txtCoils1 = new System.Windows.Forms.TextBox();
            this.txtCoils0 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHoldingRegister8 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCoils8 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.chcTrue0 = new System.Windows.Forms.CheckBox();
            this.chcTrue1 = new System.Windows.Forms.CheckBox();
            this.chcTrue2 = new System.Windows.Forms.CheckBox();
            this.chcTrue3 = new System.Windows.Forms.CheckBox();
            this.chcTrue4 = new System.Windows.Forms.CheckBox();
            this.chcTrue5 = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ModbusServerIpAdres";
            // 
            // txtServerIpAdres
            // 
            this.txtServerIpAdres.Location = new System.Drawing.Point(173, 3);
            this.txtServerIpAdres.Name = "txtServerIpAdres";
            this.txtServerIpAdres.Size = new System.Drawing.Size(213, 20);
            this.txtServerIpAdres.TabIndex = 1;
            this.txtServerIpAdres.Text = "Tuna";
            this.txtServerIpAdres.TextChanged += new System.EventHandler(this.txtServerIpAdres_TextChanged);
            // 
            // btnBaglantıAc
            // 
            this.btnBaglantıAc.Location = new System.Drawing.Point(46, 42);
            this.btnBaglantıAc.Name = "btnBaglantıAc";
            this.btnBaglantıAc.Size = new System.Drawing.Size(340, 33);
            this.btnBaglantıAc.TabIndex = 2;
            this.btnBaglantıAc.Text = "Bağlantı Aç";
            this.btnBaglantıAc.UseVisualStyleBackColor = true;
            this.btnBaglantıAc.Click += new System.EventHandler(this.btnBaglantıAc_Click);
            // 
            // btnBaglantıKapat
            // 
            this.btnBaglantıKapat.Location = new System.Drawing.Point(46, 81);
            this.btnBaglantıKapat.Name = "btnBaglantıKapat";
            this.btnBaglantıKapat.Size = new System.Drawing.Size(340, 32);
            this.btnBaglantıKapat.TabIndex = 3;
            this.btnBaglantıKapat.Text = "Bağlantı Kapat";
            this.btnBaglantıKapat.UseVisualStyleBackColor = true;
            this.btnBaglantıKapat.Click += new System.EventHandler(this.btnBaglantıKapat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bağlantı Durumu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblBaglantıDurumu
            // 
            this.lblBaglantıDurumu.AutoSize = true;
            this.lblBaglantıDurumu.Location = new System.Drawing.Point(613, 6);
            this.lblBaglantıDurumu.Name = "lblBaglantıDurumu";
            this.lblBaglantıDurumu.Size = new System.Drawing.Size(77, 13);
            this.lblBaglantıDurumu.TabIndex = 5;
            this.lblBaglantıDurumu.Text = "Bağlantı Kapalı";
            // 
            // tmrModbusTcpIp
            // 
            this.tmrModbusTcpIp.Tick += new System.EventHandler(this.tmrModbusTcpIp_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HoldingRegister0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "HoldingRegister1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "HoldingRegister2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "HoldingRegister3";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "HoldingRegister4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "HoldingRegister5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "HoldingRegister6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "HoldingRegister7";
            // 
            // txtHoldingRegister0
            // 
            this.txtHoldingRegister0.Location = new System.Drawing.Point(216, 239);
            this.txtHoldingRegister0.Name = "txtHoldingRegister0";
            this.txtHoldingRegister0.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister0.TabIndex = 14;
            // 
            // txtHoldingRegister1
            // 
            this.txtHoldingRegister1.Location = new System.Drawing.Point(216, 265);
            this.txtHoldingRegister1.Name = "txtHoldingRegister1";
            this.txtHoldingRegister1.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister1.TabIndex = 15;
            // 
            // txtHoldingRegister3
            // 
            this.txtHoldingRegister3.Location = new System.Drawing.Point(216, 317);
            this.txtHoldingRegister3.Name = "txtHoldingRegister3";
            this.txtHoldingRegister3.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister3.TabIndex = 17;
            // 
            // txtHoldingRegister2
            // 
            this.txtHoldingRegister2.Location = new System.Drawing.Point(216, 288);
            this.txtHoldingRegister2.Name = "txtHoldingRegister2";
            this.txtHoldingRegister2.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister2.TabIndex = 16;
            // 
            // txtHoldingRegister5
            // 
            this.txtHoldingRegister5.Location = new System.Drawing.Point(216, 372);
            this.txtHoldingRegister5.Name = "txtHoldingRegister5";
            this.txtHoldingRegister5.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister5.TabIndex = 19;
            // 
            // txtHoldingRegister4
            // 
            this.txtHoldingRegister4.Location = new System.Drawing.Point(216, 343);
            this.txtHoldingRegister4.Name = "txtHoldingRegister4";
            this.txtHoldingRegister4.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister4.TabIndex = 18;
            // 
            // txtHoldingRegister7
            // 
            this.txtHoldingRegister7.Location = new System.Drawing.Point(216, 427);
            this.txtHoldingRegister7.Name = "txtHoldingRegister7";
            this.txtHoldingRegister7.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister7.TabIndex = 21;
            // 
            // txtHoldingRegister6
            // 
            this.txtHoldingRegister6.Location = new System.Drawing.Point(216, 398);
            this.txtHoldingRegister6.Name = "txtHoldingRegister6";
            this.txtHoldingRegister6.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister6.TabIndex = 20;
            // 
            // txtCoils7
            // 
            this.txtCoils7.Location = new System.Drawing.Point(497, 434);
            this.txtCoils7.Name = "txtCoils7";
            this.txtCoils7.Size = new System.Drawing.Size(205, 20);
            this.txtCoils7.TabIndex = 37;
            // 
            // txtCoils6
            // 
            this.txtCoils6.Location = new System.Drawing.Point(497, 405);
            this.txtCoils6.Name = "txtCoils6";
            this.txtCoils6.Size = new System.Drawing.Size(205, 20);
            this.txtCoils6.TabIndex = 36;
            // 
            // txtCoils5
            // 
            this.txtCoils5.Location = new System.Drawing.Point(497, 379);
            this.txtCoils5.Name = "txtCoils5";
            this.txtCoils5.Size = new System.Drawing.Size(205, 20);
            this.txtCoils5.TabIndex = 35;
            // 
            // txtCoils4
            // 
            this.txtCoils4.Location = new System.Drawing.Point(497, 350);
            this.txtCoils4.Name = "txtCoils4";
            this.txtCoils4.Size = new System.Drawing.Size(205, 20);
            this.txtCoils4.TabIndex = 34;
            // 
            // txtCoils3
            // 
            this.txtCoils3.Location = new System.Drawing.Point(497, 324);
            this.txtCoils3.Name = "txtCoils3";
            this.txtCoils3.Size = new System.Drawing.Size(205, 20);
            this.txtCoils3.TabIndex = 33;
            // 
            // txtCoils2
            // 
            this.txtCoils2.Location = new System.Drawing.Point(497, 295);
            this.txtCoils2.Name = "txtCoils2";
            this.txtCoils2.Size = new System.Drawing.Size(205, 20);
            this.txtCoils2.TabIndex = 32;
            // 
            // txtCoils1
            // 
            this.txtCoils1.Location = new System.Drawing.Point(497, 272);
            this.txtCoils1.Name = "txtCoils1";
            this.txtCoils1.Size = new System.Drawing.Size(205, 20);
            this.txtCoils1.TabIndex = 31;
            // 
            // txtCoils0
            // 
            this.txtCoils0.Location = new System.Drawing.Point(497, 243);
            this.txtCoils0.Name = "txtCoils0";
            this.txtCoils0.Size = new System.Drawing.Size(205, 20);
            this.txtCoils0.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Coils7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Coils6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(441, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Coils5";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(441, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Coils4";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(441, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Coils3";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(441, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Coils2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(441, 279);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Coils1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(441, 250);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Coils0";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtHoldingRegister8
            // 
            this.txtHoldingRegister8.Location = new System.Drawing.Point(216, 456);
            this.txtHoldingRegister8.Name = "txtHoldingRegister8";
            this.txtHoldingRegister8.Size = new System.Drawing.Size(205, 20);
            this.txtHoldingRegister8.TabIndex = 38;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(78, 463);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(88, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "HoldingRegister8";
            // 
            // txtCoils8
            // 
            this.txtCoils8.Location = new System.Drawing.Point(497, 463);
            this.txtCoils8.Name = "txtCoils8";
            this.txtCoils8.Size = new System.Drawing.Size(205, 20);
            this.txtCoils8.TabIndex = 40;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(441, 466);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "Coils8";
            // 
            // chcTrue0
            // 
            this.chcTrue0.AutoSize = true;
            this.chcTrue0.Location = new System.Drawing.Point(501, 106);
            this.chcTrue0.Name = "chcTrue0";
            this.chcTrue0.Size = new System.Drawing.Size(80, 17);
            this.chcTrue0.TabIndex = 42;
            this.chcTrue0.Text = "checkBox1";
            this.chcTrue0.UseVisualStyleBackColor = true;
            // 
            // chcTrue1
            // 
            this.chcTrue1.AutoSize = true;
            this.chcTrue1.Location = new System.Drawing.Point(610, 106);
            this.chcTrue1.Name = "chcTrue1";
            this.chcTrue1.Size = new System.Drawing.Size(80, 17);
            this.chcTrue1.TabIndex = 43;
            this.chcTrue1.Text = "checkBox2";
            this.chcTrue1.UseVisualStyleBackColor = true;
            // 
            // chcTrue2
            // 
            this.chcTrue2.AutoSize = true;
            this.chcTrue2.Location = new System.Drawing.Point(501, 151);
            this.chcTrue2.Name = "chcTrue2";
            this.chcTrue2.Size = new System.Drawing.Size(80, 17);
            this.chcTrue2.TabIndex = 44;
            this.chcTrue2.Text = "checkBox3";
            this.chcTrue2.UseVisualStyleBackColor = true;
            // 
            // chcTrue3
            // 
            this.chcTrue3.AutoSize = true;
            this.chcTrue3.Location = new System.Drawing.Point(610, 151);
            this.chcTrue3.Name = "chcTrue3";
            this.chcTrue3.Size = new System.Drawing.Size(80, 17);
            this.chcTrue3.TabIndex = 45;
            this.chcTrue3.Text = "checkBox4";
            this.chcTrue3.UseVisualStyleBackColor = true;
            // 
            // chcTrue4
            // 
            this.chcTrue4.AutoSize = true;
            this.chcTrue4.Location = new System.Drawing.Point(501, 203);
            this.chcTrue4.Name = "chcTrue4";
            this.chcTrue4.Size = new System.Drawing.Size(80, 17);
            this.chcTrue4.TabIndex = 46;
            this.chcTrue4.Text = "checkBox5";
            this.chcTrue4.UseVisualStyleBackColor = true;
            // 
            // chcTrue5
            // 
            this.chcTrue5.AutoSize = true;
            this.chcTrue5.Location = new System.Drawing.Point(610, 203);
            this.chcTrue5.Name = "chcTrue5";
            this.chcTrue5.Size = new System.Drawing.Size(80, 17);
            this.chcTrue5.TabIndex = 47;
            this.chcTrue5.Text = "checkBox6";
            this.chcTrue5.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(498, 81);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "0-True";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(613, 81);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "1-True";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(498, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(38, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "2-True";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(613, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 13);
            this.label24.TabIndex = 51;
            this.label24.Text = "3-True";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(498, 187);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 13);
            this.label25.TabIndex = 52;
            this.label25.Text = "4-True";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(607, 187);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "5-True";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.chcTrue5);
            this.Controls.Add(this.chcTrue4);
            this.Controls.Add(this.chcTrue3);
            this.Controls.Add(this.chcTrue2);
            this.Controls.Add(this.chcTrue1);
            this.Controls.Add(this.chcTrue0);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCoils8);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtHoldingRegister8);
            this.Controls.Add(this.txtCoils7);
            this.Controls.Add(this.txtCoils6);
            this.Controls.Add(this.txtCoils5);
            this.Controls.Add(this.txtCoils4);
            this.Controls.Add(this.txtCoils3);
            this.Controls.Add(this.txtCoils2);
            this.Controls.Add(this.txtCoils1);
            this.Controls.Add(this.txtCoils0);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtHoldingRegister7);
            this.Controls.Add(this.txtHoldingRegister6);
            this.Controls.Add(this.txtHoldingRegister5);
            this.Controls.Add(this.txtHoldingRegister4);
            this.Controls.Add(this.txtHoldingRegister3);
            this.Controls.Add(this.txtHoldingRegister2);
            this.Controls.Add(this.txtHoldingRegister1);
            this.Controls.Add(this.txtHoldingRegister0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBaglantıDurumu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBaglantıKapat);
            this.Controls.Add(this.btnBaglantıAc);
            this.Controls.Add(this.txtServerIpAdres);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerIpAdres;
        private System.Windows.Forms.Button btnBaglantıAc;
        private System.Windows.Forms.Button btnBaglantıKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBaglantıDurumu;
        private System.Windows.Forms.Timer tmrModbusTcpIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHoldingRegister0;
        private System.Windows.Forms.TextBox txtHoldingRegister1;
        private System.Windows.Forms.TextBox txtHoldingRegister3;
        private System.Windows.Forms.TextBox txtHoldingRegister2;
        private System.Windows.Forms.TextBox txtHoldingRegister5;
        private System.Windows.Forms.TextBox txtHoldingRegister4;
        private System.Windows.Forms.TextBox txtHoldingRegister7;
        private System.Windows.Forms.TextBox txtHoldingRegister6;
        private System.Windows.Forms.TextBox txtCoils7;
        private System.Windows.Forms.TextBox txtCoils6;
        private System.Windows.Forms.TextBox txtCoils5;
        private System.Windows.Forms.TextBox txtCoils4;
        private System.Windows.Forms.TextBox txtCoils3;
        private System.Windows.Forms.TextBox txtCoils2;
        private System.Windows.Forms.TextBox txtCoils1;
        private System.Windows.Forms.TextBox txtCoils0;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHoldingRegister8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCoils8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox chcTrue0;
        private System.Windows.Forms.CheckBox chcTrue1;
        private System.Windows.Forms.CheckBox chcTrue2;
        private System.Windows.Forms.CheckBox chcTrue3;
        private System.Windows.Forms.CheckBox chcTrue4;
        private System.Windows.Forms.CheckBox chcTrue5;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}

