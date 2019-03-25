using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisotomasyon
{
    class siparisdetay
    {
        public urun urunclass { get; set; }
        public int vergidurumu = 0;

        //arafiyatHesapla() methodu tek bir urunun toplam fiyatını hesaplar.
        public float arafiyatHesapla(float fiyat, float adet)
        {
            float arafiyat = 0;
            arafiyat = adet * fiyat;
            return arafiyat;
        }

        //tekagirlikHesapla() methodu tek bir urunun toplam agırlığını hesaplar.
        public int tekagirlikHesapla(int agirlik,int adet)
        {
            int tekagirlik = 0;
            tekagirlik = agirlik * adet;
            return tekagirlik;
        }

    }
}
