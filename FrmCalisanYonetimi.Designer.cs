namespace arayüz4
{
    partial class FrmCalisanYonetimi
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(30, 30);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(80, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(130, 30);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.PlaceholderText = "Ad Soyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(30, 70);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.PlaceholderText = "Görev";
            this.txtGorev.Size = new System.Drawing.Size(150, 22);
            this.txtGorev.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(200, 70);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PlaceholderText = "Telefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 22);
            this.txtTelefon.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(350, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(90, 25);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(350, 60);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 25);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(350, 90);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 25);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgvCalisanlar
            // 
            this.dgvCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(30, 130);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.RowHeadersVisible = false;
            this.dgvCalisanlar.RowTemplate.Height = 24;
            this.dgvCalisanlar.Size = new System.Drawing.Size(500, 250);
            this.dgvCalisanlar.TabIndex = 7;
            this.dgvCalisanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalisanlar_CellClick);
            // 
            // FrmCalisanYonetimi
            // 
            this.ClientSize = new System.Drawing.Size(580, 410);
            this.Controls.Add(this.dgvCalisanlar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCalisanYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Yönetimi";
            this.Load += new System.EventHandler(this.FrmCalisanYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
    }
}
