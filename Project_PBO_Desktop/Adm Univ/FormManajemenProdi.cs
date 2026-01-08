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
    public partial class FormManajemenProdi : Form
    {
        public FormManajemenProdi()
        {
            InitializeComponent();
        }

        private void FormManajemenProdi_Load(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {

        }

        private void buttonDaftarProdi_Click(object sender, EventArgs e)
        {
            var dp = new FormDaftarProdi();
            dp.StartPosition = FormStartPosition.CenterScreen;
            dp.Show();
        }

        private void buttonTambahProdi_Click(object sender, EventArgs e)
        {
            var tp = new FormTambahProdi();
            tp.StartPosition = FormStartPosition.CenterScreen;
            tp.Show();
        }
    }
}
