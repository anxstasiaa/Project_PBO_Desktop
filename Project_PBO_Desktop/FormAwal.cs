using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public partial class FormAwal: Form
    {
        public FormAwal()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 6;

            if(panel2.Width >= 800)
            {
                timer1.Stop();

                var menuUtama = new FormMenuUtama();
                menuUtama.StartPosition = FormStartPosition.CenterScreen;
                menuUtama.Show();

                this.Hide();

            }

        }
     

        private void FormAwal_Load(object sender, EventArgs e)
        {
            

            // Test koneksi saat aplikasi pertama kali dibuka
            //if (DbConnection.TestConnection())
            //{
            //    MessageBox.Show(
            //        "✓ Koneksi Database Berhasil!\n\n" +
            //        "Database: PBO_Siadik\n" +
            //        "Server: localhost:3306",
            //        "Sukses",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //    );
            //}
            //else
            //{
            //    MessageBox.Show(
            //        "✗ Koneksi Database Gagal!\n\n" +
            //        "Pastikan:\n" +
            //        "1. XAMPP MySQL sudah running\n" +
            //        "2. Database 'PBO_Siadik' sudah dibuat\n" +
            //        "3. Buka phpMyAdmin: http://localhost/phpmyadmin",
            //        "Error",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Warning
            //   );
        }
        }
    }

