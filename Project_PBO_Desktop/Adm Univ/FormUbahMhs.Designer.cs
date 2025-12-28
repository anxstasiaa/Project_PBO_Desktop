namespace Project_PBO_Desktop.Adm_Univ
{
    partial class FormUbahMhs
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
            this.labelHapusMhs = new System.Windows.Forms.Label();
            this.panelTambahBawah = new System.Windows.Forms.Panel();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.labelNIM = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.panelTambahBawah.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHapusMhs
            // 
            this.labelHapusMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelHapusMhs.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHapusMhs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHapusMhs.Location = new System.Drawing.Point(0, 0);
            this.labelHapusMhs.Name = "labelHapusMhs";
            this.labelHapusMhs.Size = new System.Drawing.Size(800, 57);
            this.labelHapusMhs.TabIndex = 18;
            this.labelHapusMhs.Text = "Ubah Mahasiswa";
            this.labelHapusMhs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTambahBawah
            // 
            this.panelTambahBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelTambahBawah.Controls.Add(this.buttonKembali);
            this.panelTambahBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambahBawah.Location = new System.Drawing.Point(0, 409);
            this.panelTambahBawah.Name = "panelTambahBawah";
            this.panelTambahBawah.Size = new System.Drawing.Size(800, 41);
            this.panelTambahBawah.TabIndex = 20;
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
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(300, 200);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(207, 16);
            this.labelNIM.TabIndex = 22;
            this.labelNIM.Text = "Masukkan NIM yang ingin diubah:";
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNIM.Location = new System.Drawing.Point(247, 228);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(307, 22);
            this.textBoxNIM.TabIndex = 21;
            // 
            // FormUbahMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.panelTambahBawah);
            this.Controls.Add(this.labelHapusMhs);
            this.Name = "FormUbahMhs";
            this.Text = "FormUbahMhs";
            this.panelTambahBawah.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHapusMhs;
        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.TextBox textBoxNIM;
    }
}