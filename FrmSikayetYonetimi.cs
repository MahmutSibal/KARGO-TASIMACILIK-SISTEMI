using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    public partial class FrmSikayetYonetimi : Form
    {
        SqlBaglantim sql = new SqlBaglantim();

        public FrmSikayetYonetimi()
        {
            InitializeComponent();
        }

        private void FrmSikayetYonetimi_Load(object sender, EventArgs e)
        {
            SikayetleriListele();
        }

        private void SikayetleriListele()
        {
            DataTable dt = new DataTable();
            sql.Baglanti();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_Sikayetler ORDER BY Tarih DESC", sql.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.BaglantiKapat();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            SikayetleriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçiniz.");
                return;
            }

            DialogResult dialog = MessageBox.Show("Seçili şikayet kaydı silinsin mi?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SikayetID"].Value);

                sql.Baglanti();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbl_Sikayetler WHERE SikayetID = @id", sql.Baglanti());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                sql.BaglantiKapat();

                MessageBox.Show("Kayıt silindi.");
                SikayetleriListele();
            }
        }
    }
}
