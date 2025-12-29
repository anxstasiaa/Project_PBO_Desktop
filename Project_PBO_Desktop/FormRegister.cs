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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            labelNIM.Visible = false;
            textBoxNIM.Visible = false;

            labelNIDN.Visible = false;  
            textBoxNIDN.Visible = false;

            comboBoxProdi.Visible = false;
            labelProdi.Visible = false;

            comboBoxRole.Items.Add("Mahasiswa");
            comboBoxRole.Items.Add("Dosen");
            comboBoxRole.Items.Add("Admin Univ");
            comboBoxRole.Items.Add("Admin Prodi");
            comboBoxProdi.Items.Add("Ilmu Komputer");
            comboBoxProdi.Items.Add("Biologi");
            comboBoxProdi.Items.Add("Fisika");
            comboBoxProdi.Items.Add("Kedokteran");
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRole.SelectedItem.ToString() == "Mahasiswa")
            {
                labelNIM.Visible = true;
                textBoxNIM.Visible = true;
                labelNIDN.Visible = false;
                textBoxNIDN.Visible = false;
                comboBoxProdi.Visible = true;
                labelProdi.Visible = true;
            }
            else if (comboBoxRole.SelectedItem.ToString() == "Dosen")
            {
                labelNIM.Visible = false;
                textBoxNIM.Visible = false;
                labelNIDN.Visible = true;
                textBoxNIDN.Visible = true;
                comboBoxProdi.Visible = true;
                labelProdi.Visible = true;
            }
            else if (comboBoxRole.SelectedItem.ToString() == "Admin Prodi")
            {
                labelNIM.Visible = false;
                textBoxNIM.Visible = false;
                labelNIDN.Visible = false;
                textBoxNIDN.Visible = false;
                comboBoxProdi.Visible = true;
                labelProdi.Visible = true;
            }
            else
            {
                labelNIM.Visible = false;
                textBoxNIM.Visible = false;
                labelNIDN.Visible = false;
                textBoxNIDN.Visible = false;
                comboBoxProdi.Visible = false;
                labelProdi.Visible = false;
            }
        }


        private void chechBoxPw_Changed(object sender, EventArgs e)
        {
            if (textBoxPassword != null && checkBoxPw != null)
                textBoxPassword.UseSystemPasswordChar = !checkBoxPw.Checked;
        }

        private void labelProdi_Click(object sender, EventArgs e)
        {

        }

        private void labelKonfirPw_Click(object sender, EventArgs e)
        {

        }
    }
}
