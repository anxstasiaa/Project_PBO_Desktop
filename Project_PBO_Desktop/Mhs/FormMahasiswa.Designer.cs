namespace Project_PBO_Desktop
{
    partial class FormMahasiswa
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
            this.labelMahasiswa = new System.Windows.Forms.Label();
            this.panelAdmUnivBawah = new System.Windows.Forms.Panel();
            this.buttonLogoutMhs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTagihan = new System.Windows.Forms.Button();
            this.buttonKHS = new System.Windows.Forms.Button();
            this.buttonKRS = new System.Windows.Forms.Button();
            this.panelAdmUnivBawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMahasiswa
            // 
            this.labelMahasiswa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMahasiswa.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMahasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMahasiswa.Location = new System.Drawing.Point(0, 0);
            this.labelMahasiswa.Name = "labelMahasiswa";
            this.labelMahasiswa.Size = new System.Drawing.Size(802, 79);
            this.labelMahasiswa.TabIndex = 0;
            this.labelMahasiswa.Text = "Mahasiswa";
            this.labelMahasiswa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMahasiswa.Click += new System.EventHandler(this.labelMahasiswa_Click);
            // 
            // panelAdmUnivBawah
            // 
            this.panelAdmUnivBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelAdmUnivBawah.Controls.Add(this.buttonLogoutMhs);
            this.panelAdmUnivBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdmUnivBawah.Location = new System.Drawing.Point(0, 414);
            this.panelAdmUnivBawah.Name = "panelAdmUnivBawah";
            this.panelAdmUnivBawah.Size = new System.Drawing.Size(802, 36);
            this.panelAdmUnivBawah.TabIndex = 5;
            // 
            // buttonLogoutMhs
            // 
            this.buttonLogoutMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogoutMhs.Location = new System.Drawing.Point(678, 3);
            this.buttonLogoutMhs.Name = "buttonLogoutMhs";
            this.buttonLogoutMhs.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutMhs.TabIndex = 3;
            this.buttonLogoutMhs.Text = "Logout";
            this.buttonLogoutMhs.UseVisualStyleBackColor = false;
            this.buttonLogoutMhs.Click += new System.EventHandler(this.buttonLogoutMhs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonTagihan);
            this.panel1.Controls.Add(this.buttonKHS);
            this.panel1.Controls.Add(this.buttonKRS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 335);
            this.panel1.TabIndex = 6;
            // 
            // buttonTagihan
            // 
            this.buttonTagihan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonTagihan.Location = new System.Drawing.Point(3, 271);
            this.buttonTagihan.Name = "buttonTagihan";
            this.buttonTagihan.Size = new System.Drawing.Size(171, 57);
            this.buttonTagihan.TabIndex = 3;
            this.buttonTagihan.Text = "Lihat & Bayar Tagihan";
            this.buttonTagihan.UseVisualStyleBackColor = false;
            this.buttonTagihan.Click += new System.EventHandler(this.buttonTagihan_Click);
            // 
            // buttonKHS
            // 
            this.buttonKHS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKHS.Location = new System.Drawing.Point(3, 208);
            this.buttonKHS.Name = "buttonKHS";
            this.buttonKHS.Size = new System.Drawing.Size(171, 57);
            this.buttonKHS.TabIndex = 2;
            this.buttonKHS.Text = "Lihat KHS";
            this.buttonKHS.UseVisualStyleBackColor = false;
            this.buttonKHS.Click += new System.EventHandler(this.buttonKHS_Click);
            // 
            // buttonKRS
            // 
            this.buttonKRS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKRS.Location = new System.Drawing.Point(3, 145);
            this.buttonKRS.Name = "buttonKRS";
            this.buttonKRS.Size = new System.Drawing.Size(171, 57);
            this.buttonKRS.TabIndex = 1;
            this.buttonKRS.Text = "Lihat KRS";
            this.buttonKRS.UseVisualStyleBackColor = false;
            this.buttonKRS.Click += new System.EventHandler(this.buttonKRS_Click);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUnivBawah);
            this.Controls.Add(this.labelMahasiswa);
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            this.panelAdmUnivBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMahasiswa;
        private System.Windows.Forms.Panel panelAdmUnivBawah;
        private System.Windows.Forms.Button buttonLogoutMhs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKRS;
        private System.Windows.Forms.Button buttonTagihan;
        private System.Windows.Forms.Button buttonKHS;
    }
}