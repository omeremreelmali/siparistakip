namespace siparisotomasyon.Formlar
{
    partial class kayitform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kayitBtn = new System.Windows.Forms.Button();
            this.adTbox = new System.Windows.Forms.TextBox();
            this.emailTbox = new System.Windows.Forms.TextBox();
            this.telTbox = new System.Windows.Forms.TextBox();
            this.kuladTbox = new System.Windows.Forms.TextBox();
            this.sifreTbox = new System.Windows.Forms.TextBox();
            this.teksifreTbox = new System.Windows.Forms.TextBox();
            this.adresTbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teksifreLbl = new System.Windows.Forms.Label();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.telLbl = new System.Windows.Forms.Label();
            this.kuladLbl = new System.Windows.Forms.Label();
            this.adresLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kayitBtn
            // 
            this.kayitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitBtn.Location = new System.Drawing.Point(157, 289);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(107, 33);
            this.kayitBtn.TabIndex = 0;
            this.kayitBtn.Text = "Kayıt Ol";
            this.kayitBtn.UseVisualStyleBackColor = true;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // adTbox
            // 
            this.adTbox.Location = new System.Drawing.Point(157, 61);
            this.adTbox.Name = "adTbox";
            this.adTbox.Size = new System.Drawing.Size(182, 20);
            this.adTbox.TabIndex = 1;
            // 
            // emailTbox
            // 
            this.emailTbox.Location = new System.Drawing.Point(157, 87);
            this.emailTbox.Name = "emailTbox";
            this.emailTbox.Size = new System.Drawing.Size(182, 20);
            this.emailTbox.TabIndex = 9;
            // 
            // telTbox
            // 
            this.telTbox.Location = new System.Drawing.Point(157, 114);
            this.telTbox.Name = "telTbox";
            this.telTbox.Size = new System.Drawing.Size(182, 20);
            this.telTbox.TabIndex = 10;
            this.telTbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telTbox_KeyPress);
            // 
            // kuladTbox
            // 
            this.kuladTbox.Location = new System.Drawing.Point(157, 140);
            this.kuladTbox.Name = "kuladTbox";
            this.kuladTbox.Size = new System.Drawing.Size(182, 20);
            this.kuladTbox.TabIndex = 11;
            // 
            // sifreTbox
            // 
            this.sifreTbox.Location = new System.Drawing.Point(157, 163);
            this.sifreTbox.Name = "sifreTbox";
            this.sifreTbox.Size = new System.Drawing.Size(182, 20);
            this.sifreTbox.TabIndex = 12;
            this.sifreTbox.UseSystemPasswordChar = true;
            // 
            // teksifreTbox
            // 
            this.teksifreTbox.Location = new System.Drawing.Point(157, 189);
            this.teksifreTbox.Name = "teksifreTbox";
            this.teksifreTbox.Size = new System.Drawing.Size(182, 20);
            this.teksifreTbox.TabIndex = 13;
            this.teksifreTbox.UseSystemPasswordChar = true;
            // 
            // adresTbox
            // 
            this.adresTbox.Location = new System.Drawing.Point(157, 215);
            this.adresTbox.Multiline = true;
            this.adresTbox.Name = "adresTbox";
            this.adresTbox.Size = new System.Drawing.Size(182, 51);
            this.adresTbox.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.teksifreLbl);
            this.panel1.Controls.Add(this.sifreLbl);
            this.panel1.Controls.Add(this.telLbl);
            this.panel1.Controls.Add(this.kuladLbl);
            this.panel1.Controls.Add(this.adresLbl);
            this.panel1.Controls.Add(this.emailLbl);
            this.panel1.Controls.Add(this.adLbl);
            this.panel1.Location = new System.Drawing.Point(66, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(85, 205);
            this.panel1.TabIndex = 15;
            // 
            // teksifreLbl
            // 
            this.teksifreLbl.AutoSize = true;
            this.teksifreLbl.Location = new System.Drawing.Point(10, 135);
            this.teksifreLbl.Name = "teksifreLbl";
            this.teksifreLbl.Size = new System.Drawing.Size(62, 13);
            this.teksifreLbl.TabIndex = 15;
            this.teksifreLbl.Text = "Tekrar Şifre";
            // 
            // sifreLbl
            // 
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Location = new System.Drawing.Point(10, 109);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(28, 13);
            this.sifreLbl.TabIndex = 14;
            this.sifreLbl.Text = "Şifre";
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.Location = new System.Drawing.Point(9, 60);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(43, 13);
            this.telLbl.TabIndex = 13;
            this.telLbl.Text = "Telefon";
            // 
            // kuladLbl
            // 
            this.kuladLbl.AutoSize = true;
            this.kuladLbl.Location = new System.Drawing.Point(9, 86);
            this.kuladLbl.Name = "kuladLbl";
            this.kuladLbl.Size = new System.Drawing.Size(64, 13);
            this.kuladLbl.TabIndex = 12;
            this.kuladLbl.Text = "Kullanıcı Adı";
            // 
            // adresLbl
            // 
            this.adresLbl.AutoSize = true;
            this.adresLbl.Location = new System.Drawing.Point(12, 162);
            this.adresLbl.Name = "adresLbl";
            this.adresLbl.Size = new System.Drawing.Size(34, 13);
            this.adresLbl.TabIndex = 11;
            this.adresLbl.Text = "Adres";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(9, 33);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "E-mail";
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Location = new System.Drawing.Point(9, 7);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(53, 13);
            this.adLbl.TabIndex = 9;
            this.adLbl.Text = "Ad Soyad";
            // 
            // kayitform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adresTbox);
            this.Controls.Add(this.teksifreTbox);
            this.Controls.Add(this.sifreTbox);
            this.Controls.Add(this.kuladTbox);
            this.Controls.Add(this.telTbox);
            this.Controls.Add(this.emailTbox);
            this.Controls.Add(this.adTbox);
            this.Controls.Add(this.kayitBtn);
            this.Name = "kayitform";
            this.Text = "Kayıt Sayfası";
            this.Load += new System.EventHandler(this.kayitform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kayitBtn;
        private System.Windows.Forms.TextBox adTbox;
        private System.Windows.Forms.TextBox emailTbox;
        private System.Windows.Forms.TextBox telTbox;
        private System.Windows.Forms.TextBox kuladTbox;
        private System.Windows.Forms.TextBox sifreTbox;
        private System.Windows.Forms.TextBox teksifreTbox;
        private System.Windows.Forms.TextBox adresTbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teksifreLbl;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label kuladLbl;
        private System.Windows.Forms.Label adresLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label adLbl;
    }
}