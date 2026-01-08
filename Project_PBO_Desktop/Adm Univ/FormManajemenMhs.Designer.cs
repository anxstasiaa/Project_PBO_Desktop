namespace Project_PBO_Desktop
{
    partial class FormManajemenMhs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKelolaTagihanRegis = new System.Windows.Forms.Button();
            this.buttonHapusMhs = new System.Windows.Forms.Button();
            this.buttonUbahMhs = new System.Windows.Forms.Button();
            this.buttonTambahMhs = new System.Windows.Forms.Button();
            this.buttonDaftarMhs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKembali.Location = new System.Drawing.Point(786, 525);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 9;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonKelolaTagihanRegis);
            this.panel1.Controls.Add(this.buttonHapusMhs);
            this.panel1.Controls.Add(this.buttonUbahMhs);
            this.panel1.Controls.Add(this.buttonTambahMhs);
            this.panel1.Controls.Add(this.buttonDaftarMhs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 673);
            this.panel1.TabIndex = 13;
            // 
            // buttonKelolaTagihanRegis
            // 
            this.buttonKelolaTagihanRegis.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKelolaTagihanRegis.Location = new System.Drawing.Point(3, 312);
            this.buttonKelolaTagihanRegis.Name = "buttonKelolaTagihanRegis";
            this.buttonKelolaTagihanRegis.Size = new System.Drawing.Size(171, 40);
            this.buttonKelolaTagihanRegis.TabIndex = 5;
            this.buttonKelolaTagihanRegis.Text = "Kelola Tagihan Registrasi";
            this.buttonKelolaTagihanRegis.UseVisualStyleBackColor = false;
            // 
            // buttonHapusMhs
            // 
            this.buttonHapusMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHapusMhs.Location = new System.Drawing.Point(3, 266);
            this.buttonHapusMhs.Name = "buttonHapusMhs";
            this.buttonHapusMhs.Size = new System.Drawing.Size(171, 40);
            this.buttonHapusMhs.TabIndex = 4;
            this.buttonHapusMhs.Text = "Hapus Data Mahasiswa";
            this.buttonHapusMhs.UseVisualStyleBackColor = false;
            // 
            // buttonUbahMhs
            // 
            this.buttonUbahMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUbahMhs.Location = new System.Drawing.Point(3, 220);
            this.buttonUbahMhs.Name = "buttonUbahMhs";
            this.buttonUbahMhs.Size = new System.Drawing.Size(171, 40);
            this.buttonUbahMhs.TabIndex = 3;
            this.buttonUbahMhs.Text = "Ubah Data Mahasiswa";
            this.buttonUbahMhs.UseVisualStyleBackColor = false;
            // 
            // buttonTambahMhs
            // 
            this.buttonTambahMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTambahMhs.Location = new System.Drawing.Point(3, 174);
            this.buttonTambahMhs.Name = "buttonTambahMhs";
            this.buttonTambahMhs.Size = new System.Drawing.Size(171, 40);
            this.buttonTambahMhs.TabIndex = 2;
            this.buttonTambahMhs.Text = "Tambah Mahasiswa";
            this.buttonTambahMhs.UseVisualStyleBackColor = false;
            // 
            // buttonDaftarMhs
            // 
            this.buttonDaftarMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDaftarMhs.Location = new System.Drawing.Point(3, 128);
            this.buttonDaftarMhs.Name = "buttonDaftarMhs";
            this.buttonDaftarMhs.Size = new System.Drawing.Size(171, 40);
            this.buttonDaftarMhs.TabIndex = 1;
            this.buttonDaftarMhs.Text = "Lihat Daftar Mahasiswa";
            this.buttonDaftarMhs.UseVisualStyleBackColor = false;
            // 
            // FormManajemenMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManajemenMhs";
            this.Text = "FormManajemenMhs";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKelolaTagihanRegis;
        private System.Windows.Forms.Button buttonHapusMhs;
        private System.Windows.Forms.Button buttonUbahMhs;
        private System.Windows.Forms.Button buttonTambahMhs;
        private System.Windows.Forms.Button buttonDaftarMhs;
    }
}