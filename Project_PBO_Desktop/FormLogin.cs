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

                    string query = @"SELECT id_user, role, id_prodi, nim, nidn, password
                                     FROM users
                                     WHERE email = @username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Email atau password salah!", "Login Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBoxPassword.Clear();
                                textBoxPassword.Focus();
                                return;
                            }

                            // Read DB fields
                            int userId = Convert.ToInt32(reader["id_user"]);
                            string role = reader["role"].ToString();
                            object idProdi = reader["id_prodi"];
                            object nim = reader["nim"];
                            object nidn = reader["nidn"];
                            string passwordFromDB = reader["password"]?.ToString();

                            if (string.IsNullOrWhiteSpace(passwordFromDB))
                            {
                                MessageBox.Show("Stored password is invalid.", "Login Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Detect bcrypt hash by prefix and normalize common PHP prefix
                            bool isBcryptHash = passwordFromDB.StartsWith("$2a$") ||
                                                passwordFromDB.StartsWith("$2b$") ||
                                                passwordFromDB.StartsWith("$2y$");

                            bool isPasswordValid = false;

                            if (isBcryptHash)
                            {
                                string normalizedHash = passwordFromDB;
                                if (passwordFromDB.StartsWith("$2y$"))
                                    normalizedHash = "$2a$" + passwordFromDB.Substring(4);

                                try
                                {
                                    isPasswordValid = BCrypt.Net.BCrypt.Verify(password, normalizedHash);
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Password verification error: " + ex.Message,
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                               
                                isPasswordValid = password.Equals(passwordFromDB);

                               
                                if (isPasswordValid)
                                {
                                   
                                    reader.Close();

                                    string newHash = BCrypt.Net.BCrypt.HashPassword(password);
                                    using (var updateCmd = new MySqlCommand("UPDATE users SET password = @hash WHERE id_user = @id", conn))
                                    {
                                        updateCmd.Parameters.AddWithValue("@hash", newHash);
                                        updateCmd.Parameters.AddWithValue("@id", userId);
                                        updateCmd.ExecuteNonQuery();
                                    }

                                   
                                }
                            }

                            if (!isPasswordValid)
                            {
                                MessageBox.Show("Email atau password salah!", "Login Gagal",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                textBoxPassword.Clear();
                                textBoxPassword.Focus();
                                return;
                            }

                            // Close reader/connection if still open
                            if (!reader.IsClosed) reader.Close();
                            conn.Close();

                            Session.UserId = userId;
                            Session.Peran = role ?? string.Empty;

                            
                            string prodiName = string.Empty;
                            if (idProdi != DBNull.Value)
                            {
                                int prodiId = Convert.ToInt32(idProdi);
                                switch (prodiId)
                                {
                                    case 11111: prodiName = "Ilmu Komputer"; break;
                                    case 22222: prodiName = "Biologi"; break;
                                    case 33333: prodiName = "Fisika"; break;
                                    default: prodiName = prodiId.ToString(); break;
                                }
                            }
                            Session.Prodi = prodiName;

                            // Successful login: navigate by role
                            this.Hide();

                            switch (role.ToLower())
                            {
                                case "admin-univ":
                                    var admUniv = new FormAdmUniv();
                                    admUniv.FormClosed += (s, args) => this.Close();
                                    admUniv.Show();
                                    break;

                                case "admin-prodi":
                                    if (idProdi != DBNull.Value)
                                    {
                                        int prodiId = Convert.ToInt32(idProdi);
                                        Form formAdmProdi = new FormAdmProdi();
                                        formAdmProdi.StartPosition = FormStartPosition.CenterScreen;
                                        formAdmProdi.FormClosed += (s, args) => this.Close();
                                        formAdmProdi.Show();
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