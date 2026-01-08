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
    public partial class FormDosen : Form
    {
        public FormDosen()
        {
            InitializeComponent();
        }

        private void buttonLihatKelas_Click(object sender, EventArgs e)
        {
            var f = new FormLihatKelas();
            f.Show();
        }

        private void buttonInputNilai_Click(object sender, EventArgs e)
        {
            var f = new FormInputNilai();
            f.Show();
        }

        private void buttonLogoutDosen_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Anda yakin ingin logout?", "Konfirmasi Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            var login = new FormLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Show();

            this.Close();
        }

        private void FormDosen_Load(object sender, EventArgs e)
        {

        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
