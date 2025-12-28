namespace Project_PBO_Desktop
{
    partial class FormKelolaMK
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
            this.labelAdmUniv = new System.Windows.Forms.Label();
            this.panelTambahBawah = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDaftarMK = new System.Windows.Forms.Button();
            this.buttonTambahMK = new System.Windows.Forms.Button();
            this.buttonUbahMK = new System.Windows.Forms.Button();
            this.buttonHapusMK = new System.Windows.Forms.Button();
            this.panelTambahBawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdmUniv
            // 
            this.labelAdmUniv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelAdmUniv.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAdmUniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmUniv.Location = new System.Drawing.Point(0, 0);
            this.labelAdmUniv.Name = "labelAdmUniv";
            this.labelAdmUniv.Size = new System.Drawing.Size(800, 57);
            this.labelAdmUniv.TabIndex = 16;
            this.labelAdmUniv.Text = "Kelola Mata Kuliah";
            this.labelAdmUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTambahBawah
            // 
            this.panelTambahBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelTambahBawah.Controls.Add(this.buttonKembali);
            this.panelTambahBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambahBawah.Location = new System.Drawing.Point(0, 409);
            this.panelTambahBawah.Name = "panelTambahBawah";
            this.panelTambahBawah.Size = new System.Drawing.Size(800, 41);
            this.panelTambahBawah.TabIndex = 17;
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
            this.panel1.Controls.Add(this.buttonHapusMK);
            this.panel1.Controls.Add(this.buttonUbahMK);
            this.panel1.Controls.Add(this.buttonTambahMK);
            this.panel1.Controls.Add(this.buttonDaftarMK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 352);
            this.panel1.TabIndex = 18;
            // 
            // buttonDaftarMK
            // 
            this.buttonDaftarMK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDaftarMK.Location = new System.Drawing.Point(3, 115);
            this.buttonDaftarMK.Name = "buttonDaftarMK";
            this.buttonDaftarMK.Size = new System.Drawing.Size(171, 47);
            this.buttonDaftarMK.TabIndex = 1;
            this.buttonDaftarMK.Text = "Lihat Daftar Mata Kuliah";
            this.buttonDaftarMK.UseVisualStyleBackColor = false;
            // 
            // buttonTambahMK
            // 
            this.buttonTambahMK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTambahMK.Location = new System.Drawing.Point(3, 168);
            this.buttonTambahMK.Name = "buttonTambahMK";
            this.buttonTambahMK.Size = new System.Drawing.Size(171, 47);
            this.buttonTambahMK.TabIndex = 2;
            this.buttonTambahMK.Text = "Tambah Mata Kuliah";
            this.buttonTambahMK.UseVisualStyleBackColor = false;
            // 
            // buttonUbahMK
            // 
            this.buttonUbahMK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonUbahMK.Location = new System.Drawing.Point(3, 221);
            this.buttonUbahMK.Name = "buttonUbahMK";
            this.buttonUbahMK.Size = new System.Drawing.Size(171, 47);
            this.buttonUbahMK.TabIndex = 3;
            this.buttonUbahMK.Text = "Ubah Mata Kuliah";
            this.buttonUbahMK.UseVisualStyleBackColor = false;
            // 
            // buttonHapusMK
            // 
            this.buttonHapusMK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHapusMK.Location = new System.Drawing.Point(3, 274);
            this.buttonHapusMK.Name = "buttonHapusMK";
            this.buttonHapusMK.Size = new System.Drawing.Size(171, 47);
            this.buttonHapusMK.TabIndex = 4;
            this.buttonHapusMK.Text = "Hapus Mata Kuliah";
            this.buttonHapusMK.UseVisualStyleBackColor = false;
            // 
            // FormKelolaMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTambahBawah);
            this.Controls.Add(this.labelAdmUniv);
            this.Name = "FormKelolaMK";
            this.Text = "FormKelolaMK";
            this.panelTambahBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmUniv;
        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapusMK;
        private System.Windows.Forms.Button buttonUbahMK;
        private System.Windows.Forms.Button buttonTambahMK;
        private System.Windows.Forms.Button buttonDaftarMK;
    }
}