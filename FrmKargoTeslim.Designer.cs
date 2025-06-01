namespace arayüz4
{
    partial class FrmKargoTeslim
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
            this.dgvTeslimEdilecek = new System.Windows.Forms.DataGridView();
            this.btnTeslimEt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeslimEdilecek)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeslimEdilecek
            // 
            this.dgvTeslimEdilecek.AllowUserToAddRows = false;
            this.dgvTeslimEdilecek.AllowUserToDeleteRows = false;
            this.dgvTeslimEdilecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeslimEdilecek.Location = new System.Drawing.Point(12, 12);
            this.dgvTeslimEdilecek.MultiSelect = false;
            this.dgvTeslimEdilecek.Name = "dgvTeslimEdilecek";
            this.dgvTeslimEdilecek.ReadOnly = true;
            this.dgvTeslimEdilecek.RowHeadersVisible = false;
            this.dgvTeslimEdilecek.RowTemplate.Height = 24;
            this.dgvTeslimEdilecek.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeslimEdilecek.Size = new System.Drawing.Size(600, 250);
            this.dgvTeslimEdilecek.TabIndex = 0;
            // 
            // btnTeslimEt
            // 
            this.btnTeslimEt.Location = new System.Drawing.Point(230, 280);
            this.btnTeslimEt.Name = "btnTeslimEt";
            this.btnTeslimEt.Size = new System.Drawing.Size(150, 35);
            this.btnTeslimEt.TabIndex = 1;
            this.btnTeslimEt.Text = "Teslim Et";
            this.btnTeslimEt.UseVisualStyleBackColor = true;
            this.btnTeslimEt.Click += new System.EventHandler(this.btnTeslimEt_Click);
            // 
            // FrmKargoTeslim
            // 
            this.ClientSize = new System.Drawing.Size(630, 330);
            this.Controls.Add(this.btnTeslimEt);
            this.Controls.Add(this.dgvTeslimEdilecek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmKargoTeslim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kargo Teslim";
            this.Load += new System.EventHandler(this.FrmKargoTeslim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeslimEdilecek)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeslimEdilecek;
        private System.Windows.Forms.Button btnTeslimEt;
    }
}
