using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisotomasyon
{
    public class kredikart : odeme
    {
        public string kartno, tarih, cvc;
        public float bakiye;
        private string asilkartno = "12345", asilcvc = "150", asiltarih = "0722";
        public float asilbakiye = 220;

        //base classtaki odemeonay() methodu override edilerek yeni bir islem yapmasi saglanmistir
        public override int odemeonay()
        {
            int islemonay = 0;
            if (kartno == asilkartno && tarih == asiltarih && cvc == asilcvc)
            {
                if (bakiye <= asilbakiye)
                {
                    asilbakiye -= bakiye;
                    islemonay = 1;
                }
            }
            return islemonay;
        } 
    }
}
