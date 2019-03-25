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

namespace siparisotomasyon.Formlar
{
    public partial class musteri : Form
    {
        siparis siparisolustur = new siparis(); urun urun1 = new urun(); kredikart kartodeme = new kredikart(); siparisotomasyon.musteri mstr = new siparisotomasyon.musteri();
        int komboonay1 = 0, komboonay2 = 0, komboonay3 = 0; float tamtutar = 0, ekucretnakitodeme = 0;
        ListViewItem seciliitem = new ListViewItem();
        ListViewItem[] sepettekiUrunler;
        
        cek cekodeme = new cek(); nakit nakitodeme = new nakit();
        string[] musteribilgi = new string[2];
        int onay = 0; 
        public musteri(string kullaniciadi)
        {
            InitializeComponent();
            musteribilgi = mstr.musteribul(kullaniciadi);
        }
        

        private void musteri_Load(object sender, EventArgs e){
            uruncagir();
            odemeaktiflikPaneli.Enabled = false;
        }

        private void fiyatTBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void msepetEkleBtn_Click(object sender, EventArgs e)
        {
           
            if (mBedencbox.SelectedItem==null || mRenkcbox.SelectedItem==null)
            {
                MessageBox.Show("Lütfen eksik bilgileri seçiniz");
            }
            else if (mMarkatxt.Text==""||mMarkatxt.Text==null || mfiyatTBox.Text == "" || mfiyatTBox.Text == null)
            {
                MessageBox.Show("Lütfen ürün seçiniz");
            }
            else
            {
                ListViewItem sepeturun = new ListViewItem (seciliitem.SubItems[0].Text);
                sepeturun.SubItems.Add(seciliitem.SubItems[1].Text);
                sepeturun.SubItems.Add(seciliitem.SubItems[2].Text);
                sepeturun.SubItems.Add(seciliitem.SubItems[3].Text);
                sepeturun.SubItems.Add(seciliitem.SubItems[4].Text);
                sepeturun.SubItems.Add(seciliitem.SubItems[5].Text);
                sepeturun.SubItems.Add(madetTbox.Text);
                sepeturun.SubItems.Add(mBedencbox.Text);
                sepeturun.SubItems.Add(mRenkcbox.Text);
                msepetListView.Items.Add(sepeturun);
                MessageBox.Show("Ürün Sepete Eklendi !");
            }
            
        }

     

        private void mOnaylaBtn_Click(object sender, EventArgs e)
        {
            odemeaktiflikPaneli.Enabled = true;
            msepetEkleTabpage.SelectedTab = mOdemeTabPage;
            toptutarodemelbl.Text = mTutarTBox.Text;
        }

        void uruncagir()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\item.txt");
            string satir = null;
            while ((satir = sr.ReadLine()) != null)
            {

                string[] str = urun1.urunparcala(satir);
                ListViewItem list = new ListViewItem(str);
                murunListview.Items.Add(list);
            }
            sr.Close();
        }

