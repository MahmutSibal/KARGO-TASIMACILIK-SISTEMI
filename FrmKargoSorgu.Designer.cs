namespace arayüz4
{
    partial class FrmKargoSorgu
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
            txtArama = new TextBox();
            cmbAramaKriteri = new ComboBox();
            btnAra = new Button();
            dgvSonuc = new DataGridView();
            lblKriter = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).BeginInit();
            SuspendLayout();
            // 
            // txtArama
            // 
            txtArama.Location = new Point(230, 25);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(200, 23);
            txtArama.TabIndex = 0;
            // 
            // cmbAramaKriteri
            // 
            cmbAramaKriteri.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAramaKriteri.FormattingEnabled = true;
            cmbAramaKriteri.Items.AddRange(new object[] { "Kargo ID", "Gönderen", "Alıcı" });
            cmbAramaKriteri.Location = new Point(100, 25);
            cmbAramaKriteri.Name = "cmbAramaKriteri";
            cmbAramaKriteri.Size = new Size(120, 23);
            cmbAramaKriteri.TabIndex = 1;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(450, 22);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(90, 28);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // dgvSonuc
            // 
            dgvSonuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonuc.Location = new Point(12, 70);
            dgvSonuc.Name = "dgvSonuc";
            dgvSonuc.RowHeadersVisible = false;
            dgvSonuc.RowTemplate.Height = 24;
            dgvSonuc.Size = new Size(620, 300);
            dgvSonuc.TabIndex = 3;
            // 
            // lblKriter
            // 
            lblKriter.AutoSize = true;
            lblKriter.Location = new Point(20, 30);
            lblKriter.Name = "lblKriter";
            lblKriter.Size = new Size(72, 15);
            lblKriter.TabIndex = 4;
            lblKriter.Text = "Arama Türü:";
            // 
            // FrmKargoSorgu
            // 
            ClientSize = new Size(644, 390);
            Controls.Add(lblKriter);
            Controls.Add(dgvSonuc);
            Controls.Add(btnAra);
            Controls.Add(cmbAramaKriteri);
            Controls.Add(txtArama);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmKargoSorgu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kargo Sorgulama";
            Load += FrmKargoSorgu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSonuc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cmbAramaKriteri;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvSonuc;
        private System.Windows.Forms.Label lblKriter;
    }
}
