using System;
using System.IO;
using System.Windows.Forms;

namespace arayüz4
{
    public partial class FrmSistemBakim : Form
    {
        public FrmSistemBakim()
        {
            InitializeComponent();
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "SQL Backup Files|*.bak";
                saveFileDialog.Title = "Yedek Dosyasını Kaydet";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string yedekYolu = saveFileDialog.FileName;

                    string sqlBackupQuery = $@"
                        BACKUP DATABASE [KargoDB] TO DISK = '{yedekYolu}'
                        WITH FORMAT, MEDIANAME = 'KargoDBBackup', NAME = 'Full Backup of KargoDB'";

                    bool sonuc = SqlBackup(sqlBackupQuery);

                    if (sonuc)
                        MessageBox.Show("Veritabanı başarıyla yedeklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Yedekleme işlemi başarısız oldu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SqlBackup(string sqlCommand)
        {
            try
            {
                SqlBaglantim sql = new SqlBaglantim();
                using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(sqlCommand, sql.Baglanti()))
                {
                    cmd.CommandTimeout = 600; // 10 dakika
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Komut Hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                SqlBaglantim sql = new SqlBaglantim();
                sql.BaglantiKapat();
            }
        }

        private void btnBakimBaslat_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                DirectoryInfo di = new DirectoryInfo(tempPath);

                foreach (FileInfo file in di.GetFiles())
                {
                    try { file.Delete(); } catch { }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try { dir.Delete(true); } catch { }
                }

                MessageBox.Show("Sistem bakımı tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bakım sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
