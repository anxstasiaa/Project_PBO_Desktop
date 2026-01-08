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
    public partial class FormDaftarProdi : Form
    {
        public FormDaftarProdi()
        {
            InitializeComponent();
        }

        private void FormDaftarProdi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonTambahProdi_Click(object sender, EventArgs e)
        {
            var tambahprodi = new FormTambahProdi();
            tambahprodi.StartPosition = FormStartPosition.CenterScreen;
            tambahprodi.Show();

            this.Close();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
