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

        private Ping p = new Ping();
        private int sayac;
        private string durum = "";
        private string adress = "";
        private string zaman = "";
        private string sonuc = "";
        private long pingAdet = 10;


        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void chk_sinirsiz_ping_CheckedChanged(object sender, EventArgs e)
        {
            // CheckState, Checked == True kullanmak çok daha iyidir.
            if (chk_sinirsiz_ping.CheckState == CheckState.Checked)
            {
                pingAdet = 9999999999;
                txt_ping_adet.Text = "9999999999";
                txt_ping_adet.Enabled = false;
            }
            else
            {
                txt_ping_adet.Text = "10";
                pingAdet = Convert.ToInt32(txt_ping_adet.Text);
                txt_ping_adet.Enabled = true;
            }
        }

        private void btn_ping_at_Click(object sender, EventArgs e)
        {
            lst_sonuc.Items.Clear();
            lst_sonuc.Items.Add(txt_adres.Text + " Adresine Ping işlemi Başlıyor... - " + DateTime.Now + Environment.NewLine);
            lst_sonuc.Items.Add("--------------" + Environment.NewLine);
            sayac = 0;
            timer1.Interval = Convert.ToInt32(txt_ping_ms.Text);
            pingAdet = Convert.ToInt64(txt_ping_adet.Text);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // VARYASYON I
            sayac++;
            if (sayac > pingAdet)
            {
                lst_sonuc.Items.Add("--------------" + Environment.NewLine);
                lst_sonuc.Items.Add(sonuc + Environment.NewLine);
                lst_sonuc.Items.Add("--------------" + Environment.NewLine);
                timer1.Stop();
                timer1.Enabled = false;
            }
            else
            {
                try
                {
                    PingReply reply = p.Send(txt_adres.Text);
                    durum = reply.Status.ToString();
                    adress = reply.Address.ToString();
                    zaman = reply.RoundtripTime.ToString();
                    lst_sonuc.Items.Add(string.Format("Sonuç : {0} {1} -> {2} ms.", durum, adress, zaman) + Environment.NewLine);
                    sonuc = "Ping başarı ile tamamlandı";
                }
                catch (PingException)
                {
                    lst_sonuc.Items.Add("Bilinen böyle bir ana bilgisayar yok" + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
                catch (NullReferenceException)
                {
                    lst_sonuc.Items.Add("Ping Atılamadı. Adres yanlış olabilir." + Environment.NewLine);
                    sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
                }
            }




            // VARYASYON II
            //sayac++;
            //if (sayac < pingAdet)
            //{
            //    try
            //    {
            //        PingReply reply = p.Send(txt_adres.Text);
            //        durum = reply.Status.ToString();
            //        adress = reply.Address.ToString();
            //        zaman = reply.RoundtripTime.ToString();
            //        lst_sonuc.Items.Add(string.Format("Sonuç : {0} {1} -> {2} ms.", durum, adress, zaman) + Environment.NewLine);
            //        sonuc = "Ping başarı ile tamamlandı";
            //    }
            //    catch (PingException)
            //    {
            //        lst_sonuc.Items.Add("Bilinen böyle bir ana bilgisayar yok" + Environment.NewLine);
            //        sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
            //    }
            //    catch (NullReferenceException)
            //    {
            //        lst_sonuc.Items.Add("Ping Atılamadı. Adres yanlış olabilir." + Environment.NewLine);
            //        sonuc = "Bir veya daha fazla Ping denemesi başarısız oldu";
            //    }
            //}
            //else
            //{
            //    lst_sonuc.Items.Add("--------------" + Environment.NewLine);
            //    lst_sonuc.Items.Add(sonuc + Environment.NewLine);
            //    lst_sonuc.Items.Add("--------------" + Environment.NewLine);
            //    timer1.Stop();
            //    timer1.Enabled = false;
            //}



        }



        private void btn_disari_aktar_Click(object sender, EventArgs e)
        {
            string dosya_adi = "\\PingLog.txt";
            string path = txt_path.Text + dosya_adi;
            if (chk_path_sec.CheckState == CheckState.Checked)
            {
                FolderBrowserDialog opf = new FolderBrowserDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    path = opf.SelectedPath + dosya_adi;
                }
            }



            //DOSYA KONTROLÜ YAPMAK
            // YOL I
            try
            {
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write).Close();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Bu yola yazma izni yok. Varsayılan yola yazılacak. ");
                path = txt_path.Text + dosya_adi;
            }

            // YOL II
            //FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            //fs.Close();

            // YOL III
            //if (!File.Exists(path)) File.Create(path);





            // SONUÇLARI DIŞA AKTARMAK
            //YOL I
            int sayac = 0;
            while (true)
            {
                if (sayac >= lst_sonuc.Items.Count)
                {
                    Process.Start(path);
                    return;
                }
                File.AppendAllText(path, lst_sonuc.Items[sayac].ToString());
                sayac++;
            }


            // YOL II
            //for (int i = 0; i < lst_sonuc.Items.Count; i++)
            //{
            //    File.AppendAllText(path, lst_sonuc.Items[i].ToString());
            //}
            //Process.Start(path);


            // YOL III
            //int counter = 0;
            //foreach (object sonuc in lst_sonuc.Items)
            //{
            //    File.AppendAllText(path, lst_sonuc.Items[counter].ToString());
            //    counter++;
            //}
            //Process.Start(path);

        }




        private void btn_ping_durdur_Click(object sender, EventArgs e)
        {
            pingAdet = 1;
        }
    }
}
