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
            this.chk_sinirsiz_ping = new System.Windows.Forms.CheckBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ping_ms = new System.Windows.Forms.TextBox();
            this.txt_ping_adet = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ping_durdur = new System.Windows.Forms.Button();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.chk_path_sec = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_ping_at
            // 
            this.btn_ping_at.Location = new System.Drawing.Point(13, 10);
            this.btn_ping_at.Name = "btn_ping_at";
            this.btn_ping_at.Size = new System.Drawing.Size(173, 23);
            this.btn_ping_at.TabIndex = 0;
            this.btn_ping_at.Text = "Ping Gönder";
            this.btn_ping_at.UseVisualStyleBackColor = true;
            this.btn_ping_at.Click += new System.EventHandler(this.btn_ping_at_Click);
            // 
            // btn_disari_aktar
            // 
            this.btn_disari_aktar.Location = new System.Drawing.Point(13, 90);
            this.btn_disari_aktar.Name = "btn_disari_aktar";
            this.btn_disari_aktar.Size = new System.Drawing.Size(173, 23);
            this.btn_disari_aktar.TabIndex = 1;
            this.btn_disari_aktar.Text = "Dışarı Aktar";
            this.btn_disari_aktar.UseVisualStyleBackColor = true;
            this.btn_disari_aktar.Click += new System.EventHandler(this.btn_disari_aktar_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(192, 12);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(440, 20);
            this.txt_adres.TabIndex = 2;
            this.txt_adres.Text = "www.mustafabukulmez.com";
            // 
            // lst_sonuc
            // 
            this.lst_sonuc.FormattingEnabled = true;
            this.lst_sonuc.Location = new System.Drawing.Point(192, 119);
            this.lst_sonuc.Name = "lst_sonuc";
            this.lst_sonuc.Size = new System.Drawing.Size(440, 342);
            this.lst_sonuc.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chk_sinirsiz_ping
            // 
            this.chk_sinirsiz_ping.AutoSize = true;
            this.chk_sinirsiz_ping.Location = new System.Drawing.Point(254, 66);
            this.chk_sinirsiz_ping.Name = "chk_sinirsiz_ping";
            this.chk_sinirsiz_ping.Size = new System.Drawing.Size(120, 17);
            this.chk_sinirsiz_ping.TabIndex = 4;
            this.chk_sinirsiz_ping.Text = "Sınırsız Ping Gönder";
            this.chk_sinirsiz_ping.UseVisualStyleBackColor = true;
            this.chk_sinirsiz_ping.CheckedChanged += new System.EventHandler(this.chk_sinirsiz_ping_CheckedChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(141, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Ping Hızını Ayarla (Mili Saniye)";
            // 
            // txt_ping_ms
            // 
            this.txt_ping_ms.Location = new System.Drawing.Point(192, 38);
            this.txt_ping_ms.Name = "txt_ping_ms";
            this.txt_ping_ms.Size = new System.Drawing.Size(56, 20);
            this.txt_ping_ms.TabIndex = 6;
            this.txt_ping_ms.Text = "750";
            // 
            // txt_ping_adet
            // 
            this.txt_ping_adet.Location = new System.Drawing.Point(192, 64);
            this.txt_ping_adet.Name = "txt_ping_adet";
            this.txt_ping_adet.Size = new System.Drawing.Size(56, 20);
            this.txt_ping_adet.TabIndex = 8;
            this.txt_ping_adet.Text = "10";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(105, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Ping Sayısı Belirle";
            // 
            // btn_ping_durdur
            // 
            this.btn_ping_durdur.Location = new System.Drawing.Point(192, 467);
            this.btn_ping_durdur.Name = "btn_ping_durdur";
            this.btn_ping_durdur.Size = new System.Drawing.Size(440, 34);
            this.btn_ping_durdur.TabIndex = 9;
            this.btn_ping_durdur.Text = "Ping Göndermeyi Durdur";
            this.btn_ping_durdur.UseVisualStyleBackColor = true;
            this.btn_ping_durdur.Click += new System.EventHandler(this.btn_ping_durdur_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(192, 93);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(348, 20);
            this.txt_path.TabIndex = 10;
            this.txt_path.Text = "D:\\\\";
            // 
            // chk_path_sec
            // 
            this.chk_path_sec.AutoSize = true;
            this.chk_path_sec.Location = new System.Drawing.Point(546, 95);
            this.chk_path_sec.Name = "chk_path_sec";
            this.chk_path_sec.Size = new System.Drawing.Size(112, 17);
            this.chk_path_sec.TabIndex = 11;
            this.chk_path_sec.Text = "Yolu Ben Seçeyim";
            this.chk_path_sec.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 595);
            this.Controls.Add(this.chk_path_sec);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.btn_ping_durdur);
            this.Controls.Add(this.txt_ping_adet);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_ping_ms);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chk_sinirsiz_ping);
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
        private System.Windows.Forms.CheckBox chk_sinirsiz_ping;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_ping_ms;
        private System.Windows.Forms.TextBox txt_ping_adet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Button btn_ping_durdur;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.CheckBox chk_path_sec;
    }
}

