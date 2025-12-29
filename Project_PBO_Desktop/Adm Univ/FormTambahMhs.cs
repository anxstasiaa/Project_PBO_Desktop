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
    public partial class FormTambahMhs : Form
    {
        public FormTambahMhs()
        {
            InitializeComponent();

            comboBoxJenisKelamin.Items.Clear();
            comboBoxJenisKelamin.Items.AddRange(new object[]
            {
                "Laki-laki",
                "Perempuan"
            });
            comboBoxJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxProdi.Items.Clear();
            comboBoxProdi.Items.AddRange(new object[]
            {
                "Ilmu Komputer",
                "Biologi",
                "Fisika",
                "Kedokteran"
            });
            comboBoxProdi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxJenisKelamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxProdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxProdi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpanMhs_Click(object sender, EventArgs e)
        {
            string NIM = textBoxNIM.Text?.Trim();
            string Nama = textBoxNama.Text?.Trim();
            string JenisKelamin = comboBoxJenisKelamin.SelectedItem as string;
            string Prodi = comboBoxProdi.SelectedItem as string;

            if (string.IsNullOrEmpty(NIM))
            {
                MessageBox.Show("NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNIM.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Nama))
            {
                MessageBox.Show("Nama tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNama.Focus();
                return;
            }
            if (string.IsNullOrEmpty(JenisKelamin))
            {
                MessageBox.Show("Jenis Kelamin tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxJenisKelamin.DroppedDown = true;
                return;
            }
            if (string.IsNullOrEmpty(Prodi))
            {
                MessageBox.Show("Program Studi tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProdi.DroppedDown = true;
                return;
            }

            MessageBox.Show($"Data Mahasiswa berhasil disimpan: \nNIM: {NIM} \nNama: {Nama} \nJenis Kelamin: {JenisKelamin} \nProgram Studi: {Prodi}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void labelTambah_Click(object sender, EventArgs e)
        {

        }

        private void FormTambahMhs_Load(object sender, EventArgs e)
        {

        }
    }
}

