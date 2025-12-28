namespace Project_PBO_Desktop.Adm_Univ
{
    partial class FormKelolaTagihanRegis
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
            this.panelTambahBawah = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.labelAdmUniv = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHapusTagihan = new System.Windows.Forms.Button();
            this.buttonEditTagihan = new System.Windows.Forms.Button();
            this.buttonBuatTagihan = new System.Windows.Forms.Button();
            this.buttonDaftarSemuaTagihan = new System.Windows.Forms.Button();
            this.panelTambahBawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTambahBawah
            // 
            this.panelTambahBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelTambahBawah.Controls.Add(this.buttonKembali);
            this.panelTambahBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambahBawah.Location = new System.Drawing.Point(0, 409);
            this.panelTambahBawah.Name = "panelTambahBawah";
            this.panelTambahBawah.Size = new System.Drawing.Size(800, 41);
            this.panelTambahBawah.TabIndex = 12;
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
            // labelAdmUniv
            // 
            this.labelAdmUniv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelAdmUniv.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAdmUniv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmUniv.Location = new System.Drawing.Point(0, 0);
            this.labelAdmUniv.Name = "labelAdmUniv";
            this.labelAdmUniv.Size = new System.Drawing.Size(800, 57);
            this.labelAdmUniv.TabIndex = 17;
            this.labelAdmUniv.Text = "Kelola Tagihan Registrasi";
            this.labelAdmUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonHapusTagihan);
            this.panel1.Controls.Add(this.buttonEditTagihan);
            this.panel1.Controls.Add(this.buttonBuatTagihan);
            this.panel1.Controls.Add(this.buttonDaftarSemuaTagihan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 352);
            this.panel1.TabIndex = 20;
            // 
            // buttonHapusTagihan
            // 
            this.buttonHapusTagihan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonHapusTagihan.Location = new System.Drawing.Point(3, 274);
            this.buttonHapusTagihan.Name = "buttonHapusTagihan";
            this.buttonHapusTagihan.Size = new System.Drawing.Size(171, 47);
            this.buttonHapusTagihan.TabIndex = 4;
            this.buttonHapusTagihan.Text = "Hapus Tagihan";
            this.buttonHapusTagihan.UseVisualStyleBackColor = false;
            // 
            // buttonEditTagihan
            // 
            this.buttonEditTagihan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonEditTagihan.Location = new System.Drawing.Point(3, 221);
            this.buttonEditTagihan.Name = "buttonEditTagihan";
            this.buttonEditTagihan.Size = new System.Drawing.Size(171, 47);
            this.buttonEditTagihan.TabIndex = 3;
            this.buttonEditTagihan.Text = "Edit Tagihan";
            this.buttonEditTagihan.UseVisualStyleBackColor = false;
            // 
            // buttonBuatTagihan
            // 
            this.buttonBuatTagihan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonBuatTagihan.Location = new System.Drawing.Point(3, 168);
            this.buttonBuatTagihan.Name = "buttonBuatTagihan";
            this.buttonBuatTagihan.Size = new System.Drawing.Size(171, 47);
            this.buttonBuatTagihan.TabIndex = 2;
            this.buttonBuatTagihan.Text = "Buat Tagihan";
            this.buttonBuatTagihan.UseVisualStyleBackColor = false;
            // 
            // buttonDaftarSemuaTagihan
            // 
            this.buttonDaftarSemuaTagihan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonDaftarSemuaTagihan.Location = new System.Drawing.Point(3, 115);
            this.buttonDaftarSemuaTagihan.Name = "buttonDaftarSemuaTagihan";
            this.buttonDaftarSemuaTagihan.Size = new System.Drawing.Size(171, 47);
            this.buttonDaftarSemuaTagihan.TabIndex = 1;
            this.buttonDaftarSemuaTagihan.Text = "Lihat Semua Tagihan";
            this.buttonDaftarSemuaTagihan.UseVisualStyleBackColor = false;
            // 
            // FormKelolaTagihanRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAdmUniv);
            this.Controls.Add(this.panelTambahBawah);
            this.Name = "FormKelolaTagihanRegis";
            this.Text = "FormKelolaTagihanRegis";
            this.panelTambahBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Label labelAdmUniv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapusTagihan;
        private System.Windows.Forms.Button buttonEditTagihan;
        private System.Windows.Forms.Button buttonBuatTagihan;
        private System.Windows.Forms.Button buttonDaftarSemuaTagihan;
    }
}