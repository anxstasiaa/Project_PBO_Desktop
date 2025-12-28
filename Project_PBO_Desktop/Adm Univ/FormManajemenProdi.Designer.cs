namespace Project_PBO_Desktop
{
    partial class FormManajemenProdi
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
            this.labelAdmProdi = new System.Windows.Forms.Label();
            this.panelTambahBawah = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDaftarProdi = new System.Windows.Forms.Button();
            this.buttonTambahProdi = new System.Windows.Forms.Button();
            this.buttonKelolaTagihanMhs = new System.Windows.Forms.Button();
            this.panelTambahBawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmProdi
            // 
            this.labelAdmProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelAdmProdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAdmProdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmProdi.Location = new System.Drawing.Point(0, 0);
            this.labelAdmProdi.Name = "labelAdmProdi";
            this.labelAdmProdi.Size = new System.Drawing.Size(800, 55);
            this.labelAdmProdi.TabIndex = 1;
            this.labelAdmProdi.Text = "Manajemen Prodi";
            this.labelAdmProdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTambahBawah
            // 
            this.panelTambahBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelTambahBawah.Controls.Add(this.buttonKembali);
            this.panelTambahBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambahBawah.Location = new System.Drawing.Point(0, 409);
            this.panelTambahBawah.Name = "panelTambahBawah";
            this.panelTambahBawah.Size = new System.Drawing.Size(800, 41);
            this.panelTambahBawah.TabIndex = 11;
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKembali.Location = new System.Drawing.Point(692, 6);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 9;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonKelolaTagihanMhs);
            this.panel1.Controls.Add(this.buttonDaftarProdi);
            this.panel1.Controls.Add(this.buttonTambahProdi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 354);
            this.panel1.TabIndex = 12;
            // 
            // buttonDaftarProdi
            // 
            this.buttonDaftarProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDaftarProdi.Location = new System.Drawing.Point(3, 136);
            this.buttonDaftarProdi.Name = "buttonDaftarProdi";
            this.buttonDaftarProdi.Size = new System.Drawing.Size(171, 57);
            this.buttonDaftarProdi.TabIndex = 1;
            this.buttonDaftarProdi.Text = "Lihat Daftar Prodi";
            this.buttonDaftarProdi.UseVisualStyleBackColor = false;
            // 
            // buttonTambahProdi
            // 
            this.buttonTambahProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTambahProdi.Location = new System.Drawing.Point(3, 199);
            this.buttonTambahProdi.Name = "buttonTambahProdi";
            this.buttonTambahProdi.Size = new System.Drawing.Size(171, 57);
            this.buttonTambahProdi.TabIndex = 2;
            this.buttonTambahProdi.Text = "Tambah Prodi";
            this.buttonTambahProdi.UseVisualStyleBackColor = false;
            // 
            // buttonKelolaTagihanMhs
            // 
            this.buttonKelolaTagihanMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKelolaTagihanMhs.Location = new System.Drawing.Point(3, 262);
            this.buttonKelolaTagihanMhs.Name = "buttonKelolaTagihanMhs";
            this.buttonKelolaTagihanMhs.Size = new System.Drawing.Size(171, 57);
            this.buttonKelolaTagihanMhs.TabIndex = 3;
            this.buttonKelolaTagihanMhs.Text = "Manajemen Tagihan Mahasiswa";
            this.buttonKelolaTagihanMhs.UseVisualStyleBackColor = false;
            // 
            // FormManajemenProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTambahBawah);
            this.Controls.Add(this.labelAdmProdi);
            this.Name = "FormManajemenProdi";
            this.Text = "FormManajemenProdi";
            this.Load += new System.EventHandler(this.FormManajemenProdi_Load);
            this.panelTambahBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmProdi;
        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKelolaTagihanMhs;
        private System.Windows.Forms.Button buttonDaftarProdi;
        private System.Windows.Forms.Button buttonTambahProdi;
    }
}