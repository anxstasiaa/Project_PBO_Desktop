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
    public partial class FormTambahProdi : Form
    {
        public FormTambahProdi()
        {
            InitializeComponent();
        }

        private void FormTambahProdi_Load(object sender, EventArgs e)
        {

        }

        private void errorProvider1_Changed(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(textBoxKodeProdi.Text))
            {
                errorProvider1.SetError(textBoxKodeProdi, "Kode Prodi wajib diisi");
                return;
            }

            if (textBoxKodeProdi.Text.Length < 5)
            {
                errorProvider1.SetError(textBoxKodeProdi, "Kode Prodi harus 5 karakter");
                return;
            }

            if (textBoxNamaProdi.Text.Length < 10)
            {
                errorProvider1.SetError(textBoxNamaProdi, "Nama Prodi minimal 10 karakter");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNamaProdi.Text))
            {
                errorProvider1.SetError(textBoxNamaProdi, "Nama Prodi wajib diisi");
                return;
            }

            if (textBoxAliasProdi.Text.Length < 10)
            {
                errorProvider1.SetError(textBoxAliasProdi, "Alias Prodi minimal 10 karakter");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAliasProdi.Text))
            {
                errorProvider1.SetError(textBoxAliasProdi, "Alias Prodi wajib diisi");
                return;
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

        }
    }
}
    
