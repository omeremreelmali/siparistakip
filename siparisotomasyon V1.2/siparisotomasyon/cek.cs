using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisotomasyon
{
    public class cek : odeme
    {
        public string iban,hesapno, odemeay,odemeyil;
        private string asiliban = "12345", asilhesapno = "12345", asilodemeay = "07", asilodemeyil = "22";

        //base classtaki odemeonay() methodu override edilerek yeni bir islem yapmasi saglanmistir.
        public override int odemeonay()
        {
            int sonuc = 0;
            if (asiliban==iban && asilhesapno==hesapno)
            {
                if (Convert.ToInt32(odemeyil) ==Convert.ToInt32(asilodemeyil))
                {
                    if (Convert.ToInt32(odemeay) < Convert.ToInt32(asilodemeay))
                    {
                        sonuc = 1;
                    }
                }
                else if (Convert.ToInt32(odemeyil) < Convert.ToInt32(asilodemeyil))
                {
                    sonuc = 1;
                }
                
            }
            return sonuc;
            
        }
    }
}
