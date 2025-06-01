namespace arayüz4
{
    partial class FrmSikayetOlustur
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
            cmbTakipNo = new ComboBox();
            txtAdSoyad = new TextBox();
            txtKonu = new TextBox();
            rchMesaj = new RichTextBox();
            btnGonder = new Button();
            lblTakipNo = new Label();
            lblAdSoyad = new Label();
            lblKonu = new Label();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // cmbTakipNo
            // 
            cmbTakipNo.FormattingEnabled = true;
            cmbTakipNo.Location = new Point(130, 30);
            cmbTakipNo.Name = "cmbTakipNo";
            cmbTakipNo.Size = new Size(200, 23);
            cmbTakipNo.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(130, 70);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(200, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtKonu
            // 
            txtKonu.Location = new Point(130, 110);
            txtKonu.Name = "txtKonu";
            txtKonu.Size = new Size(200, 23);
            txtKonu.TabIndex = 2;
            // 
            // rchMesaj
            // 
            rchMesaj.Location = new Point(130, 150);
            rchMesaj.Name = "rchMesaj";
            rchMesaj.Size = new Size(300, 100);
            rchMesaj.TabIndex = 3;
            rchMesaj.Text = "";
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(130, 270);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(100, 30);
            btnGonder.TabIndex = 4;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // lblTakipNo
            // 
            lblTakipNo.AutoSize = true;
            lblTakipNo.Location = new Point(30, 33);
            lblTakipNo.Name = "lblTakipNo";
            lblTakipNo.Size = new Size(56, 15);
            lblTakipNo.TabIndex = 5;
            lblTakipNo.Text = "Takip No:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(30, 73);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(60, 15);
            lblAdSoyad.TabIndex = 6;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblKonu
            // 
            lblKonu.AutoSize = true;
            lblKonu.Location = new Point(30, 113);
            lblKonu.Name = "lblKonu";
            lblKonu.Size = new Size(38, 15);
            lblKonu.TabIndex = 7;
            lblKonu.Text = "Konu:";
            // 
            // lblMesaj
            // 
            lblMesaj.AutoSize = true;
            lblMesaj.Location = new Point(30, 153);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(41, 15);
            lblMesaj.TabIndex = 8;
            lblMesaj.Text = "Mesaj:";
            // 
            // FrmSikayetOlustur
            // 
            ClientSize = new Size(480, 330);
            Controls.Add(lblMesaj);
            Controls.Add(lblKonu);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblTakipNo);
            Controls.Add(btnGonder);
            Controls.Add(rchMesaj);
            Controls.Add(txtKonu);
            Controls.Add(txtAdSoyad);
            Controls.Add(cmbTakipNo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmSikayetOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şikayet Oluştur";
            Load += FrmSikayetOlustur_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTakipNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.RichTextBox rchMesaj;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label lblTakipNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblMesaj;
    }
}
