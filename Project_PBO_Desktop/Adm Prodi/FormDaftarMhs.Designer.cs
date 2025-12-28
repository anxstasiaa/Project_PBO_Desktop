namespace Project_PBO_Desktop
{
    partial class FormDaftarMhs
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
            this.panelTambahBawah.SuspendLayout();
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
            this.labelAdmUniv.TabIndex = 15;
            this.labelAdmUniv.Text = "Daftar Mahasiswa";
            this.labelAdmUniv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDaftarMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAdmUniv);
            this.Controls.Add(this.panelTambahBawah);
            this.Name = "FormDaftarMhs";
            this.Text = "FormDaftarMhs";
            this.panelTambahBawah.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Label labelAdmUniv;
    }
}