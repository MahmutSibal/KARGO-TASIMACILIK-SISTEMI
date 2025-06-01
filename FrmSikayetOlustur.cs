using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmSikayetOlustur : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmSikayetOlustur()
        {
            InitializeComponent();
        }

        private void FrmSikayetOlustur_Load(object sender, EventArgs e)
        {
            try
            {
                cmbTakipNo.Items.Clear();
                var conn = sql.Baglanti();
                SqlCommand komut = new SqlCommand("SELECT TakipNo FROM tbl_Kargolar", conn);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbTakipNo.Items.Add(dr["TakipNo"].ToString());
                }
                dr.Close();
                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            // Alanların boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(cmbTakipNo.Text) ||
                string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtKonu.Text) ||
                string.IsNullOrWhiteSpace(rchMesaj.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            try
            {
                var conn = sql.Baglanti();

                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO tbl_Sikayetler (TakipNo, AdSoyad, Konu, Mesaj, Tarih) " +
                    "VALUES (@takip, @ad, @konu, @mesaj, @tarih)", conn);

                cmd.Parameters.AddWithValue("@takip", cmbTakipNo.Text.Trim());
                cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text.Trim());
                cmd.Parameters.AddWithValue("@konu", txtKonu.Text.Trim());
                cmd.Parameters.AddWithValue("@mesaj", rchMesaj.Text.Trim());
                cmd.Parameters.AddWithValue("@tarih", DateTime.Now);

                cmd.ExecuteNonQuery();
                sql.BaglantiKapat();

                MessageBox.Show("Şikayet başarıyla gönderildi.");
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şikayet gönderilirken hata oluştu: " + ex.Message);
            }
        }

        private void Temizle()
        {
            cmbTakipNo.Text = "";
            txtAdSoyad.Clear();
            txtKonu.Clear();
            rchMesaj.Clear();
        }
    }
}
