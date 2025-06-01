using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmKargoKayit : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmKargoKayit()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtGonderen.Text == "" || txtAlici.Text == "" || cmbDurum.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                sql.Baglanti();
                string sorgu = "INSERT INTO tbl_Kargolar (Gonderen, Alici, Durum, KayitTarihi) VALUES (@gonderen, @alici, @durum, @tarih)";
                SqlCommand komut = new SqlCommand(sorgu, sql.Baglanti());
                komut.Parameters.AddWithValue("@gonderen", txtGonderen.Text);
                komut.Parameters.AddWithValue("@alici", txtAlici.Text);
                komut.Parameters.AddWithValue("@durum", cmbDurum.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                komut.ExecuteNonQuery();
                sql.BaglantiKapat();

                MessageBox.Show("Kargo kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sql.BaglantiKapat();
            }
        }

        private void Temizle()
        {
            txtGonderen.Clear();
            txtAlici.Clear();
            cmbDurum.SelectedIndex = -1;
        }
    }
}
