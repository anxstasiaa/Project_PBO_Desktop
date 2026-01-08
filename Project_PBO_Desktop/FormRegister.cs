using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            // Sembunyikan field yang tidak diperlukan saat awal
            labelNIM.Visible = false;
            textBoxNIM.Visible = false;
            labelNIDN.Visible = false;
            textBoxNIDN.Visible = false;
            comboBoxProdi.Visible = false;
            labelProdi.Visible = false;

            // Mask password fields
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxKonfirPw.UseSystemPasswordChar = true;

            // Isi combo box role
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("Mahasiswa");
            comboBoxRole.Items.Add("Dosen");
            comboBoxRole.Items.Add("Admin Univ");
            comboBoxRole.Items.Add("Admin Prodi");
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;

            // Isi combo box prodi
            comboBoxProdi.Items.Clear();
            comboBoxProdi.Items.Add("Ilmu Komputer");
            comboBoxProdi.Items.Add("Biologi");
            comboBoxProdi.Items.Add("Fisika");
            comboBoxProdi.Items.Add("Kedokteran");
            comboBoxProdi.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem == null) return;

            string role = comboBoxRole.SelectedItem.ToString();

            // Reset semua field
            labelNIM.Visible = false;
            textBoxNIM.Visible = false;
            labelNIDN.Visible = false;
            textBoxNIDN.Visible = false;
            comboBoxProdi.Visible = false;
            labelProdi.Visible = false;

            // Tampilkan field sesuai role
            switch (role)
            {
                case "Mahasiswa":
                    labelNIM.Visible = true;
                    textBoxNIM.Visible = true;
                    comboBoxProdi.Visible = true;
                    labelProdi.Visible = true;
                    break;

                case "Dosen":
                    labelNIDN.Visible = true;
                    textBoxNIDN.Visible = true;
                    comboBoxProdi.Visible = true;
                    labelProdi.Visible = true;
                    break;

                case "Admin Prodi":
                    comboBoxProdi.Visible = true;
                    labelProdi.Visible = true;
                    break;

                case "Admin Univ":
                    // Tidak ada field tambahan
                    break;
            }
        }

        private void chechBoxPw_Changed(object sender, EventArgs e)
        {
            if (textBoxPassword != null && textBoxKonfirPw != null && checkBoxPw != null)
            {
                textBoxPassword.UseSystemPasswordChar = !checkBoxPw.Checked;
                textBoxKonfirPw.UseSystemPasswordChar = !checkBoxPw.Checked;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (!ValidateInput())
                return;

            try
            {
                using (MySqlConnection conn = DbConnection.GetConnection())
                {
                    if (conn == null)
                    {
                        MessageBox.Show("Koneksi database gagal!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    conn.Open();

                    // Cek apakah email sudah terdaftar
                    string checkQuery = "SELECT COUNT(*) FROM users WHERE email = @email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Email sudah terdaftar! Gunakan email lain.", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxEmail.Focus();
                            return;
                        }
                    }

                    // Insert data user baru
                    string insertQuery = @"INSERT INTO users 
                        (nama_lengkap, email, password, role, nim, nidn, id_prodi) 
                        VALUES (@nama, @email, @password, @role, @nim, @nidn, @idProdi)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textBoxNamaLengkap.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", GetRoleValue());

                        // Parameter opsional berdasarkan role
                        cmd.Parameters.AddWithValue("@nim", GetNIM());
                        cmd.Parameters.AddWithValue("@nidn", GetNIDN());
                        cmd.Parameters.AddWithValue("@idProdi", GetIdProdi());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show(
                                "Registrasi berhasil!\n\n" +
                                $"Nama: {textBoxNamaLengkap.Text}\n" +
                                $"Email: {textBoxEmail.Text}\n" +
                                $"Role: {comboBoxRole.SelectedItem}\n\n" +
                                "Silakan login dengan akun Anda.",
                                "Registrasi Berhasil",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            // Kembali ke form login
                            var loginForm = new FormLogin();
                            loginForm.StartPosition = FormStartPosition.CenterScreen;
                            loginForm.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registrasi gagal. Coba lagi.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error saat registrasi:\n" + ex.Message + "\n\n" + ex.StackTrace,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private bool ValidateInput()
        {
            // Validasi Nama Lengkap
            if (string.IsNullOrWhiteSpace(textBoxNamaLengkap.Text))
            {
                MessageBox.Show("Nama lengkap tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNamaLengkap.Focus();
                return false;
            }

            // Validasi Email
            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Email tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Format email tidak valid!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            // Validasi Password
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Password tidak boleh kosong!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return false;
            }

            if (textBoxPassword.Text.Length < 6)
            {
                MessageBox.Show("Password minimal 6 karakter!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPassword.Focus();
                return false;
            }

            // Validasi Konfirmasi Password
            if (textBoxPassword.Text != textBoxKonfirPw.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxKonfirPw.Focus();
                return false;
            }

            // Validasi Role
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih peran/role!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxRole.Focus();
                return false;
            }

            string role = comboBoxRole.SelectedItem.ToString();

            // Validasi field khusus berdasarkan role
            if (role == "Mahasiswa")
            {
                if (string.IsNullOrWhiteSpace(textBoxNIM.Text))
                {
                    MessageBox.Show("NIM tidak boleh kosong!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNIM.Focus();
                    return false;
                }

                if (comboBoxProdi.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih program studi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxProdi.Focus();
                    return false;
                }
            }
            else if (role == "Dosen")
            {
                if (string.IsNullOrWhiteSpace(textBoxNIDN.Text))
                {
                    MessageBox.Show("NIDN tidak boleh kosong!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNIDN.Focus();
                    return false;
                }

                if (comboBoxProdi.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih program studi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxProdi.Focus();
                    return false;
                }
            }
            else if (role == "Admin Prodi")
            {
                if (comboBoxProdi.SelectedItem == null)
                {
                    MessageBox.Show("Silakan pilih program studi!", "Validasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxProdi.Focus();
                    return false;
                }
            }

            return true;
        }

        private string GetRoleValue()
        {
            if (comboBoxRole.SelectedItem == null)
                return null;

            string role = comboBoxRole.SelectedItem.ToString();
            switch (role)
            {
                case "Mahasiswa": return "mahasiswa";
                case "Dosen": return "dosen";
                case "Admin Univ": return "admin-univ";
                case "Admin Prodi": return "admin-prodi";
                default: return null;
            }
        }

        private object GetNIM()
        {
            if (comboBoxRole.SelectedItem?.ToString() == "Mahasiswa" &&
                !string.IsNullOrWhiteSpace(textBoxNIM.Text))
                return textBoxNIM.Text.Trim();

            return DBNull.Value;
        }

        private object GetNIDN()
        {
            if (comboBoxRole.SelectedItem?.ToString() == "Dosen" &&
                !string.IsNullOrWhiteSpace(textBoxNIDN.Text))
                return textBoxNIDN.Text.Trim();

            return DBNull.Value;
        }

        private object GetIdProdi()
        {
            if (comboBoxProdi.SelectedItem == null || !comboBoxProdi.Visible)
                return DBNull.Value;

            string prodi = comboBoxProdi.SelectedItem.ToString();
            switch (prodi)
            {
                case "Ilmu Komputer": return 11111;
                case "Biologi": return 22222;
                case "Fisika": return 33333;
                case "Kedokteran": return 44444;
                default: return DBNull.Value;
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Anda yakin ingin menutup form registrasi?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                var menuUtama = new FormMenuUtama();
                menuUtama.StartPosition = FormStartPosition.CenterScreen;
                menuUtama.Show();
                this.Close();
            }
        }

        private void labelUsername_Click(object sender, EventArgs e) { }
        private void textBoxUsername_TextChanged(object sender, EventArgs e) { }
        private void labelProdi_Click(object sender, EventArgs e) { }
        private void labelKonfirPw_Click(object sender, EventArgs e) { }
    }
}