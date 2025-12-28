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
    public partial class FormAdmUniv : Form
    {
        public FormAdmUniv()
        {
            InitializeComponent();
        }

        private void buttonManajemenProdi_Click(object sender, EventArgs e)
        {
            var f = new FormManajemenProdi();
            f.Show();
        }

        private void buttonManajemenMhs_Click(object sender, EventArgs e)
        {
            var f = new FormManajemenMhs();
            f.Show();
        }

        private void buttonLogoutAdmUniv_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var login = new FormLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Close();
        }
    }
}
