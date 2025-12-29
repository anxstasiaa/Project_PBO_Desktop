using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public static class DatabaseHelper
    {
        // Connection String - SESUAIKAN dengan setting MySQL Anda
        private static string connectionString =
            "Server=localhost;" +
            "Port=3306;" +
            "Database=PBO_Siadik;" +
            "Uid=root;" +
            "Pwd=;" + // Kosongkan jika tidak ada password
            "SslMode=none;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error koneksi database: {ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Koneksi database gagal!\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
