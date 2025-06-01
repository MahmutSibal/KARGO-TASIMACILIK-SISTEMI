namespace arayüz4
{
    partial class FrmKargoKayit
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblGonderen = new System.Windows.Forms.Label();
            this.lblAlici = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtGonderen = new System.Windows.Forms.TextBox();
            this.txtAlici = new System.Windows.Forms.TextBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGonderen
            // 
            this.lblGonderen.AutoSize = true;
            this.lblGonderen.Location = new System.Drawing.Point(40, 40);
            this.lblGonderen.Name = "lblGonderen";
            this.lblGonderen.Size = new System.Drawing.Size(70, 17);
            this.lblGonderen.TabIndex = 0;
            this.lblGonderen.Text = "Gönderen:";
            // 
            // lblAlici
            // 
            this.lblAlici.AutoSize = true;
            this.lblAlici.Location = new System.Drawing.Point(40, 80);
            this.lblAlici.Name = "lblAlici";
            this.lblAlici.Size = new System.Drawing.Size(38, 17);
            this.lblAlici.TabIndex = 1;
            this.lblAlici.Text = "Alıcı:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(40, 120);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum:";
            // 
            // txtGonderen
            // 
            this.txtGonderen.Location = new System.Drawing.Point(130, 37);
            this.txtGonderen.Name = "txtGonderen";
            this.txtGonderen.Size = new System.Drawing.Size(180, 22);
            this.txtGonderen.TabIndex = 3;
            // 
            // txtAlici
            // 
            this.txtAlici.Location = new System.Drawing.Point(130, 77);
            this.txtAlici.Name = "txtAlici";
            this.txtAlici.Size = new System.Drawing.Size(180, 22);
            this.txtAlici.TabIndex = 4;
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Yolda",
            "Teslim Edildi",
            "İade Edildi"});
            this.cmbDurum.Location = new System.Drawing.Point(130, 117);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(180, 24);
            this.cmbDurum.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(130, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(180, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kargoyu Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmKargoKayit
            // 
            this.ClientSize = new System.Drawing.Size(370, 230);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.txtAlici);
            this.Controls.Add(this.txtGonderen);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblAlici);
            this.Controls.Add(this.lblGonderen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmKargoKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kargo Kaydı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblGonderen;
        private System.Windows.Forms.Label lblAlici;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtGonderen;
        private System.Windows.Forms.TextBox txtAlici;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnKaydet;
    }
}
