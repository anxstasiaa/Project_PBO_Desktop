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
            this.buttonManajemenProdi = new System.Windows.Forms.Button();
            this.buttonManajemenMhs = new System.Windows.Forms.Button();
            this.buttonLogoutAdmUniv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonManajemenProdi
            // 
            this.buttonManajemenProdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonManajemenProdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonManajemenProdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonManajemenProdi.Image")));
            this.buttonManajemenProdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManajemenProdi.Location = new System.Drawing.Point(6, 301);
            this.buttonManajemenProdi.Name = "buttonManajemenProdi";
            this.buttonManajemenProdi.Size = new System.Drawing.Size(240, 75);
            this.buttonManajemenProdi.TabIndex = 1;
            this.buttonManajemenProdi.Text = "Manajemen Prodi";
            this.buttonManajemenProdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManajemenProdi.UseVisualStyleBackColor = false;
            this.buttonManajemenProdi.Click += new System.EventHandler(this.buttonManajemenProdi_Click);
            // 
            // buttonManajemenMhs
            // 
            this.buttonManajemenMhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonManajemenMhs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonManajemenMhs.Image = ((System.Drawing.Image)(resources.GetObject("buttonManajemenMhs.Image")));
            this.buttonManajemenMhs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManajemenMhs.Location = new System.Drawing.Point(6, 382);
            this.buttonManajemenMhs.Name = "buttonManajemenMhs";
            this.buttonManajemenMhs.Size = new System.Drawing.Size(240, 75);
            this.buttonManajemenMhs.TabIndex = 2;
            this.buttonManajemenMhs.Text = "Manajemen Mahasiswa";
            this.buttonManajemenMhs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManajemenMhs.UseVisualStyleBackColor = false;
            this.buttonManajemenMhs.Click += new System.EventHandler(this.buttonManajemenMhs_Click);
            // 
            // buttonLogoutAdmUniv
            // 
            this.buttonLogoutAdmUniv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonLogoutAdmUniv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogoutAdmUniv.Location = new System.Drawing.Point(1056, 631);
            this.buttonLogoutAdmUniv.Name = "buttonLogoutAdmUniv";
            this.buttonLogoutAdmUniv.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutAdmUniv.TabIndex = 3;
            this.buttonLogoutAdmUniv.Text = "Logout";
            this.buttonLogoutAdmUniv.UseVisualStyleBackColor = false;
            this.buttonLogoutAdmUniv.Click += new System.EventHandler(this.buttonLogoutAdmUniv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonManajemenProdi);
            this.panel1.Controls.Add(this.buttonManajemenMhs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 673);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(22, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selamat Datang, Admin Univ!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 41);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Admin Universitas";
            // 
            // labelX
            // 
            this.labelX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(1140, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 23);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdmUniv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.buttonLogoutAdmUniv);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdmUniv";
            this.Text = "FormAdmUniv";
            this.Load += new System.EventHandler(this.FormAdmUniv_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonManajemenProdi;
        private System.Windows.Forms.Button buttonManajemenMhs;
        private System.Windows.Forms.Button buttonLogoutAdmUniv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}