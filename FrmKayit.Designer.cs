namespace arayüz4
{
    partial class FrmKayit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtAdSoyad = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            cmbKullaniciTuru = new ComboBox();
            btnKaydet = new Button();
            lblAdSoyad = new Label();
            lblEmail = new Label();
            lblTelefon = new Label();
            lblAdres = new Label();
            lblKullaniciTuru = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(140, 30);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 23);
            txtAdSoyad.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(140, 110);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(200, 23);
            txtTelefon.TabIndex = 2;
            // 
            // cmbKullaniciTuru
            // 
            cmbKullaniciTuru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKullaniciTuru.FormattingEnabled = true;
            cmbKullaniciTuru.Items.AddRange(new object[] { "Gonderen", "Alici" });
            cmbKullaniciTuru.Location = new Point(140, 230);
            cmbKullaniciTuru.Name = "cmbKullaniciTuru";
            cmbKullaniciTuru.Size = new Size(200, 23);
            cmbKullaniciTuru.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Teal;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(140, 270);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(200, 35);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(50, 30);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(60, 15);
            lblAdSoyad.TabIndex = 6;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(50, 110);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(48, 15);
            lblTelefon.TabIndex = 8;
            lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            lblAdres.AutoSize = true;
            lblAdres.Location = new Point(50, 150);
            lblAdres.Name = "lblAdres";
            lblAdres.Size = new Size(40, 15);
            lblAdres.TabIndex = 9;
            lblAdres.Text = "Adres:";
            // 
            // lblKullaniciTuru
            // 
            lblKullaniciTuru.AutoSize = true;
            lblKullaniciTuru.Location = new Point(50, 230);
            lblKullaniciTuru.Name = "lblKullaniciTuru";
            lblKullaniciTuru.Size = new Size(82, 15);
            lblKullaniciTuru.TabIndex = 10;
            lblKullaniciTuru.Text = "Kullanıcı Türü:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 150);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "ULKE SEC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 150);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "SEHIR SEC";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(140, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(102, 23);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(248, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 23);
            comboBox2.TabIndex = 14;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // FrmKayit
            // 
            ClientSize = new Size(400, 330);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(cmbKullaniciTuru);
            Controls.Add(btnKaydet);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdres);
            Controls.Add(lblKullaniciTuru);
            MaximizeBox = false;
            Name = "FrmKayit";
            Text = "Kullanıcı Kayıt";
            Load += FrmKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox cmbKullaniciTuru;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblKullaniciTuru;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
