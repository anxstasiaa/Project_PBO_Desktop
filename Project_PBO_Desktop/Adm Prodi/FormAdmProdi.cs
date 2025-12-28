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
    public partial class FormAdmProdi : Form
    {
        public FormAdmProdi()
        {
            InitializeComponent();
        }

        private void buttonDaftarMhs_Click(object sender, EventArgs e)
        {
            var f = new FormDaftarMhs();
            f.Show();
        }

        private void buttonKelolaMK_Click(object sender, EventArgs e)
        {
            var f = new FormKelolaMK();
            f.Show();
        }

        private void buttonKelolaKK_Click(object sender, EventArgs e)
        {
            var f = new FormKelolaKK();
            f.Show();
        }

        private void buttonKelolaSmt_Click(object sender, EventArgs e)
        {
            var f = new FormKelolaSmt();
            f.Show();
        }

        private void buttonDaftarProdi_Click(object sender, EventArgs e)
        {
            var f = new FormDaftarProdi();
            f.Show();
        }

        private void buttonLogoutAdmProdi_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var login = new FormLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Close();
        }

        private void FormAdmProdi_Load(object sender, EventArgs e)
        {

        }
    }
}
