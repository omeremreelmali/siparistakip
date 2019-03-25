using System;
using System.IO;
using System.Windows.Forms;
namespace siparisotomasyon
{
    class musteri
    {
        #region Kayit
        /*kullanıcıdan alınan bilgiler kayit() methodunda
          parametre alınarak gerekli kayit işlemleri yapılmıştır.*/
        public void kayit(string ad, string kulad, string sifre, string tekrarsifre, string adres, string tel, string email, string kt)
        {
            int sonuc = 1;
            if (ad == "" || ad == null || kulad == "" || kulad == null || sifre == "" || sifre == null || tekrarsifre == null || tekrarsifre == "" || adres == null || adres == "" || tel == "" || tel == null || email == "" || email == null)
            {
                sonuc = 0;
                MessageBox.Show("Lütfen boş kutucukları doldurunuz.");
            }
            if (sifre != tekrarsifre)
            {
                sonuc = 0;
                MessageBox.Show("Şifreler uyuşmuyor lütfen kontrol ediniz.");
            }
            if (sonuc == 1)
            {
                string kayit = ad + "+" + kulad + "+" + sifre + "+" + adres + "+" + tel + "+" + email + "+" + kt + Environment.NewLine;
                File.AppendAllText("user.txt", kayit);
            }
        }
        #endregion
        #region Login
        //kullanıcının girdigi kullanıcı adi ve sifreye gore giris islemleri login() methodunda yapılmıstır.
        public int[] login(string kulad, string sifre)
        {
            int[] sonuc = { 0, 0 };
            StreamReader sr = new StreamReader(Application.StartupPath + "\\user.txt");
            string satir = null;
            while ((satir = sr.ReadLine()) != null)
            {
                string gelenkulad = null, yetki = null, gelensifre = null, gelensatir = satir; int artisay = 0;
                for (int j = 0; j < gelensatir.Length; j++)
                {
                    if (gelensatir[j] == '+')
                    {
                        artisay++;
                    }
                    else if (artisay == 1)
                    {
                        gelenkulad = gelenkulad + gelensatir[j];
                    }
                    else if (artisay == 2)
                    {
                        gelensifre = gelensifre + gelensatir[j];
                    }
                    else if (artisay == 6)
                    {
                        yetki = gelensatir[j].ToString();
                    }
                }
                if (gelenkulad == kulad && gelensifre == sifre)
                {
                    sonuc[0] = 1;
                    sonuc[1] = Convert.ToInt32(yetki);
                    break;
                }
            }
            sr.Close();
            return sonuc;
        }
        #endregion
        #region MusteriBul
        public string[] musteribul(string kulad)
        {
            string[] sonuc = { "", "" };
            StreamReader sr = new StreamReader(Application.StartupPath + "\\user.txt");
            string satir = null;
            while ((satir = sr.ReadLine()) != null)
            {
                string gelenkulad = null, gelenadres = null, gelenad = null, gelensatir = satir; int artisay = 0;
                for (int j = 0; j < gelensatir.Length; j++)
                {
                    if (gelensatir[j] == '+')
                    {
                        artisay++;
                    }
                    else if (artisay == 0)
                    {
                        gelenad = gelenad + gelensatir[j];
                    }
                    else if (artisay == 1)
                    {
                        gelenkulad = gelenkulad + gelensatir[j];
                    }
                    else if (artisay == 3)
                    {
                        gelenadres = gelenadres + gelensatir[j];
                    }
                }
                if (gelenkulad == kulad)
                {
                    sonuc[0] = gelenad;
                    sonuc[1] = gelenadres;
                    break;
                }
            }
            sr.Close();
            return sonuc;
        } 
        #endregion
    }
}