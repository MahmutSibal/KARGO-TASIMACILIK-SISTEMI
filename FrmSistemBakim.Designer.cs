namespace arayüz4
{
    partial class FrmSistemBakim
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
            this.btnYedekle = new System.Windows.Forms.Button();
            this.btnBakimBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYedekle
            // 
            this.btnYedekle.Location = new System.Drawing.Point(50, 80);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(180, 40);
            this.btnYedekle.TabIndex = 0;
            this.btnYedekle.Text = "Veritabanı Yedekle";
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // btnBakimBaslat
            // 
            this.btnBakimBaslat.Location = new System.Drawing.Point(260, 80);
            this.btnBakimBaslat.Name = "btnBakimBaslat";
            this.btnBakimBaslat.Size = new System.Drawing.Size(180, 40);
            this.btnBakimBaslat.TabIndex = 1;
            this.btnBakimBaslat.Text = "Sistem Bakımını Başlat";
            this.btnBakimBaslat.UseVisualStyleBackColor = true;
            this.btnBakimBaslat.Click += new System.EventHandler(this.btnBakimBaslat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(50, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 40);
            this.label1.Text = "Sistem bakımı ve veritabanı yedekleme işlemleri";
            // 
            // FrmSistemBakim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 160);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBakimBaslat);
            this.Controls.Add(this.btnYedekle);
            this.Name = "FrmSistemBakim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistem Bakım";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.Button btnBakimBaslat;
        private System.Windows.Forms.Label label1;
    }
}
