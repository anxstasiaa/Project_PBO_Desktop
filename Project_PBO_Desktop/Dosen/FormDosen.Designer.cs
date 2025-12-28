namespace Project_PBO_Desktop
{
    partial class FormDosen
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
            this.labelDosen = new System.Windows.Forms.Label();
            this.panelAdmUnivBawah = new System.Windows.Forms.Panel();
            this.buttonLogoutDosen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLihatKelas = new System.Windows.Forms.Button();
            this.buttonInputNilai = new System.Windows.Forms.Button();
            this.panelAdmUnivBawah.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDosen
            // 
            this.labelDosen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelDosen.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDosen.Location = new System.Drawing.Point(0, 0);
            this.labelDosen.Name = "labelDosen";
            this.labelDosen.Size = new System.Drawing.Size(800, 56);
            this.labelDosen.TabIndex = 0;
            this.labelDosen.Text = "Dosen";
            this.labelDosen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAdmUnivBawah
            // 
            this.panelAdmUnivBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelAdmUnivBawah.Controls.Add(this.buttonLogoutDosen);
            this.panelAdmUnivBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdmUnivBawah.Location = new System.Drawing.Point(0, 414);
            this.panelAdmUnivBawah.Name = "panelAdmUnivBawah";
            this.panelAdmUnivBawah.Size = new System.Drawing.Size(800, 36);
            this.panelAdmUnivBawah.TabIndex = 5;
            // 
            // buttonLogoutDosen
            // 
            this.buttonLogoutDosen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLogoutDosen.Location = new System.Drawing.Point(678, 3);
            this.buttonLogoutDosen.Name = "buttonLogoutDosen";
            this.buttonLogoutDosen.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutDosen.TabIndex = 3;
            this.buttonLogoutDosen.Text = "Logout";
            this.buttonLogoutDosen.UseVisualStyleBackColor = false;
            this.buttonLogoutDosen.Click += new System.EventHandler(this.buttonLogoutDosen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.buttonLihatKelas);
            this.panel1.Controls.Add(this.buttonInputNilai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 358);
            this.panel1.TabIndex = 6;
            // 
            // buttonLihatKelas
            // 
            this.buttonLihatKelas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLihatKelas.Location = new System.Drawing.Point(3, 152);
            this.buttonLihatKelas.Name = "buttonLihatKelas";
            this.buttonLihatKelas.Size = new System.Drawing.Size(171, 57);
            this.buttonLihatKelas.TabIndex = 1;
            this.buttonLihatKelas.Text = "Lihat Kelas";
            this.buttonLihatKelas.UseVisualStyleBackColor = false;
            this.buttonLihatKelas.Click += new System.EventHandler(this.buttonLihatKelas_Click);
            // 
            // buttonInputNilai
            // 
            this.buttonInputNilai.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonInputNilai.Location = new System.Drawing.Point(3, 232);
            this.buttonInputNilai.Name = "buttonInputNilai";
            this.buttonInputNilai.Size = new System.Drawing.Size(171, 57);
            this.buttonInputNilai.TabIndex = 2;
            this.buttonInputNilai.Text = "Input Nilai";
            this.buttonInputNilai.UseVisualStyleBackColor = false;
            this.buttonInputNilai.Click += new System.EventHandler(this.buttonInputNilai_Click);
            // 
            // FormDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAdmUnivBawah);
            this.Controls.Add(this.labelDosen);
            this.Name = "FormDosen";
            this.Text = "FormDosen";
            this.Load += new System.EventHandler(this.FormDosen_Load);
            this.panelAdmUnivBawah.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDosen;
        private System.Windows.Forms.Panel panelAdmUnivBawah;
        private System.Windows.Forms.Button buttonLogoutDosen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLihatKelas;
        private System.Windows.Forms.Button buttonInputNilai;
    }
}