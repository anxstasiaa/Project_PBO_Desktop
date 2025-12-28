namespace Project_PBO_Desktop
{
    partial class FormAdmUniv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmUniv));
            this.labelAdmUniv = new System.Windows.Forms.Label();
            this.buttonManajemenProdi = new System.Windows.Forms.Button();
            this.buttonManajemenMhs = new System.Windows.Forms.Button();
            this.buttonLogoutAdmUniv = new System.Windows.Forms.Button();
            this.panelAdmUnivBawah = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelAdmUnivBawah.SuspendLayout();
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
            this.labelAdmUniv.Size = new System.Drawing.Size(938, 57);
            this.labelAdmUniv.TabIndex = 0;
            this.labelAdmUniv.Text = "Admin Universitas";
            this.labelAdmUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonManajemenProdi
            // 
            this.buttonManajemenProdi.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonManajemenProdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonManajemenProdi.Image")));
            this.buttonManajemenProdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManajemenProdi.Location = new System.Drawing.Point(3, 168);
            this.buttonManajemenProdi.Name = "buttonManajemenProdi";
            this.buttonManajemenProdi.Size = new System.Drawing.Size(243, 68);
            this.buttonManajemenProdi.TabIndex = 1;
            this.buttonManajemenProdi.Text = "Manajemen Prodi";
            this.buttonManajemenProdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManajemenProdi.UseVisualStyleBackColor = false;
            this.buttonManajemenProdi.Click += new System.EventHandler(this.buttonManajemenProdi_Click);
            // 
            // buttonManajemenMhs
            // 
            this.buttonManajemenMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonManajemenMhs.Image = ((System.Drawing.Image)(resources.GetObject("buttonManajemenMhs.Image")));
            this.buttonManajemenMhs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManajemenMhs.Location = new System.Drawing.Point(3, 242);
            this.buttonManajemenMhs.Name = "buttonManajemenMhs";
            this.buttonManajemenMhs.Size = new System.Drawing.Size(243, 63);
            this.buttonManajemenMhs.TabIndex = 2;
            this.buttonManajemenMhs.Text = "Manajemen Mahasiswa";
            this.buttonManajemenMhs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManajemenMhs.UseVisualStyleBackColor = false;
            this.buttonManajemenMhs.Click += new System.EventHandler(this.buttonManajemenMhs_Click);
            // 
            // buttonLogoutAdmUniv
            // 
            this.buttonLogoutAdmUniv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogoutAdmUniv.Location = new System.Drawing.Point(678, 3);
            this.buttonLogoutAdmUniv.Name = "buttonLogoutAdmUniv";
            this.buttonLogoutAdmUniv.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutAdmUniv.TabIndex = 3;
            this.buttonLogoutAdmUniv.Text = "Logout";
            this.buttonLogoutAdmUniv.UseVisualStyleBackColor = false;
            this.buttonLogoutAdmUniv.Click += new System.EventHandler(this.buttonLogoutAdmUniv_Click);
            // 
            // panelAdmUnivBawah
            // 
            this.panelAdmUnivBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelAdmUnivBawah.Controls.Add(this.buttonLogoutAdmUniv);
            this.panelAdmUnivBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdmUnivBawah.Location = new System.Drawing.Point(0, 414);
            this.panelAdmUnivBawah.Name = "panelAdmUnivBawah";
            this.panelAdmUnivBawah.Size = new System.Drawing.Size(938, 36);
            this.panelAdmUnivBawah.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonManajemenProdi);
            this.panel1.Controls.Add(this.buttonManajemenMhs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 357);
            this.panel1.TabIndex = 5;
            // 
            // FormAdmUniv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUnivBawah);
            this.Controls.Add(this.labelAdmUniv);
            this.Name = "FormAdmUniv";
            this.Text = "FormAdmUniv";
            this.panelAdmUnivBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAdmUniv;
        private System.Windows.Forms.Button buttonManajemenProdi;
        private System.Windows.Forms.Button buttonManajemenMhs;
        private System.Windows.Forms.Button buttonLogoutAdmUniv;
        private System.Windows.Forms.Panel panelAdmUnivBawah;
        private System.Windows.Forms.Panel panel1;
    }
}