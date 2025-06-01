namespace arayüz4
{
    partial class FrmKullaniciSorgu
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
            this.cmbKriter = new System.Windows.Forms.ComboBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvSonuclar = new System.Windows.Forms.DataGridView();
            this.lblKriter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKriter
            // 
            this.cmbKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKriter.FormattingEnabled = true;
            this.cmbKriter.Items.AddRange(new object[] {
            "ID",
            "Ad",
            "Soyad",
            "Email"});
            this.cmbKriter.Location = new System.Drawing.Point(100, 25);
            this.cmbKriter.Name = "cmbKriter";
            this.cmbKriter.Size = new System.Drawing.Size(121, 24);
            this.cmbKriter.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(230, 25);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 22);
            this.txtArama.TabIndex = 1;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(450, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 30);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dgvSonuclar
            // 
            this.dgvSonuclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSonuclar.Location = new System.Drawing.Point(12, 70);
            this.dgvSonuclar.Name = "dgvSonuclar";
            this.dgvSonuclar.RowHeadersVisible = false;
            this.dgvSonuclar.RowTemplate.Height = 24;
            this.dgvSonuclar.Size = new System.Drawing.Size(600, 300);
            this.dgvSonuclar.TabIndex = 3;
            // 
            // lblKriter
            // 
            this.lblKriter.AutoSize = true;
            this.lblKriter.Location = new System.Drawing.Point(20, 30);
            this.lblKriter.Name = "lblKriter";
            this.lblKriter.Size = new System.Drawing.Size(74, 17);
            this.lblKriter.TabIndex = 4;
            this.lblKriter.Text = "Arama Türü:";
            // 
            // FrmKullaniciSorgu
            // 
            this.ClientSize = new System.Drawing.Size(630, 390);
            this.Controls.Add(this.lblKriter);
            this.Controls.Add(this.dgvSonuclar);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.cmbKriter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmKullaniciSorgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Sorgulama";
            this.Load += new System.EventHandler(this.FrmKullaniciSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSonuclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKriter;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvSonuclar;
        private System.Windows.Forms.Label lblKriter;
    }
}
