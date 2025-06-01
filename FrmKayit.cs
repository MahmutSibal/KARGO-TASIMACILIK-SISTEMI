using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace arayüz4
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim sql = new SqlBaglantim();

        private void FrmKayit_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("Amerika");
            comboBox2.Items.Add("Türkiye");

            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.SelectedIndex = 0; // Varsayılan ülke seç
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SehirleriYukle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Şehir değiştiğinde bir şey yapılmasına gerek yok şu an
        }

        private void SehirleriYukle()
        {
            comboBox1.Items.Clear();

            if (comboBox2.SelectedItem.ToString() == "Amerika")
            {
                comboBox1.Items.Add("New York");
                comboBox1.Items.Add("Los Angeles");
                comboBox1.Items.Add("Chicago");
            }
            else if (comboBox2.SelectedItem.ToString() == "Türkiye")
            {
                comboBox1.Items.Add("İstanbul");
                comboBox1.Items.Add("Ankara");
                comboBox1.Items.Add("İzmir");
            }

            comboBox1.SelectedIndex = 0; // İlk şehir otomatik seçilsin
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Adres artık ComboBox'lardan alınacağı için txtAdres yok
                if (txtAdSoyad.Text == "" || txtEmail.Text == "" || txtTelefon.Text == "" ||
                    comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || cmbKullaniciTuru.SelectedIndex == -1)
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Adres: Şehir + ", " + Ülke
                string adres = comboBox1.SelectedItem.ToString() + ", " + comboBox2.SelectedItem.ToString();

                sql.Baglanti();
                SqlCommand komut = new SqlCommand("INSERT INTO Kullanici (AdSoyad, Email, Telefon, Adres, KullaniciTuru) VALUES (@adsoyad, @email, @telefon, @adres, @tur)", sql.Baglanti());
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@adres", adres);
                komut.Parameters.AddWithValue("@tur", cmbKullaniciTuru.SelectedItem.ToString());
                komut.ExecuteNonQuery();
                sql.BaglantiKapat();

                MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sql.BaglantiKapat();
            }
        }

        private void Temizle()
        {
            txtAdSoyad.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            cmbKullaniciTuru.SelectedIndex = -1;

            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
    }
}
