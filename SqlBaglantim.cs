using System;
using Microsoft.Data.SqlClient;

namespace arayüz4
{
    class SqlBaglantim
    {
        // SQL bağlantı nesnesi
        private SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-9CFGOH6; Initial Catalog=KargoTakipSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        // Bağlantıyı açan metot
        public SqlConnection Baglanti()
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                return baglanti;
            }
            catch (SqlException ex)
            {
                // Hata mesajını kullanıcıya göster
                throw new Exception("SQL Bağlantı hatası: " + ex.Message);
            }
        }

        // Bağlantıyı kapatan metot (isteğe bağlı)
        public void BaglantiKapat()
        {
            try
            {
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            catch (SqlException ex)
            {
                // Hata mesajını kullanıcıya göster
                throw new Exception("SQL Bağlantıyı kapatma hatası: " + ex.Message);
            }
        }
    }
}