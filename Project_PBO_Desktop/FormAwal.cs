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

                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
               
            }
        }

        private void FormAwal_Load(object sender, EventArgs e)
        {
            if (DbConnection.TestConnection())
            {
                MessageBox.Show("Koneksi database berhasil!", "Info");
            }
        }
    }
}
