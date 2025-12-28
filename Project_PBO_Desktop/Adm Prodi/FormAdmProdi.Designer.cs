namespace Project_PBO_Desktop
{
    partial class FormAdmProdi
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
            this.panelAdmUnivBawah = new System.Windows.Forms.Panel();
            this.buttonLogoutAdmProdi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDaftarProdi = new System.Windows.Forms.Button();
            this.buttonKelolaSmt = new System.Windows.Forms.Button();
            this.buttonKelolaKK = new System.Windows.Forms.Button();
            this.buttonKelolaMK = new System.Windows.Forms.Button();
            this.buttonDaftarMhs = new System.Windows.Forms.Button();
            this.panelAdmUnivBawah.SuspendLayout();
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
            this.labelAdmProdi.TabIndex = 0;
            this.labelAdmProdi.Text = "Admin Prodi";
            this.labelAdmProdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdmUnivBawah
            // 
            this.panelAdmUnivBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelAdmUnivBawah.Controls.Add(this.buttonLogoutAdmProdi);
            this.panelAdmUnivBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdmUnivBawah.Location = new System.Drawing.Point(0, 414);
            this.panelAdmUnivBawah.Name = "panelAdmUnivBawah";
            this.panelAdmUnivBawah.Size = new System.Drawing.Size(800, 36);
            this.panelAdmUnivBawah.TabIndex = 5;
            // 
            // buttonLogoutAdmProdi
            // 
            this.buttonLogoutAdmProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogoutAdmProdi.Location = new System.Drawing.Point(678, 3);
            this.buttonLogoutAdmProdi.Name = "buttonLogoutAdmProdi";
            this.buttonLogoutAdmProdi.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutAdmProdi.TabIndex = 3;
            this.buttonLogoutAdmProdi.Text = "Logout";
            this.buttonLogoutAdmProdi.UseVisualStyleBackColor = false;
            this.buttonLogoutAdmProdi.Click += new System.EventHandler(this.buttonLogoutAdmProdi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonDaftarProdi);
            this.panel1.Controls.Add(this.buttonKelolaSmt);
            this.panel1.Controls.Add(this.buttonKelolaKK);
            this.panel1.Controls.Add(this.buttonKelolaMK);
            this.panel1.Controls.Add(this.buttonDaftarMhs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 359);
            this.panel1.TabIndex = 6;
            // 
            // buttonDaftarProdi
            // 
            this.buttonDaftarProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDaftarProdi.Location = new System.Drawing.Point(3, 312);
            this.buttonDaftarProdi.Name = "buttonDaftarProdi";
            this.buttonDaftarProdi.Size = new System.Drawing.Size(171, 40);
            this.buttonDaftarProdi.TabIndex = 5;
            this.buttonDaftarProdi.Text = "Lihat Daftar Prodi";
            this.buttonDaftarProdi.UseVisualStyleBackColor = false;
            this.buttonDaftarProdi.Click += new System.EventHandler(this.buttonDaftarProdi_Click);
            // 
            // buttonKelolaSmt
            // 
            this.buttonKelolaSmt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKelolaSmt.Location = new System.Drawing.Point(3, 266);
            this.buttonKelolaSmt.Name = "buttonKelolaSmt";
            this.buttonKelolaSmt.Size = new System.Drawing.Size(171, 40);
            this.buttonKelolaSmt.TabIndex = 4;
            this.buttonKelolaSmt.Text = "Kelola Semester";
            this.buttonKelolaSmt.UseVisualStyleBackColor = false;
            this.buttonKelolaSmt.Click += new System.EventHandler(this.buttonKelolaSmt_Click);
            // 
            // buttonKelolaKK
            // 
            this.buttonKelolaKK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKelolaKK.Location = new System.Drawing.Point(3, 220);
            this.buttonKelolaKK.Name = "buttonKelolaKK";
            this.buttonKelolaKK.Size = new System.Drawing.Size(171, 40);
            this.buttonKelolaKK.TabIndex = 3;
            this.buttonKelolaKK.Text = "Kelola Kelas Kuliah";
            this.buttonKelolaKK.UseVisualStyleBackColor = false;
            this.buttonKelolaKK.Click += new System.EventHandler(this.buttonKelolaKK_Click);
            // 
            // buttonKelolaMK
            // 
            this.buttonKelolaMK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKelolaMK.Location = new System.Drawing.Point(3, 174);
            this.buttonKelolaMK.Name = "buttonKelolaMK";
            this.buttonKelolaMK.Size = new System.Drawing.Size(171, 40);
            this.buttonKelolaMK.TabIndex = 2;
            this.buttonKelolaMK.Text = "Kelola Mata Kuliah";
            this.buttonKelolaMK.UseVisualStyleBackColor = false;
            this.buttonKelolaMK.Click += new System.EventHandler(this.buttonKelolaMK_Click);
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
            this.buttonDaftarMhs.Click += new System.EventHandler(this.buttonDaftarMhs_Click);
            // 
            // FormAdmProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUnivBawah);
            this.Controls.Add(this.labelAdmProdi);
            this.Name = "FormAdmProdi";
            this.Text = "FormAdmProdi";
            this.Load += new System.EventHandler(this.FormAdmProdi_Load);
            this.panelAdmUnivBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmProdi;
        private System.Windows.Forms.Panel panelAdmUnivBawah;
        private System.Windows.Forms.Button buttonLogoutAdmProdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDaftarMhs;
        private System.Windows.Forms.Button buttonDaftarProdi;
        private System.Windows.Forms.Button buttonKelolaSmt;
        private System.Windows.Forms.Button buttonKelolaKK;
        private System.Windows.Forms.Button buttonKelolaMK;
    }
}