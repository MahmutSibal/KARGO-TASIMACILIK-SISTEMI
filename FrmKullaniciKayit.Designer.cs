namespace arayüz4
{
    partial class FrmKullaniciKayit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.CheckBox chkSifreGoster;
        private System.Windows.Forms.ComboBox cmbYetki;
        private System.Windows.Forms.Label lblYetki;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            lblSifreTekrar = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            btnKayitOl = new Button();
            chkSifreGoster = new CheckBox();
            lblYetki = new Label();
            cmbYetki = new ComboBox();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(26, 23);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(26, 61);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Location = new Point(26, 98);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(67, 15);
            lblSifreTekrar.TabIndex = 2;
            lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(114, 21);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(176, 23);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(114, 58);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(176, 23);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(114, 96);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(176, 23);
            txtSifreTekrar.TabIndex = 6;
            txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(115, 158);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(175, 28);
            btnKayitOl.TabIndex = 8;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(115, 210);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(95, 19);
            chkSifreGoster.TabIndex = 9;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // lblYetki
            // 
            lblYetki.AutoSize = true;
            lblYetki.Location = new Point(26, 130);
            lblYetki.Name = "lblYetki";
            lblYetki.Size = new Size(35, 15);
            lblYetki.TabIndex = 3;
            lblYetki.Text = "Yetki:";
            // 
            // cmbYetki
            // 
            cmbYetki.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYetki.Location = new Point(114, 127);
            cmbYetki.Name = "cmbYetki";
            cmbYetki.Size = new Size(176, 23);
            cmbYetki.TabIndex = 7;
            // 
            // FrmKullaniciKayit
            // 
            AcceptButton = btnKayitOl;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 262);
            Controls.Add(chkSifreGoster);
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifreTekrar);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblYetki);
            Controls.Add(cmbYetki);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmKullaniciKayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
