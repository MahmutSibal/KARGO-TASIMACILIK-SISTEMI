using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKargoTasima : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKargoTasima()
        {
            InitializeComponent();
        }

        private void FrmKargoTasima_Load(object sender, EventArgs e)
        {
            KargolariListele();
        }

        private void KargolariListele()
        {
            try
            {
                DataTable dt = new DataTable();
                sql.Baglanti();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Kargolar WHERE Durum = 'Yolda'", sql.Baglanti());
                da.Fill(dt);
                dgvKargolar.DataSource = dt;
                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sql.BaglantiKapat();
            }
        }

        private void btnDurumGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKargolar.SelectedRows.Count > 0)
            {
                int kargoID = Convert.ToInt32(dgvKargolar.SelectedRows[0].Cells["KargoID"].Value);
                string yeniDurum = cmbDurum.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(yeniDurum))
                {
                    MessageBox.Show("Lütfen yeni bir durum seçiniz.");
                    return;
                }

                try
                {
                    sql.Baglanti();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Kargolar SET Durum=@durum WHERE KargoID=@id", sql.Baglanti());
                    cmd.Parameters.AddWithValue("@durum", yeniDurum);
                    cmd.Parameters.AddWithValue("@id", kargoID);
                    cmd.ExecuteNonQuery();
                    sql.BaglantiKapat();

                    MessageBox.Show("Durum başarıyla güncellendi.");
                    KargolariListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    sql.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir kargo seçiniz.");
            }
        }
    }
}
