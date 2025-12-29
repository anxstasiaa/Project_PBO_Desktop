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

                            switch (role.ToLower().Replace(" ", "-"))
                            {
                                case "admin-univ":
                                case "adminuniv":
                                    var admUniv = new FormAdmUniv();
                                    admUniv.Show();
                                    break;
                                case "admin-ilkom":
                                case "adminilkom":
                                    var admIlkom = new FormAdmIlkom();
                                    admIlkom.Show();
                                    break;
                                case "admin-fis":
                                case "adminfis":
                                    var admFis = new FormAdmFis();
                                    admFis.Show();
                                    break;
                                case "admin-bio":
                                case "adminbio":
                                    var admBio = new FormAdmBio();
                                    admBio.Show();
                                    break;
                                case "dosen":
                                    var dosen = new FormDosen();
                                    dosen.Show();
                                    break;
                                case "mhs":
                                    var mhs = new FormMahasiswa();
                                    mhs.Show();
                                    break;
                              
                                default:
                                    // unexpected role value
                                    MessageBox.Show($"Role '{role}' is not recognized.", "Login Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                    
                            }
                            
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



          