using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public class DbConnection
    {
        // Connection string untuk XAMPP 
        private static string connectionString = "Server=localhost;Database=PBO_Siadik;Uid=root;Pwd=;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "❌ Koneksi Database Gagal!\n\n" +
                    "Error: " + ex.Message + "\n\n" +
                    "Checklist:\n" +
                    "☐ XAMPP MySQL sudah jalan?\n" +
                    "☐ Database 'PBO_Siadik' sudah dibuat?\n" +
                    "☐ Port 3306 tersedia?",
                    "Error Koneksi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return null;
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    if (conn == null) return false;

                    conn.Open();

                    // Test query
                    using (MySqlCommand cmd = new MySqlCommand("SELECT 1", conn))
                    {
                        cmd.ExecuteScalar();
                    }

                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "❌ Test koneksi gagal!\n\n" +
                    ex.Message + "\n\n" +
                    ex.InnerException?.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
    }
}