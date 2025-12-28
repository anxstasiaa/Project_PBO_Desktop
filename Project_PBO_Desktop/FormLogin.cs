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
            // Use trimmed non-null strings to avoid possible null reference issues
            string username = (textBoxUsername.Text ?? string.Empty).Trim();
            string password = textBoxPassword.Text ?? string.Empty;

            if (username.Equals("adm-univ", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                MessageBox.Show("Login berhasil sebagai Admin Universitas.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = new FormAdmUniv();
                f.Show();
                this.Close();
                return;
            }

            if (username.Equals("adm-prodi", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                MessageBox.Show("Login berhasil sebagai Admin Prodi.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = new FormAdmProdi();
                f.Show();
                this.Close();
                return;
            }

            if (username.Equals("dosen", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                MessageBox.Show("Login berhasil sebagai Dosen.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = new FormDosen();
                f.Show();
                this.Close();
                return;
            }

            if (username.Equals("mhs", StringComparison.OrdinalIgnoreCase) && password == "123")
            {
                MessageBox.Show("Login berhasil sebagai Mahasiswa.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var f = new FormMahasiswa();
                f.Show();
                this.Close();
                return;
            }

            MessageBox.Show(
                "Username atau password salah.",
                "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // Keep these if designer wired them; otherwise you can remove them
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) { }
    }
}
