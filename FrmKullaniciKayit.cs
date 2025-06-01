using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKullaniciKayit : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKullaniciKayit()
        {
            InitializeComponent();
            cmbYetki.Items.AddRange(new string[] { "Üye", "Çalışan", "Admin" });
            cmbYetki.SelectedIndex = 0;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;
            string yetki = cmbYetki.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection conn = sql.Baglanti();

                // Kullanıcı adı kontrolü
                SqlCommand kontrol = new SqlCommand("SELECT COUNT(*) FROM tbl_Kullanicilar WHERE KullaniciAdi = @kadi", conn);
                kontrol.Parameters.AddWithValue("@kadi", kullaniciAdi);

                int count = (int)kontrol.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sql.BaglantiKapat();
                    return;
                }

                SqlCommand komut = new SqlCommand("INSERT INTO tbl_Kullanicilar (KullaniciAdi, Sifre, Yetki) VALUES (@kadi, @sifre, @yetki)", conn);
                komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);
                komut.Parameters.AddWithValue("@yetki", yetki);

                komut.ExecuteNonQuery();
                sql.BaglantiKapat();

                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtSifreTekrar.Clear();
            cmbYetki.SelectedIndex = 0;
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            bool goster = chkSifreGoster.Checked;
            txtSifre.UseSystemPasswordChar = !goster;
            txtSifreTekrar.UseSystemPasswordChar = !goster;
        }
    }
}
