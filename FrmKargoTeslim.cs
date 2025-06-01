using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKargoTeslim : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKargoTeslim()
        {
            InitializeComponent();
        }

        private void FrmKargoTeslim_Load(object sender, EventArgs e)
        {
            KargolariGetir();
        }

        private void KargolariGetir()
        {
            try
            {
                sql.Baglanti();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT KargoID, Gonderen, Alici, Durum FROM tbl_Kargolar WHERE Durum = 'Yolda'", sql.Baglanti());
                da.Fill(dt);
                dgvTeslimEdilecek.DataSource = dt;
                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sql.BaglantiKapat();
            }
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (dgvTeslimEdilecek.SelectedRows.Count > 0)
            {
                int kargoID = Convert.ToInt32(dgvTeslimEdilecek.SelectedRows[0].Cells["KargoID"].Value);

                try
                {
                    sql.Baglanti();
                    SqlCommand cmd = new SqlCommand("UPDATE tbl_Kargolar SET Durum = 'Teslim Edildi' WHERE KargoID = @id", sql.Baglanti());
                    cmd.Parameters.AddWithValue("@id", kargoID);
                    cmd.ExecuteNonQuery();
                    sql.BaglantiKapat();

                    MessageBox.Show("Kargo başarıyla teslim edildi.");
                    KargolariGetir();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    sql.BaglantiKapat();
                }
            }
            else
            {
                MessageBox.Show("Lütfen teslim edilecek bir kargo seçiniz.");
            }
        }
    }
}
