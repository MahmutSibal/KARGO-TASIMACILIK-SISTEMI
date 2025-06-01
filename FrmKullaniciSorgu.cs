using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKullaniciSorgu : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKullaniciSorgu()
        {
            InitializeComponent();
        }

        private void FrmKullaniciSorgu_Load(object sender, EventArgs e)
        {
            cmbKriter.SelectedIndex = 0;
            txtArama.Clear();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArama.Text))
            {
                MessageBox.Show("Lütfen bir arama değeri giriniz.");
                return;
            }

            string kriter = cmbKriter.SelectedItem.ToString();
            string query = "";
            SqlCommand cmd = new SqlCommand();

            switch (kriter)
            {
                case "ID":
                    query = "SELECT * FROM tbl_Kullanicilar WHERE KullaniciID = @deger";
                    cmd.Parameters.AddWithValue("@deger", txtArama.Text);
                    break;
                case "Ad":
                    query = "SELECT * FROM tbl_Kullanicilar WHERE Ad LIKE @deger";
                    cmd.Parameters.AddWithValue("@deger", "%" + txtArama.Text + "%");
                    break;
                case "Soyad":
                    query = "SELECT * FROM tbl_Kullanicilar WHERE Soyad LIKE @deger";
                    cmd.Parameters.AddWithValue("@deger", "%" + txtArama.Text + "%");
                    break;
                case "Email":
                    query = "SELECT * FROM tbl_Kullanicilar WHERE Email LIKE @deger";
                    cmd.Parameters.AddWithValue("@deger", "%" + txtArama.Text + "%");
                    break;
            }

            try
            {
                sql.Baglanti();
                cmd.Connection = sql.Baglanti();
                cmd.CommandText = query;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSonuclar.DataSource = dt;
                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                sql.BaglantiKapat();
            }
        }
    }
}
