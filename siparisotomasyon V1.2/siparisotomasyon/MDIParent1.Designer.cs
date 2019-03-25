namespace siparisotomasyon
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girişToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.giriskapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.sifreTbox = new System.Windows.Forms.TextBox();
            this.kuladTbox = new System.Windows.Forms.TextBox();
            this.şifreLbl = new System.Windows.Forms.Label();
            this.adLbl = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 525);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girişToolStripMenuItem,
            this.kayıtToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.formToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // girişToolStripMenuItem
            // 
            this.girişToolStripMenuItem.Name = "girişToolStripMenuItem";
            this.girişToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.girişToolStripMenuItem.Text = "Giriş";
            this.girişToolStripMenuItem.Click += new System.EventHandler(this.girişToolStripMenuItem_Click);
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            this.kayıtToolStripMenuItem.Click += new System.EventHandler(this.kayıtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.giriskapat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.girisBtn);
            this.panel1.Controls.Add(this.sifreTbox);
            this.panel1.Controls.Add(this.kuladTbox);
            this.panel1.Controls.Add(this.şifreLbl);
            this.panel1.Controls.Add(this.adLbl);
            this.panel1.Location = new System.Drawing.Point(400, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 255);
            this.panel1.TabIndex = 4;
            // 
            // giriskapat
            // 
            this.giriskapat.Location = new System.Drawing.Point(222, 0);
            this.giriskapat.Name = "giriskapat";
            this.giriskapat.Size = new System.Drawing.Size(27, 23);
            this.giriskapat.TabIndex = 11;
            this.giriskapat.Text = "x";
            this.giriskapat.UseVisualStyleBackColor = true;
            this.giriskapat.Click += new System.EventHandler(this.giriskapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(83, 227);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(140, 23);
            this.girisBtn.TabIndex = 9;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // sifreTbox
            // 
            this.sifreTbox.Location = new System.Drawing.Point(82, 182);
            this.sifreTbox.Name = "sifreTbox";
            this.sifreTbox.Size = new System.Drawing.Size(141, 20);
            this.sifreTbox.TabIndex = 8;
            this.sifreTbox.UseSystemPasswordChar = true;
            // 
            // kuladTbox
            // 
            this.kuladTbox.Location = new System.Drawing.Point(82, 156);
            this.kuladTbox.Name = "kuladTbox";
            this.kuladTbox.Size = new System.Drawing.Size(141, 20);
            this.kuladTbox.TabIndex = 7;
            // 
            // şifreLbl
            // 
            this.şifreLbl.AutoSize = true;
            this.şifreLbl.Location = new System.Drawing.Point(30, 182);
            this.şifreLbl.Name = "şifreLbl";
            this.şifreLbl.Size = new System.Drawing.Size(31, 13);
            this.şifreLbl.TabIndex = 6;
            this.şifreLbl.Text = "Şifre:";
            this.şifreLbl.Click += new System.EventHandler(this.şifreLbl_Click);
            // 
            // adLbl
            // 
            this.adLbl.AutoSize = true;
            this.adLbl.Location = new System.Drawing.Point(30, 156);
            this.adLbl.Name = "adLbl";
            this.adLbl.Size = new System.Drawing.Size(23, 13);
            this.adLbl.TabIndex = 5;
            this.adLbl.Text = "Ad:";
            this.adLbl.Click += new System.EventHandler(this.adLbl_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1027, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Location = new System.Drawing.Point(250, 250);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "Sipariş Takip";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girişToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox sifreTbox;
        private System.Windows.Forms.TextBox kuladTbox;
        private System.Windows.Forms.Label şifreLbl;
        private System.Windows.Forms.Label adLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button giriskapat;
    }
}



