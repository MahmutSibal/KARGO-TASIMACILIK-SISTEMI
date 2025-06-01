using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKargoSorgu : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKargoSorgu()
        {
            InitializeComponent();
        }

        private void FrmKargoSorgu_Load(object sender, EventArgs e)
        {
            txtArama.Clear();
            cmbAramaKriteri.SelectedIndex = 0;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArama.Text))
            {
                MessageBox.Show("Lütfen bir arama terimi girin.");
                return;
            }

            string kriter = cmbAramaKriteri.SelectedItem.ToString();
            string sorgu = "";
            SqlCommand cmd = new SqlCommand();

            if (kriter == "Kargo ID")
            {
                sorgu = "SELECT * FROM tbl_Kargolar WHERE KargoID = @deger";
                cmd.Parameters.AddWithValue("@deger", txtArama.Text);
            }
            else if (kriter == "Gönderen")
            {
                sorgu = "SELECT * FROM tbl_Kargolar WHERE Gonderen LIKE @deger";
                cmd.Parameters.AddWithValue("@deger", "%" + txtArama.Text + "%");
            }
            else if (kriter == "Alıcı")
            {
                sorgu = "SELECT * FROM tbl_Kargolar WHERE Alici LIKE @deger";
                cmd.Parameters.AddWithValue("@deger", "%" + txtArama.Text + "%");
            }

            try
            {
                sql.Baglanti();
                cmd.Connection = sql.Baglanti();
                cmd.CommandText = sorgu;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSonuc.DataSource = dt;
                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                sql.BaglantiKapat();
            }
        }
    }
}
