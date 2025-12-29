using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Project_PBO_Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            // Ensure password is masked by default
            if (textBoxPassword != null)
                textBoxPassword.UseSystemPasswordChar = true;

            // Disable login button until fields contain text
            buttonMasukLogin.Enabled = false;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            buttonMasukLogin.Enabled = !string.IsNullOrWhiteSpace(textBoxUsername.Text)
                                      && !string.IsNullOrWhiteSpace(textBoxPassword.Text);
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonMasukLogin.Enabled = !string.IsNullOrWhiteSpace(textBoxUsername.Text)
                                      && !string.IsNullOrWhiteSpace(textBoxPassword.Text);
        }

        private void checkBoxPw_Changed(object sender, EventArgs e)
        {
            if (textBoxPassword != null && checkBoxPw != null)
                textBoxPassword.UseSystemPasswordChar = !checkBoxPw.Checked;
        }

        private void buttonMasukLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text?.Trim();
            string password = textBoxPassword.Text ?? string.Empty;

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

                    // Query yang disesuaikan dengan struktur database baru
                    string query = @"SELECT id_user, role, id_prodi, nim, nidn 
                                   FROM users 
                                   WHERE email = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["role"].ToString();
                                int userId = Convert.ToInt32(reader["id_user"]);

                                // Ambil data tambahan berdasarkan role
                                object idProdi = reader["id_prodi"];
                                object nim = reader["nim"];
                                object nidn = reader["nidn"];

                                // Tutup reader sebelum membuka form baru
                                reader.Close();
                                conn.Close();

                                // Sembunyikan form login
                                this.Hide();

                                // Arahkan ke form sesuai role
                                switch (role.ToLower())
                                {
                                    case "admin-univ":
                                        var admUniv = new FormAdmUniv();
                                        admUniv.FormClosed += (s, args) => this.Close();
                                        admUniv.Show();
                                        break;

                                    case "admin-prodi":
                                        // Cek id_prodi untuk menentukan form admin prodi mana
                                        if (idProdi != DBNull.Value)
                                        {
                                            int prodiId = Convert.ToInt32(idProdi);
                                            Form formAdmProdi = null;

                                            switch (prodiId)
                                            {
                                                case 11111: // Ilmu Komputer
                                                    formAdmProdi = new FormAdmProdi();
                                                    formAdmProdi.StartPosition = FormStartPosition.CenterScreen;
                                                    break;
                                                case 22222: // Biologi
                                                    formAdmProdi = new FormAdmProdi();
                                                    formAdmProdi.StartPosition = FormStartPosition.CenterScreen;
                                                    break;
                                                case 33333: // Fisika
                                                    formAdmProdi = new FormAdmProdi();
                                                    formAdmProdi.StartPosition = FormStartPosition.CenterScreen;
                                                    break;
                                                default:
                                                    formAdmProdi = new FormAdmProdi();
                                                    break;
                                            }

                                            if (formAdmProdi != null)
                                            {
                                                formAdmProdi.FormClosed += (s, args) => this.Close();
                                                formAdmProdi.Show();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Data prodi tidak valid!", "Error",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            this.Show();
                                        }
                                        break;

                                    case "dosen":
                                        var formDosen = new FormDosen();
                                        formDosen.StartPosition = FormStartPosition.CenterScreen;
                                        formDosen.FormClosed += (s, args) => this.Close();
                                        formDosen.Show();
                                        break;

                                    case "mahasiswa":
                                        var formMhs = new FormMahasiswa();
                                        formMhs.StartPosition = FormStartPosition.CenterScreen;
                                        formMhs.FormClosed += (s, args) => this.Close();
                                        formMhs.Show();
                                        break;

                                    default:
                                        MessageBox.Show($"Role '{role}' tidak dikenali!", "Login Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        this.Show();
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Email atau password salah!", "Login Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBoxPassword.Clear();
                                textBoxPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n\nDetail: " + ex.StackTrace,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}