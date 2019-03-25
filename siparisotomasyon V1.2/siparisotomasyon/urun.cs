using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace siparisotomasyon
{
    class urun
    {
        public void urunekle(string urunadi, string marka, string fiyat, string stok,string uruncin,string agirlik)
        {  
            string urun =  urunadi + "+" + marka + "+" + fiyat + "+" + stok + "+"+uruncin+"+"+agirlik+Environment.NewLine; ;
            File.AppendAllText("item.txt", urun);
        }
       
        public string[] urunparcala(string gelen)
        {
            string[] dondururun = new string[6]; int artisay = 0;
            for (int j = 0; j < gelen.Length; j++)
            {
                if (gelen[j] == '+')
                {
                    artisay++;
                }
                else if (artisay == 0)
                {
                    dondururun[0] = dondururun[0] + gelen[j].ToString(); ;
                }
                else if (artisay == 1)
                {
                    dondururun[1] = dondururun[1] + gelen[j];
                }
                else if (artisay == 2)
                {
                    dondururun[2] = dondururun[2] + gelen[j];

                }
                else if (artisay == 3)
                {
                    dondururun[3] = dondururun[3] + gelen[j];
                }
                else if (artisay == 4)
                {
                    dondururun[4] = dondururun[4] + gelen[j];
                }
                else if (artisay == 5)
                {
                    dondururun[5] = dondururun[5] + gelen[j];
                }
            }
            return dondururun;
        }

        public void urunsil(string urun)
        {
            string line = null;
            using (StreamReader reader = new StreamReader("item.txt"))
            {
                using (StreamWriter writer = new StreamWriter("item1.txt"))
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
            itemsil();
        }

        public void urunguncelle(string urun, string guncelurun)
        {
            string line = null;
            
            using (StreamReader reader = new StreamReader("item.txt"))
            {
                using (StreamWriter writer = new StreamWriter("item1.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line, urun) == 0)
                        {
                            writer.WriteLine(guncelurun);
                            continue;
                        }

                        writer.WriteLine(line);
                    }
                    writer.Close();
                }
                reader.Close();
            }
            itemsil();
        }

        void itemsil()
        {
            if (File.Exists("item.txt"))
            {
                File.Delete("item.txt");
            }
            FileInfo info = new FileInfo("item1.txt");
            info.MoveTo("item.txt");
        }

    }
}
