namespace arayüz4
{
    partial class FrmKargoTasima
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
            this.dgvKargolar = new System.Windows.Forms.DataGridView();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDurumGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKargolar
            // 
            this.dgvKargolar.AllowUserToAddRows = false;
            this.dgvKargolar.AllowUserToDeleteRows = false;
            this.dgvKargolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKargolar.Location = new System.Drawing.Point(12, 12);
            this.dgvKargolar.Name = "dgvKargolar";
            this.dgvKargolar.ReadOnly = true;
            this.dgvKargolar.RowHeadersVisible = false;
            this.dgvKargolar.RowTemplate.Height = 24;
            this.dgvKargolar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKargolar.Size = new System.Drawing.Size(600, 250);
            this.dgvKargolar.TabIndex = 0;
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Teslim Edildi",
            "İade Edildi"});
            this.cmbDurum.Location = new System.Drawing.Point(130, 280);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 24);
            this.cmbDurum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Durum Seç:";
            // 
            // btnDurumGuncelle
            // 
            this.btnDurumGuncelle.Location = new System.Drawing.Point(350, 275);
            this.btnDurumGuncelle.Name = "btnDurumGuncelle";
            this.btnDurumGuncelle.Size = new System.Drawing.Size(150, 30);
            this.btnDurumGuncelle.TabIndex = 3;
            this.btnDurumGuncelle.Text = "Durumu Güncelle";
            this.btnDurumGuncelle.UseVisualStyleBackColor = true;
            this.btnDurumGuncelle.Click += new System.EventHandler(this.btnDurumGuncelle_Click);
            // 
            // FrmKargoTasima
            // 
            this.ClientSize = new System.Drawing.Size(630, 330);
            this.Controls.Add(this.btnDurumGuncelle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.dgvKargolar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmKargoTasima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Taşıma ve Durum Takibi";
            this.Load += new System.EventHandler(this.FrmKargoTasima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKargolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKargolar;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDurumGuncelle;
    }
}
