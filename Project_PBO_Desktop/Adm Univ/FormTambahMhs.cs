using System;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public partial class FormTambahMhs : Form
    {
        public FormTambahMhs()
        {
            InitializeComponent();

            comboBoxProdi.Items.Clear();
            comboBoxProdi.Items.AddRange(new object[]
            {
                "Ilmu Komputer",
                "Biologi",
                "Fisika",
                "Kedokteran"
            });
            comboBoxProdi.DropDownStyle = ComboBoxStyle.DropDownList;

            this.buttonSimpan.Click += new EventHandler(this.buttonSimpan_Click);
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            string NIM = textBoxNIM.Text?.Trim();
            string Nama = textBoxNama.Text?.Trim();

            string JenisKelamin = null;
            if (radioButtonLaki.Checked) JenisKelamin = "Laki-laki";
            else if (radioButtonPerempuan.Checked) JenisKelamin = "Perempuan";

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

