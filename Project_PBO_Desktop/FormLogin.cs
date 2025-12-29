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

            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Tidak dapat terhubung ke database!\nPastikan MySQL sudah berjalan.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            // Toggle mask when checkbox changes (use the designer-declared checkBoxPw)
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
                    conn.Open();
                    string query = "SELECT role FROM users WHERE username = @username AND password = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Gunakan hashing di production!

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString();

                            switch (role.ToLower())
                            {
                                case "adm-univ":
                                    var admUniv = new FormAdmUniv();
                                    admUniv.Show();
                                    break;
                                case "adm-prodi":
                                    var admProdi = new FormAdmProdi();
                                    admProdi.Show();
                                    break;
                                case "dosen":
                                    var dosen = new FormDosen();
                                    dosen.Show();
                                    break;
                                case "mhs":
                                    var mhs = new FormMahasiswa();
                                    mhs.Show();
                                    break;
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah!", "Login Gagal",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void labelX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



          