namespace Deneme2
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
            this.btnDataGonder = new System.Windows.Forms.Button();
            this.btnStop_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDataGonder
            // 
            this.btnDataGonder.Location = new System.Drawing.Point(331, 85);
            this.btnDataGonder.Name = "btnDataGonder";
            this.btnDataGonder.Size = new System.Drawing.Size(132, 94);
            this.btnDataGonder.TabIndex = 0;
            this.btnDataGonder.Text = "PLC dataları Gonder";
            this.btnDataGonder.UseVisualStyleBackColor = true;
            this.btnDataGonder.Click += new System.EventHandler(this.btnDataGonder_Click);
            // 
            // btnStop_Click
            // 
            this.btnStop_Click.Location = new System.Drawing.Point(321, 240);
            this.btnStop_Click.Name = "btnStop_Click";
            this.btnStop_Click.Size = new System.Drawing.Size(132, 94);
            this.btnStop_Click.TabIndex = 1;
            this.btnStop_Click.Text = "Stop";
            this.btnStop_Click.UseVisualStyleBackColor = true;
            this.btnStop_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop_Click);
            this.Controls.Add(this.btnDataGonder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataGonder;
        private System.Windows.Forms.Button btnStop_Click;
    }
}

