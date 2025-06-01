using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmGiris : Form
    {
        SqlBaglantim sql = new SqlBaglantim();
        int denemeHakki = 3;

        public FrmGiris()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifreyi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlConnection conn = sql.Baglanti();
                SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Kullanicilar WHERE KullaniciAdi = @kadi AND Sifre = @sifre", conn);
                komut.Parameters.AddWithValue("@kadi", kullaniciAdi);
                komut.Parameters.AddWithValue("@sifre", sifre);

                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        string yetki = dr["Yetki"].ToString();  // DÜZELTİLDİ: KullaniciTuru yerine Yetki

                        MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();

                        if (yetki == "Admin")
                        {
                            new FrmAdminPanel().Show();
                        }
                        else if (yetki == "Çalışan")
                        {
                            new FrmUyePanel().Show();
                        }
                        else if (yetki == "Üye")
                        {
                            new FrmPanel().Show();
                        }
                        else
                        {
                            MessageBox.Show("Tanımsız kullanıcı yetkisi: " + yetki, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        denemeHakki--;
                        MessageBox.Show($"Kullanıcı adı veya şifre yanlış.\nKalan deneme hakkı: {denemeHakki}", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        if (denemeHakki == 0)
                        {
                            MessageBox.Show("3 kez hatalı giriş yaptınız. Uygulama kapanıyor.", "Giriş Engellendi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Application.Exit();
                        }
                    }
                }

                sql.BaglantiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.UseSystemPasswordChar = !chkSifreGoster.Checked;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            new FrmKullaniciKayit().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullaniciKayit frmKullaniciKayit = new FrmKullaniciKayit();
            frmKullaniciKayit.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void FrmGiris_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
            lblSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

        }
    }
}
