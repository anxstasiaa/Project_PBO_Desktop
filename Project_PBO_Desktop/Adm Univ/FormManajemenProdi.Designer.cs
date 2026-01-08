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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManajemenProdi));
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonKelolaTagihanMhs = new System.Windows.Forms.Button();
            this.buttonDaftarProdi = new System.Windows.Forms.Button();
            this.buttonTambahProdi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKembali.Location = new System.Drawing.Point(1070, 629);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 9;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonKelolaTagihanMhs);
            this.panel1.Controls.Add(this.buttonDaftarProdi);
            this.panel1.Controls.Add(this.buttonTambahProdi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 780);
            this.panel1.TabIndex = 12;
            // 
            // buttonKelolaTagihanMhs
            // 
            this.buttonKelolaTagihanMhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonKelolaTagihanMhs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKelolaTagihanMhs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKelolaTagihanMhs.Location = new System.Drawing.Point(3, 467);
            this.buttonKelolaTagihanMhs.Name = "buttonKelolaTagihanMhs";
            this.buttonKelolaTagihanMhs.Size = new System.Drawing.Size(243, 77);
            this.buttonKelolaTagihanMhs.TabIndex = 3;
            this.buttonKelolaTagihanMhs.Text = "Manajemen Tagihan Mahasiswa";
            this.buttonKelolaTagihanMhs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKelolaTagihanMhs.UseVisualStyleBackColor = false;
            // 
            // buttonDaftarProdi
            // 
            this.buttonDaftarProdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonDaftarProdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDaftarProdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonDaftarProdi.Image")));
            this.buttonDaftarProdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDaftarProdi.Location = new System.Drawing.Point(3, 301);
            this.buttonDaftarProdi.Name = "buttonDaftarProdi";
            this.buttonDaftarProdi.Size = new System.Drawing.Size(243, 77);
            this.buttonDaftarProdi.TabIndex = 1;
            this.buttonDaftarProdi.Text = "Lihat Daftar Prodi";
            this.buttonDaftarProdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDaftarProdi.UseVisualStyleBackColor = false;
            this.buttonDaftarProdi.Click += new System.EventHandler(this.buttonDaftarProdi_Click);
            // 
            // buttonTambahProdi
            // 
            this.buttonTambahProdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonTambahProdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambahProdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonTambahProdi.Image")));
            this.buttonTambahProdi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambahProdi.Location = new System.Drawing.Point(3, 384);
            this.buttonTambahProdi.Name = "buttonTambahProdi";
            this.buttonTambahProdi.Size = new System.Drawing.Size(243, 77);
            this.buttonTambahProdi.TabIndex = 2;
            this.buttonTambahProdi.Text = "Tambah Prodi";
            this.buttonTambahProdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTambahProdi.UseVisualStyleBackColor = false;
            this.buttonTambahProdi.Click += new System.EventHandler(this.buttonTambahProdi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1178, 41);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Manajemen Prodi";
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
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(27, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 56);
            this.label2.TabIndex = 13;
            this.label2.Text = "Menu Manajemen Prodi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormManajemenProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManajemenProdi";
            this.Text = "FormManajemenProdi";
            this.Load += new System.EventHandler(this.FormManajemenProdi_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKelolaTagihanMhs;
        private System.Windows.Forms.Button buttonDaftarProdi;
        private System.Windows.Forms.Button buttonTambahProdi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}