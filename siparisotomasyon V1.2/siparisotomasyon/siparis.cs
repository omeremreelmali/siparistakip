using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace siparisotomasyon
{
    class siparis
    {
        public siparisdetay sipDetay = new siparisdetay();
        float araucret = 0;
        int agirlik; ListViewItem[] gelenurunler=null;
        string tarih = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();

        #region GelenSiparis
        public float[] gelensiparis(ListViewItem[] urunler)
        {
            float[] bilgiler = new float[2];
            gelenurunler = urunler;
            for (int i = 0; i < urunler.Length; i++)
            {
                araucret = araucret + sipDetay.arafiyatHesapla(float.Parse(urunler[i].SubItems[2].Text), float.Parse(urunler[i].SubItems[6].Text));
            }
            bilgiler[0] = araucret;
            bilgiler[1] = topucretHesapla();
            araucret = 0; agirlik = 0;
            return bilgiler;
        }
        #endregion

        #region VergiHesapla
        float vergiHesapla(float ucret)
        {
            float vergi = 0;
            if (sipDetay.vergidurumu != 1)
            {
                vergi = (ucret * 18) / 100;
            }
            return vergi;
        }
        #endregion

        #region ToplamAgirlikHesapla
        int topagirlikHesapla()
        {
            int agirlik = 0;
            for (int i = 0; i < gelenurunler.Length; i++)
            {
                agirlik = agirlik + sipDetay.tekagirlikHesapla(int.Parse(gelenurunler[i].SubItems[5].Text), int.Parse(gelenurunler[i].SubItems[6].Text));
            }
            return agirlik;
        }
        #endregion

        #region ToplamUcretHesapla
        float topucretHesapla()
        {
            float ucret = 0;
            int agirlik = topagirlikHesapla();
            if (agirlik > 5)
            {
                MessageBox.Show("Ürünler 5 kiloyu geçtiği için ek olarak 10 tl ücret alınacaktır.");
                ucret = 10;
            }
            ucret = ucret + araucret + vergiHesapla(araucret) + 2;
            return ucret;
        }
        #endregion

        #region SiparisOnay
        public void siparisonay(string nettutar, string[] musteribilgisi)
        {
            string siparisKayit = tarih + "/";
            for (int i = 0; i < gelenurunler.Length; i++)
            {
                if ((gelenurunler.Length - 1) == i)
                {
                    siparisKayit = siparisKayit + gelenurunler[i].SubItems[0].Text + "+" + gelenurunler[i].SubItems[1].Text + "+" + gelenurunler[i].SubItems[2].Text + "+" + gelenurunler[i].SubItems[3].Text + "+" + gelenurunler[i].SubItems[4].Text + "+" + gelenurunler[i].SubItems[5].Text + "+" + gelenurunler[i].SubItems[6].Text + "+" + gelenurunler[i].SubItems[7].Text + "+" + gelenurunler[i].SubItems[8].Text + "/";
                }
                else
                {
                    siparisKayit = siparisKayit + gelenurunler[i].SubItems[0].Text + "+" + gelenurunler[i].SubItems[1].Text + "+" + gelenurunler[i].SubItems[2].Text + "+" + gelenurunler[i].SubItems[3].Text + "+" + gelenurunler[i].SubItems[4].Text + "+" + gelenurunler[i].SubItems[5].Text + "+" + gelenurunler[i].SubItems[6].Text + "+" + gelenurunler[i].SubItems[7].Text + "+" + gelenurunler[i].SubItems[8].Text + ",";
                }

            }
            siparisKayit = siparisKayit + "+" + musteribilgisi[0] + "+" + musteribilgisi[1] + "+" + nettutar + Environment.NewLine;
            File.AppendAllText("siparis.txt", siparisKayit);
        }
        #endregion

        #region SiparisParcala
        public string[] siparisparcala(string gelen)
        {
            string[] dondururun = new string[5]; int artisay = 0, slashsay = 0;
            for (int j = 0; j < gelen.Length; j++)
            {
                if (gelen[j] == '+' && slashsay != 1)
                {
                    artisay++;
                }
                else if (gelen[j] == '/')
                {
                    slashsay++;
                }
                else if (artisay == 0 && slashsay != 1)
                {
                    dondururun[0] = dondururun[0] + gelen[j].ToString();
                }
                else if (slashsay == 1)
                {
                    dondururun[1] = dondururun[1] + gelen[j].ToString();
                }
                else if (artisay == 1 && slashsay != 1)
                {
                    dondururun[2] = dondururun[2] + gelen[j];
                }
                else if (artisay == 2 && slashsay != 1)
                {
                    dondururun[3] = dondururun[3] + gelen[j];

                }
                else if (artisay == 3 && slashsay != 1)
                {
                    dondururun[4] = dondururun[4] + gelen[j];
                }
            }
            return dondururun;
        }
        #endregion

        #region Siparisil
        public void siparissil(string urun)
        {
            string line = null;
            using (StreamReader reader = new StreamReader("siparis.txt"))
            {
                using (StreamWriter writer = new StreamWriter("siparis1.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, urun) == 0)
                            continue;

                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                reader.Close();
            }
            siparistxtsil();
        }
        #endregion

        #region SiparisTxtSil
        void siparistxtsil()
        {
            if (File.Exists("siparis.txt"))
            {
                File.Delete("siparis.txt");
            }
            FileInfo info = new FileInfo("siparis1.txt");
            info.MoveTo("siparis.txt");
        } 
        #endregion
    }
}
