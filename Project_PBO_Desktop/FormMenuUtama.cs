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
    public partial class PBO : Form
    {
        public PBO()
        {
            InitializeComponent();
        }

        private void labelMenuUtama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu Utama", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelLogin_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new FormLogin();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

        private void linkLabelRegister_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PBO_Load(object sender, EventArgs e)
        {

        }
    }
}