        private void murunListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (murunListview.SelectedItems.Count > 0)
            {
                seciliitem = murunListview.SelectedItems[0];
                mAdlbl.Text = seciliitem.SubItems[0].Text;
                mfiyatTBox.Text = seciliitem.SubItems[2].Text;
                mMarkatxt.Text = seciliitem.SubItems[1].Text;
                mcinsiyettbox.Text = seciliitem.SubItems[4].Text;
            }
        }

        private void madetArtıButton_Click(object sender, EventArgs e)
        {
            madetTbox.Text = (Convert.ToInt32(madetTbox.Text)+1).ToString();
        }

        private void madeteksiButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(madetTbox.Text)>1)
            {
                madetTbox.Text = (Convert.ToInt32(madetTbox.Text) - 1).ToString();
            }
        }

        private void urunsilbtn_Click(object sender, EventArgs e)
        {
            if (msepetListView.SelectedItems.Count > 0)
            {
                ListViewItem silitem = msepetListView.SelectedItems[0];
                msepetListView.Items.Remove(msepetListView.SelectedItems[0]);
                fiyathesapla();
            }
            else
            {
                MessageBox.Show("Lütfen silincek ürünü seçiniz.");
            }
            
            
        }

       

        private void kredikartBtn_Click(object sender, EventArgs e)
        {
            komboodemecheckfalse();
            kredikartpanel.Visible = true; cekpanel.Visible = false;
            nakitpanel.Visible = false; kombopanel.Visible = false;
            toptutarodemelbl.Text = mTutarTBox.Text;
        }

        private void nakitBtn_Click(object sender, EventArgs e)
        {
            komboodemecheckfalse();
            kredikartpanel.Visible = false; cekpanel.Visible = false;
            nakitpanel.Visible = true; kombopanel.Visible = false;
            ekucretnakitodeme = ((float.Parse(mTutarTBox.Text) * 5) / 100);
            tamtutar = (ekucretnakitodeme + float.Parse(mTutarTBox.Text));
            toptutarodemelbl.Text = tamtutar.ToString();
        }

        private void cekBtn_Click(object sender, EventArgs e)
        {
            komboodemecheckfalse();
            kredikartpanel.Visible = false; cekpanel.Visible = true;
            nakitpanel.Visible = false; kombopanel.Visible = false;
            toptutarodemelbl.Text = mTutarTBox.Text;
        }

        private void parcaliodemeBtn_Click(object sender, EventArgs e)
        {
            komboodemecheckfalse();
            kredikartpanel.Visible = false; cekpanel.Visible = false;
            nakitpanel.Visible = false; kombopanel.Visible = true;
            toptutarodemelbl.Text = mTutarTBox.Text;
        }

        private void krediodemebtn_Click(object sender, EventArgs e)
        {
            kartode(kartnotxt.Text, tarihaycmbox.Text + tarihyilcmbox.Text, cvccodetbox.Text, float.Parse(mTutarTBox.Text));
            islemsonuc();
        }

        private void cekodebtn_Click(object sender, EventArgs e)
        {
            cekodemef(ibantbox.Text, hesapnotbox.Text, cekaycbox.Text, cekyilcbox.Text);
            islemsonuc();
        }

        private void nakitodebtn_Click(object sender, EventArgs e)
        {
            if (nakitonayRbtn.Checked)
            {
                nakitode();
            }
            else
            {
                MessageBox.Show("Lütfen nakit ödeme koşullarını kabul ediniz.");
            }
            islemsonuc();
        }

        private void komboodebtn_Click(object sender, EventArgs e)
        {
            float toplam = 0;
            if (kredikarticheckbox.Checked==true)
            {
                toplam = toplam + float.Parse(krediboltbox.Text);
            }
            if (nakitcheckbox.Checked == true)
            {
                toplam = toplam + float.Parse(kombonakitboltxt.Text);
            }
            if (cekcheckbox.Checked == true)
            {
                toplam = toplam + float.Parse(kombocekboltxt.Text);
            }
            if (toplam==float.Parse(toptutarodemelbl.Text))
            {
                
                if (kredikarticheckbox.Checked==true)
                {
                    kartode(kombokartnotbox.Text,kombokartaycbox.Text + kombokartyilcbox.Text,kombokartcvctbox.Text, float.Parse(mTutarTBox.Text));
                }
                if (nakitcheckbox.Checked==true)
                {
                    if (kombonakitkabulRbtn.Checked)
                    {
                        nakitode();
                    }
                    else
                    {
                        MessageBox.Show("lütfen nakit ödeme koşullarını kabul ediniz.");
                    }
                }
                if (cekcheckbox.Checked==true)
                {
                    cekodemef(komboibantbox.Text,kombohesaptbox.Text,komboaycbox.Text,komboyilcbox.Text);
                }
            }
            else
            {
                MessageBox.Show("Lütfen girdiğiniz seçeneklerdeki tutar toplam tutara eşit olsun");
            }

            islemsonuc();
        }

        private void kredikarticheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (kredikarticheckbox.Checked)
            {
                krediboltbox.Enabled = true;
            }
            else
            {
                krediboltbox.Enabled = false;
            }
        }

        private void krediboltbox_TextChanged(object sender, EventArgs e)
        {
           
            if (krediboltbox.Text==""|| krediboltbox.Text == null)
            {
                kombokartyilcbox.Enabled = false;
                kombokartaycbox.Enabled = false;
                kombokartcvctbox.Enabled = false;
                kombokartnotbox.Enabled = false;
            }
            else
            {
               
                kombokartyilcbox.Enabled = true;
                kombokartaycbox.Enabled = true;
                kombokartcvctbox.Enabled = true;
                kombokartnotbox.Enabled = true;
            }
        }

        private void nakitcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (nakitcheckbox.Checked)
            {
                kombonakitboltxt.Enabled = true;
                ekucretnakitodeme = ((float.Parse(mTutarTBox.Text) * 5) / 100);
                tamtutar = (ekucretnakitodeme + float.Parse(mTutarTBox.Text));
                toptutarodemelbl.Text = tamtutar.ToString();
            }
            else
            {
                kombonakitboltxt.Enabled = false;
                toptutarodemelbl.Text = mTutarTBox.Text;
            }
        }

        private void kombonakitboltxt_TextChanged(object sender, EventArgs e)
        {
            if (kombonakitboltxt.Text == "" || kombonakitboltxt.Text == null)
            {
                kombonakitkabulRbtn.Enabled = false;
            }
            else
            {
                kombonakitkabulRbtn.Enabled = true;
            }
        }

        private void cekcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (cekcheckbox.Checked)
            {
                kombocekboltxt.Enabled = true;
            }
            else
            {
                kombocekboltxt.Enabled = false;
            }
        }

        private void kombocekboltxt_TextChanged(object sender, EventArgs e)
        {
            if (kombocekboltxt.Text == "" || kombocekboltxt.Text == null)
            {
                komboibantbox.Enabled = false;
                kombohesaptbox.Enabled = false;
                komboyilcbox.Enabled = false;
                komboaycbox.Enabled = false;
            }
            else
            {
                komboibantbox.Enabled = true;
                kombohesaptbox.Enabled = true;
                komboyilcbox.Enabled = true;
                komboaycbox.Enabled = true;
            }
        }

        private void msepetEkleTabpage_Click(object sender, EventArgs e)
        {
            fiyathesapla();
        }

        void fiyathesapla()
        {
            sepettekiUrunler = new ListViewItem[msepetListView.Items.Count];
            for (int i = 0; i < msepetListView.Items.Count; i++)
            {
                sepettekiUrunler[i] = msepetListView.Items[i];
            }
            float[] gelenbilgiler = siparisolustur.gelensiparis(sepettekiUrunler);
            aratoplamlbl.Text = gelenbilgiler[0] + " TL";
            mTutarTBox.Text = gelenbilgiler[1].ToString();
        }

        private void vergiDurumuBtn_Click(object sender, EventArgs e)
        {
            if (vergidurumTbox.Text=="12345")
            {
                siparisolustur.sipDetay.vergidurumu = 1;
                MessageBox.Show("Vergi indirimi sepetinize uygulanmıştır.");
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız tekrar deneyiniz.");
            }
        }
        // ödeme yöntemleri için fonksiyonlar
        void kartode(string kno,string trh,string kcvc,float kbakiye)
        {
            kredikart kkartode = new kredikart();
            kkartode.kartno = kno; kkartode.tarih = trh ;
            kkartode.cvc = kcvc; kkartode.bakiye = kbakiye;
            
            if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true && cekcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && cekcheckbox.Checked == true) || (nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
            {
                komboonay1 = kkartode.odemeonay();
            }
            else
            {
                onay = kkartode.odemeonay();
            }
            

        }
        void nakitode()
        {
            nakit nkt = new nakit();
            nkt.nakitonay = 1;
            if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true && cekcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && cekcheckbox.Checked == true) || (nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
            {
                komboonay2 = nkt.odemeonay();
            }
            else
            {
                onay = nkt.odemeonay();
            }
            
            
        }
        void cekodemef(string iban,string hesapno,string odeay, string odeyil)
        {
            cek cekode = new cek();
            cekode.iban = iban; cekode.hesapno = hesapno;
            cekode.odemeay = odeay; cekode.odemeyil = odeyil;
            if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true && cekcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true ) || (kredikarticheckbox.Checked == true  && cekcheckbox.Checked == true) || (nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
            {
                komboonay3 = cekode.odemeonay();
            }
            else
            {
                onay = cekode.odemeonay();
            }
            
        }
        void islemsonuc()
        {

            if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true && cekcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true) || (kredikarticheckbox.Checked == true && cekcheckbox.Checked == true) || (nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
            {
                if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
                {
                    if (komboonay1 == 1 && komboonay2 == 1 && komboonay3 == 1)
                    {
                        string odemesekli = "1: "+krediboltbox.Text+", 2: "+kombonakitboltxt.Text+", 3: "+kombocekboltxt.Text;
                        siparisolustur.siparisonay(odemesekli,musteribilgi);
                        MessageBox.Show("Ödeme alındı islem kaydedildi.");
                    }
                    else
                    {
                        odemehata();
                    }
                }
                else if ((kredikarticheckbox.Checked == true && nakitcheckbox.Checked == true))
                {
                    if (komboonay1 == 1 && komboonay2 == 1)
                    {
                        string odemesekli = "1: " + krediboltbox.Text + ", 2: " + kombonakitboltxt.Text;

                        siparisolustur.siparisonay(odemesekli, musteribilgi);
                        MessageBox.Show("Ödeme alındı islem kaydedildi.");
                    }
                    else
                    { odemehata(); }
                }
                else if ((kredikarticheckbox.Checked == true && cekcheckbox.Checked == true))
                {
                    if (komboonay1 == 1 && komboonay3 == 1)
                    {
                        string odemesekli = "1: " + krediboltbox.Text + ", 3: " + kombocekboltxt.Text;
                        siparisolustur.siparisonay(odemesekli, musteribilgi);
                        MessageBox.Show("Ödeme alındı islem kaydedildi.");
                    }
                    else
                    { odemehata(); }
                }
                else if ((nakitcheckbox.Checked == true && cekcheckbox.Checked == true))
                {
                    string odemesekli =  "2: " + kombonakitboltxt.Text + ", 3: " + kombocekboltxt.Text;

                    if (komboonay2 == 1 && komboonay3 == 1)
                    {
                        siparisolustur.siparisonay(odemesekli, musteribilgi);
                        MessageBox.Show("Ödeme alındı islem kaydedildi.");
                    }
                    else
                    { odemehata(); }
                }


            }
            else
            {
                if (onay == 1)
                {
                    siparisolustur.siparisonay(toptutarodemelbl.Text, musteribilgi);
                    MessageBox.Show("Ödeme alındı islem kaydedildi.");
                }
                else
                {
                    odemehata();
                }
            }
            
        }

        void odemehata()
        {
            MessageBox.Show("Ödeme sırasında bir hata oluştu lüften ödeme adımlarını kontrol ediniz.");
        }
        void komboodemecheckfalse()
        {
            kredikarticheckbox.Checked = false;
            nakitcheckbox.Checked = false;
            cekcheckbox.Checked = false;
        }
    }
}
