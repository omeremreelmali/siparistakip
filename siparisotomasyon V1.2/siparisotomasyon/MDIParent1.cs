using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siparisotomasyon
{
    public partial class MDIParent1 : Form
    {
        public MDIParent1()
        {
            InitializeComponent();
        }
        musteri crd = new musteri();
        private void kayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formolustur = new Formlar.kayitform();
            formolustur.MdiParent = this;
            formolustur.Show();
            girişToolStripMenuItem.Enabled = true;
            kayıtToolStripMenuItem.Enabled = false;
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        
        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            girişToolStripMenuItem.Enabled = true;
            kayıtToolStripMenuItem.Enabled = true;
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            int [] sonuc = crd.login(kuladTbox.Text, sifreTbox.Text);
            if (sonuc[0] == 1)
            {
                
                MessageBox.Show("Giriş Başarılı ! Sayfaya yönlendiriliyorsunuz");
                Form formolustur=null;
                if (sonuc[1]==0)
                {
                    formolustur= new Formlar.musteri(kuladTbox.Text);
                }
                else
                {
                    formolustur = new Formlar.yonetici();
                }
                 
                formolustur.MdiParent = this;
                formolustur.Show();
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız ! Lütfen Tekrar Deneyiniz");
            };
           
            panel1.Visible = false;

        }

        private void şifreLbl_Click(object sender, EventArgs e)
        {

        }

        private void adLbl_Click(object sender, EventArgs e)
        {

        }

        private void giriskapat_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
