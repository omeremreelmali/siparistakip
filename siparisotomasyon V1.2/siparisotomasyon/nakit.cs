using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siparisotomasyon
{
    public class nakit : odeme
    {
        public int nakitonay;

        //base classtaki odemeonay() methodu override edilerek yeni bir islem yapmasi saglanmistir.
        public override int odemeonay()
        {
            if (nakitonay==1)
            {

            }
            return 1;
        }
    }
}
