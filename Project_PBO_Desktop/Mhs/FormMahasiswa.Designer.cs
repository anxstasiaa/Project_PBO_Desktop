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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMahasiswa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLogoutMhs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonTagihan = new System.Windows.Forms.Button();
            this.buttonKHS = new System.Windows.Forms.Button();
            this.buttonKRS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewKK = new System.Windows.Forms.DataGridView();
            this.MataKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogoutMhs
            // 
            this.buttonLogoutMhs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonLogoutMhs.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogoutMhs.Location = new System.Drawing.Point(1056, 631);
            this.buttonLogoutMhs.Name = "buttonLogoutMhs";
            this.buttonLogoutMhs.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutMhs.TabIndex = 3;
            this.buttonLogoutMhs.Text = "Logout";
            this.buttonLogoutMhs.UseVisualStyleBackColor = false;
            this.buttonLogoutMhs.Click += new System.EventHandler(this.buttonLogoutMhs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonTagihan);
            this.panel1.Controls.Add(this.buttonKHS);
            this.panel1.Controls.Add(this.buttonKRS);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 804);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(25, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 56);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selamat Datang, Mahasiswa!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // buttonTagihan
            // 
            this.buttonTagihan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonTagihan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTagihan.Image = ((System.Drawing.Image)(resources.GetObject("buttonTagihan.Image")));
            this.buttonTagihan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTagihan.Location = new System.Drawing.Point(3, 473);
            this.buttonTagihan.Name = "buttonTagihan";
            this.buttonTagihan.Size = new System.Drawing.Size(243, 77);
            this.buttonTagihan.TabIndex = 3;
            this.buttonTagihan.Text = "Lihat - Bayar Tagihan";
            this.buttonTagihan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTagihan.UseVisualStyleBackColor = false;
            this.buttonTagihan.Click += new System.EventHandler(this.buttonTagihan_Click);
            // 
            // buttonKHS
            // 
            this.buttonKHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonKHS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKHS.Image = ((System.Drawing.Image)(resources.GetObject("buttonKHS.Image")));
            this.buttonKHS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKHS.Location = new System.Drawing.Point(3, 390);
            this.buttonKHS.Name = "buttonKHS";
            this.buttonKHS.Size = new System.Drawing.Size(243, 77);
            this.buttonKHS.TabIndex = 2;
            this.buttonKHS.Text = "Lihat KHS";
            this.buttonKHS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKHS.UseVisualStyleBackColor = false;
            this.buttonKHS.Click += new System.EventHandler(this.buttonKHS_Click);
            // 
            // buttonKRS
            // 
            this.buttonKRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonKRS.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKRS.Image = ((System.Drawing.Image)(resources.GetObject("buttonKRS.Image")));
            this.buttonKRS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKRS.Location = new System.Drawing.Point(3, 307);
            this.buttonKRS.Name = "buttonKRS";
            this.buttonKRS.Size = new System.Drawing.Size(243, 77);
            this.buttonKRS.TabIndex = 1;
            this.buttonKRS.Text = "Lihat KRS";
            this.buttonKRS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKRS.UseVisualStyleBackColor = false;
            this.buttonKRS.Click += new System.EventHandler(this.buttonKRS_Click);
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
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Mahasiswa";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(293, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 43);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dashboard Mahasiswa";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panelDashboard.Controls.Add(this.label7);
            this.panelDashboard.Controls.Add(this.label6);
            this.panelDashboard.Controls.Add(this.label5);
            this.panelDashboard.Controls.Add(this.label4);
            this.panelDashboard.Location = new System.Drawing.Point(293, 65);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(835, 281);
            this.panelDashboard.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Mahasiswa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "NIM:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Program Studi:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "Semester Aktif:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKK
            // 
            this.dataGridViewKK.AllowUserToAddRows = false;
            this.dataGridViewKK.AllowUserToDeleteRows = false;
            this.dataGridViewKK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MataKuliah,
            this.NamaMK,
            this.Kelas,
            this.SKS,
            this.Dosen});
            this.dataGridViewKK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewKK.Location = new System.Drawing.Point(293, 364);
            this.dataGridViewKK.MultiSelect = false;
            this.dataGridViewKK.Name = "dataGridViewKK";
            this.dataGridViewKK.ReadOnly = true;
            this.dataGridViewKK.RowHeadersVisible = false;
            this.dataGridViewKK.RowHeadersWidth = 51;
            this.dataGridViewKK.RowTemplate.Height = 24;
            this.dataGridViewKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKK.Size = new System.Drawing.Size(835, 247);
            this.dataGridViewKK.TabIndex = 23;
            this.dataGridViewKK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKK_CellContentClick);
            // 
            // MataKuliah
            // 
            this.MataKuliah.HeaderText = "Kode MK";
            this.MataKuliah.MinimumWidth = 6;
            this.MataKuliah.Name = "MataKuliah";
            this.MataKuliah.ReadOnly = true;
            // 
            // NamaMK
            // 
            this.NamaMK.HeaderText = "Nama MK";
            this.NamaMK.MinimumWidth = 6;
            this.NamaMK.Name = "NamaMK";
            this.NamaMK.ReadOnly = true;
            // 
            // Kelas
            // 
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.MinimumWidth = 6;
            this.Kelas.Name = "Kelas";
            this.Kelas.ReadOnly = true;
            // 
            // SKS
            // 
            this.SKS.HeaderText = "SKS";
            this.SKS.MinimumWidth = 6;
            this.SKS.Name = "SKS";
            this.SKS.ReadOnly = true;
            // 
            // Dosen
            // 
            this.Dosen.HeaderText = "Dosen";
            this.Dosen.MinimumWidth = 6;
            this.Dosen.Name = "Dosen";
            this.Dosen.ReadOnly = true;
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.dataGridViewKK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLogoutMhs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.Load += new System.EventHandler(this.FormMahasiswa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogoutMhs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonKRS;
        private System.Windows.Forms.Button buttonTagihan;
        private System.Windows.Forms.Button buttonKHS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosen;
    }
}