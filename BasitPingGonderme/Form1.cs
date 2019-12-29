using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;


namespace BasitPingGonderme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 750;
        }
        private Ping p = new Ping();
        private int sayac;
        private string durum = "";
        private string adress = "";
        private string zaman = "";
        private string sonuc = "";

        private void btn_disari_aktar_Click(object sender, EventArgs e)
        {
            string path = @"D:\\PingLog.txt";
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write).Close();

            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //fs.Close();

            int num = 0;
            while (true)
            {
                if (num >= lst_sonuc.Items.Count)
                {
                    Process.Start(path);
                    return;
                }
                File.AppendAllText(path, lst_sonuc.Items[num].ToString());
                num++;
            }
        }

        private void btn_ping_at_Click(object sender, EventArgs e)
        {
            lst_sonuc.Items.Clear();
            lst_sonuc.Items.Add(txt_adres.Text + " Adresine Ping işlemi Başlıyor... - " + DateTime.Now + Environment.NewLine);
            lst_sonuc.Items.Add("--------------" + Environment.NewLine);
            sayac = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= 10)
            {
                lst_sonuc.Items.Add("--------------" + Environment.NewLine);
                lst_sonuc.Items.Add(sonuc + Environment.NewLine);
                lst_sonuc.Items.Add("--------------" + Environment.NewLine);
                timer1.Stop();
            }
            else
            {
                try
                {
                    PingReply reply = p.Send(txt_adres.Text);
                    durum = reply.Status.ToString();
                    adress = reply.Address.ToString();
                    zaman = reply.RoundtripTime.ToString();
                    lst_sonuc.Items.Add(string.Format("Sonuç : {0} {1} -> {2} ms.", durum, adress, zaman + Environment.NewLine));
                    sonuc = "Ping başarı ile tamamlandı";
                }
                catch (PingException)
                {
                    lst_sonuc.Items.Add("Bilinen b\x00f6yle bir ana bilgisayar yok" + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                    sayac = 10;
                }
                catch (NullReferenceException)
                {
                    lst_sonuc.Items.Add("Ping Atılamadı. Adres yanlış olabilir." + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                    sayac = 10;
                }
            }
        }
    }
}
