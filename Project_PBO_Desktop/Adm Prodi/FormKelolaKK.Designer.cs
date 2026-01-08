namespace Project_PBO_Desktop
{
    partial class FormKelolaKK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaKK));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHapusKK = new System.Windows.Forms.Button();
            this.buttonUbahKK = new System.Windows.Forms.Button();
            this.buttonTambahKK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewKK = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MataKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKK)).BeginInit();
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
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonHapusKK);
            this.panel1.Controls.Add(this.buttonUbahKK);
            this.panel1.Controls.Add(this.buttonTambahKK);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 782);
            this.panel1.TabIndex = 19;
            // 
            // buttonHapusKK
            // 
            this.buttonHapusKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonHapusKK.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHapusKK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHapusKK.Location = new System.Drawing.Point(3, 453);
            this.buttonHapusKK.Name = "buttonHapusKK";
            this.buttonHapusKK.Size = new System.Drawing.Size(243, 77);
            this.buttonHapusKK.TabIndex = 4;
            this.buttonHapusKK.Text = "Hapus Kelas Kuliah";
            this.buttonHapusKK.UseVisualStyleBackColor = false;
            // 
            // buttonUbahKK
            // 
            this.buttonUbahKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonUbahKK.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbahKK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUbahKK.Location = new System.Drawing.Point(3, 370);
            this.buttonUbahKK.Name = "buttonUbahKK";
            this.buttonUbahKK.Size = new System.Drawing.Size(243, 77);
            this.buttonUbahKK.TabIndex = 3;
            this.buttonUbahKK.Text = "Ubah Kelas Kuliah";
            this.buttonUbahKK.UseVisualStyleBackColor = false;
            // 
            // buttonTambahKK
            // 
            this.buttonTambahKK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonTambahKK.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambahKK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambahKK.Location = new System.Drawing.Point(3, 287);
            this.buttonTambahKK.Name = "buttonTambahKK";
            this.buttonTambahKK.Size = new System.Drawing.Size(243, 77);
            this.buttonTambahKK.TabIndex = 2;
            this.buttonTambahKK.Text = "Tambah Kelas Kuliah";
            this.buttonTambahKK.UseVisualStyleBackColor = false;
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
            this.panel2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Kelola Kelas Kuliah";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
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
            this.Nomor,
            this.KodeKelas,
            this.NamaKelas,
            this.MataKuliah,
            this.Semester,
            this.Ruangan,
            this.Kapasitas,
            this.Peserta,
            this.Dosen});
            this.dataGridViewKK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewKK.Location = new System.Drawing.Point(303, 171);
            this.dataGridViewKK.MultiSelect = false;
            this.dataGridViewKK.Name = "dataGridViewKK";
            this.dataGridViewKK.ReadOnly = true;
            this.dataGridViewKK.RowHeadersVisible = false;
            this.dataGridViewKK.RowHeadersWidth = 51;
            this.dataGridViewKK.RowTemplate.Height = 24;
            this.dataGridViewKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKK.Size = new System.Drawing.Size(824, 406);
            this.dataGridViewKK.TabIndex = 21;
            // 
            // Nomor
            // 
            this.Nomor.HeaderText = "No.";
            this.Nomor.MinimumWidth = 6;
            this.Nomor.Name = "Nomor";
            this.Nomor.ReadOnly = true;
            // 
            // KodeKelas
            // 
            this.KodeKelas.HeaderText = "ID Kelas";
            this.KodeKelas.MinimumWidth = 6;
            this.KodeKelas.Name = "KodeKelas";
            this.KodeKelas.ReadOnly = true;
            // 
            // NamaKelas
            // 
            this.NamaKelas.HeaderText = "Nama Kelas";
            this.NamaKelas.MinimumWidth = 6;
            this.NamaKelas.Name = "NamaKelas";
            this.NamaKelas.ReadOnly = true;
            // 
            // MataKuliah
            // 
            this.MataKuliah.HeaderText = "MK";
            this.MataKuliah.MinimumWidth = 6;
            this.MataKuliah.Name = "MataKuliah";
            this.MataKuliah.ReadOnly = true;
            // 
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // Ruangan
            // 
            this.Ruangan.HeaderText = "Ruangan";
            this.Ruangan.MinimumWidth = 6;
            this.Ruangan.Name = "Ruangan";
            this.Ruangan.ReadOnly = true;
            // 
            // Kapasitas
            // 
            this.Kapasitas.HeaderText = "Kapasitas";
            this.Kapasitas.MinimumWidth = 6;
            this.Kapasitas.Name = "Kapasitas";
            this.Kapasitas.ReadOnly = true;
            // 
            // Peserta
            // 
            this.Peserta.HeaderText = "Jumlah Peserta";
            this.Peserta.MinimumWidth = 6;
            this.Peserta.Name = "Peserta";
            this.Peserta.ReadOnly = true;
            // 
            // Dosen
            // 
            this.Dosen.HeaderText = "Dosen";
            this.Dosen.MinimumWidth = 6;
            this.Dosen.Name = "Dosen";
            this.Dosen.ReadOnly = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonRefresh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(1031, 124);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 32);
            this.buttonRefresh.TabIndex = 22;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // FormKelolaKK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewKK);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKelolaKK";
            this.Text = "FormKelolaKK";
            this.Load += new System.EventHandler(this.FormKelolaKK_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHapusKK;
        private System.Windows.Forms.Button buttonUbahKK;
        private System.Windows.Forms.Button buttonTambahKK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peserta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosen;
        private System.Windows.Forms.Button buttonRefresh;
    }
}