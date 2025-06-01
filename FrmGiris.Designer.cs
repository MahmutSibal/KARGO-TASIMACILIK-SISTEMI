namespace arayüz4
{
    partial class FrmGiris
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            chkSifreGoster = new CheckBox();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblSaat = new Label();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(45, 40);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(45, 80);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(150, 37);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(180, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(150, 77);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(180, 23);
            txtSifre.TabIndex = 3;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(45, 144);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(180, 30);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.Location = new Point(150, 110);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(95, 19);
            chkSifreGoster.TabIndex = 5;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(248, 144);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 6;
            button1.Text = "Uye Ol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.Location = new Point(209, 5);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(0, 15);
            lblSaat.TabIndex = 7;
            // 
            // FrmGiris
            // 
            AcceptButton = btnGiris;
            ClientSize = new Size(400, 200);
            Controls.Add(lblSaat);
            Controls.Add(button1);
            Controls.Add(chkSifreGoster);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kargo Takip Sistemi - Giriş";
            Load += FrmGiris_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.CheckBox chkSifreGoster;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label lblSaat;
    }
}
