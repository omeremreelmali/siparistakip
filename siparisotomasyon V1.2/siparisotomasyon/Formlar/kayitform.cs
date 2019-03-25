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
    public partial class kayitform : Form
    {
        Form frm = new MDIParent1();
        public kayitform()
        {
            InitializeComponent();
        }
        siparisotomasyon.musteri crd = new siparisotomasyon.musteri();
       
        private void kayitBtn_Click(object sender, EventArgs e)
        {
            crd.kayit(adTbox.Text, kuladTbox.Text, sifreTbox.Text, teksifreTbox.Text, adresTbox.Text, telTbox.Text, emailTbox.Text, "0");
            MessageBox.Show("Başarılı bir şekilde kayit oldunuz");
            this.Close();
        }
        private void telTbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void kayitform_Load(object sender, EventArgs e)
        {

        }
    }
}
