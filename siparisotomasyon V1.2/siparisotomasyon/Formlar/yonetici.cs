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
    public partial class yonetici : Form
    {
        urun urun1 = new urun(); siparis sprs = new siparis();
        string guncelleniceksatir = null;
        public yonetici()
        {
            InitializeComponent();
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            tabpage.SelectedTab = ekleTab;
        }

        private void eekleBtn_Click(object sender, EventArgs e)
        {
            urun1.urunekle(eurunAdiTbox.Text,eMarkaTbox.Text,eFiyatTbox.Text,eStokTbox.Text,ecinCbox.Text,eagilrikTbox.Text);
            tabpage.SelectedTab = urunBilgiTab;
            listviewguncelle();
        }

        private void yonetici_Load(object sender, EventArgs e)
        {
            uruncagir();
            sipariscagir();
        }

        private void urunListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urunListview.SelectedItems.Count > 0)
            {
                ListViewItem seciliitem = urunListview.SelectedItems[0];
                Adlbl.Text = seciliitem.SubItems[0].Text;
                fiyatTBox.Text= seciliitem.SubItems[2].Text;
                Markatxt.Text= seciliitem.SubItems[1].Text;
            }
        }

        private void adeteksiButton_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(adetTbox.Text)!=0)
            {
                adetTbox.Text = (Convert.ToInt32(adetTbox.Text) - 1).ToString() ;
            }
        }

        private void adetArtıButton_Click(object sender, EventArgs e)
        {
            adetTbox.Text = (Convert.ToInt32(adetTbox.Text) + 1).ToString();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            string silineceksatir = null;

            if (urunListview.SelectedItems.Count > 0)
            {
                ListViewItem seciliitem = urunListview.SelectedItems[0];
                silineceksatir = seciliitem.SubItems[0].Text+"+"+ seciliitem.SubItems[1].Text + "+" + seciliitem.SubItems[2].Text + "+" + seciliitem.SubItems[3].Text + "+" + seciliitem.SubItems[4].Text+"+"+ seciliitem.SubItems[5].Text;
                urun1.urunsil(silineceksatir);
                MessageBox.Show("Ürün başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek ürünü seçiniz.");
            }
            listviewguncelle();
        }

        private void güncellebtn_Click(object sender, EventArgs e)
        {

        
             if (urunListview.SelectedItems.Count > 0)
             {
                 ListViewItem seciliitem = urunListview.SelectedItems[0];
                 guncelleniceksatir = seciliitem.SubItems[0].Text + "+" + seciliitem.SubItems[1].Text + "+" + seciliitem.SubItems[2].Text + "+" + seciliitem.SubItems[3].Text + "+" + seciliitem.SubItems[4].Text+"+"+ seciliitem.SubItems[5].Text;
                 gurunAdiTbox.Text = seciliitem.SubItems[0].Text;
                 gmarkaTbox.Text = seciliitem.SubItems[1].Text;
                 gfiyatTbox.Text = seciliitem.SubItems[2].Text;
                 gstokTbox.Text = seciliitem.SubItems[3].Text;
                 gcinCbox.SelectedItem = seciliitem.SubItems[4].Text;
                 gagirlikTbox.Text = seciliitem.SubItems[5].Text;
                 tabpage.SelectedTab = guncelleTab;
             }
             else
             {
                 MessageBox.Show("Lütfen guncellenicek ürünü seçiniz.");
             }
            
        }

        private void gguncelleButton_Click(object sender, EventArgs e)
        {
            string guncellsatir = gurunAdiTbox.Text + "+" + gmarkaTbox.Text + "+" + gfiyatTbox.Text + "+" + gstokTbox.Text +"+"+ gcinCbox.Text+"+"+gagirlikTbox.Text;
            urun1.urunguncelle(guncelleniceksatir,guncellsatir);
            gurunAdiTbox.Text = "";gmarkaTbox.Text = "";gfiyatTbox.Text = "";gstokTbox.Text = "";gcinCbox.SelectedIndex = -1;
            tabpage.SelectedTab = urunBilgiTab;
            MessageBox.Show("Ürün Başarıyla Güncellendi.");
            listviewguncelle();

        }

        void listviewguncelle()
        {
            urunListview.Items.Clear();
            uruncagir();
        }
        void uruncagir()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\item.txt");
            string satir = null;
            while ((satir = sr.ReadLine()) != null)
            {

                string[] str = urun1.urunparcala(satir);
                ListViewItem list = new ListViewItem(str);
                urunListview.Items.Add(list);
            }
            sr.Close();
        }
        void sipariscagir()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\siparis.txt");
            string satir = null;
            while ((satir = sr.ReadLine()) != null)
            {

                string[] str = sprs.siparisparcala(satir);
                ListViewItem list = new ListViewItem(str);
                siparisglistview.Items.Add(list);
            }
            sr.Close();
        }

        private void siparissilBtn_Click(object sender, EventArgs e)
        {
            string silineceksatir = null;

            if (siparisglistview.SelectedItems.Count > 0)
            {
                ListViewItem seciliitem = siparisglistview.SelectedItems[0];
                silineceksatir = seciliitem.SubItems[0].Text + "/" + seciliitem.SubItems[1].Text + "/+" + seciliitem.SubItems[2].Text + "+" + seciliitem.SubItems[3].Text + "+" + seciliitem.SubItems[4].Text;
                sprs.siparissil(silineceksatir);
                MessageBox.Show("Ürün başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen silinecek ürünü seçiniz.");
            }
            siparisglistview.Items.Clear();
            sipariscagir();
        }
    }
}
