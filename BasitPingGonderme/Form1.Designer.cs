namespace BasitPingGonderme
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
            this.btn_ping_at = new System.Windows.Forms.Button();
            this.btn_disari_aktar = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.lst_sonuc = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_ping_at
            // 
            this.btn_ping_at.Location = new System.Drawing.Point(12, 21);
            this.btn_ping_at.Name = "btn_ping_at";
            this.btn_ping_at.Size = new System.Drawing.Size(173, 23);
            this.btn_ping_at.TabIndex = 0;
            this.btn_ping_at.Text = "Ping Gönder";
            this.btn_ping_at.UseVisualStyleBackColor = true;
            this.btn_ping_at.Click += new System.EventHandler(this.btn_ping_at_Click);
            // 
            // btn_disari_aktar
            // 
            this.btn_disari_aktar.Location = new System.Drawing.Point(12, 50);
            this.btn_disari_aktar.Name = "btn_disari_aktar";
            this.btn_disari_aktar.Size = new System.Drawing.Size(173, 23);
            this.btn_disari_aktar.TabIndex = 1;
            this.btn_disari_aktar.Text = "Dışarı Aktar";
            this.btn_disari_aktar.UseVisualStyleBackColor = true;
            this.btn_disari_aktar.Click += new System.EventHandler(this.btn_disari_aktar_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(191, 23);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(321, 20);
            this.txt_adres.TabIndex = 2;
            this.txt_adres.Text = "www.mustafabukulmez.com";
            // 
            // lst_sonuc
            // 
            this.lst_sonuc.FormattingEnabled = true;
            this.lst_sonuc.Location = new System.Drawing.Point(191, 50);
            this.lst_sonuc.Name = "lst_sonuc";
            this.lst_sonuc.Size = new System.Drawing.Size(321, 342);
            this.lst_sonuc.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_sonuc);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.btn_disari_aktar);
            this.Controls.Add(this.btn_ping_at);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ping_at;
        private System.Windows.Forms.Button btn_disari_aktar;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.ListBox lst_sonuc;
        private System.Windows.Forms.Timer timer1;
    }
}

