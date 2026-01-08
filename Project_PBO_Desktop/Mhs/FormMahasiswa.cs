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
    public partial class FormMahasiswa : Form
    {
        public FormMahasiswa()
        {
            InitializeComponent();
        }

        private void labelMahasiswa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mahasiswa", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonKRS_Click(object sender, EventArgs e)
        {
            var f = new FormKRS();
            f.Show();
        }

        private void buttonKHS_Click(object sender, EventArgs e)
        {
            var f = new FormKHS();
            f.Show();
        }

        private void buttonTagihan_Click(object sender, EventArgs e)
        {
            var f = new FormTagihan();
            f.Show();
        }

        private void buttonLogoutMhs_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var login = new FormLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Close();
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewKK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

