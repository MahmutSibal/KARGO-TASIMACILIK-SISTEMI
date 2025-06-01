using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmCalisanYonetimi : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmCalisanYonetimi()
        {
            InitializeComponent();
        }

        void CalisanListele()
        {
            DataTable dt = new DataTable();
            sql.Baglanti();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Calisanlar", sql.Baglanti());
            da.Fill(dt);
            dgvCalisanlar.DataSource = dt;
            sql.BaglantiKapat();
        }

        private void FrmCalisanYonetimi_Load(object sender, EventArgs e)
        {
            CalisanListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sql.Baglanti();
            SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Calisanlar (AdSoyad, Gorev, Telefon) VALUES (@ad, @gorev, @tel)", sql.Baglanti());
            cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@gorev", txtGorev.Text);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.ExecuteNonQuery();
            sql.BaglantiKapat();
            CalisanListele();
            MessageBox.Show("Çalışan eklendi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            sql.Baglanti();
            SqlCommand cmd = new SqlCommand("UPDATE tbl_Calisanlar SET AdSoyad=@ad, Gorev=@gorev, Telefon=@tel WHERE CalisanID=@id", sql.Baglanti());
            cmd.Parameters.AddWithValue("@ad", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@gorev", txtGorev.Text);
            cmd.Parameters.AddWithValue("@tel", txtTelefon.Text);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();
            sql.BaglantiKapat();
            CalisanListele();
            MessageBox.Show("Çalışan bilgileri güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "") return;

            sql.Baglanti();
            SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Calisanlar WHERE CalisanID=@id", sql.Baglanti());
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.ExecuteNonQuery();
            sql.BaglantiKapat();
            CalisanListele();
            MessageBox.Show("Çalışan silindi.");
        }

        private void dgvCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvCalisanlar.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAdSoyad.Text = dgvCalisanlar.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGorev.Text = dgvCalisanlar.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefon.Text = dgvCalisanlar.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
