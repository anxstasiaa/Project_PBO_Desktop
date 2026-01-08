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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.dataGridViewMhs = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglLahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilterAkt = new System.Windows.Forms.Label();
            this.labelFilterProdi = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelTotalMhs = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalData = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMhs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKembali.Location = new System.Drawing.Point(1052, 582);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 9;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
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
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Daftar Mahasiswa";
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
            // dataGridViewMhs
            // 
            this.dataGridViewMhs.AllowUserToAddRows = false;
            this.dataGridViewMhs.AllowUserToDeleteRows = false;
            this.dataGridViewMhs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMhs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMhs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMhs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomor,
            this.NIM,
            this.Nama,
            this.Prodi,
            this.JK,
            this.Angkatan,
            this.TglLahir});
            this.dataGridViewMhs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMhs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewMhs.Location = new System.Drawing.Point(31, 201);
            this.dataGridViewMhs.MultiSelect = false;
            this.dataGridViewMhs.Name = "dataGridViewMhs";
            this.dataGridViewMhs.ReadOnly = true;
            this.dataGridViewMhs.RowHeadersVisible = false;
            this.dataGridViewMhs.RowHeadersWidth = 51;
            this.dataGridViewMhs.RowTemplate.Height = 24;
            this.dataGridViewMhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMhs.Size = new System.Drawing.Size(1117, 339);
            this.dataGridViewMhs.TabIndex = 11;
            this.dataGridViewMhs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nomor
            // 
            this.Nomor.HeaderText = "No.";
            this.Nomor.MinimumWidth = 6;
            this.Nomor.Name = "Nomor";
            this.Nomor.ReadOnly = true;
            this.Nomor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NIM
            // 
            this.NIM.HeaderText = "NIM";
            this.NIM.MinimumWidth = 6;
            this.NIM.Name = "NIM";
            this.NIM.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama Mahasiswa";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Prodi
            // 
            this.Prodi.HeaderText = "Program Studi";
            this.Prodi.MinimumWidth = 6;
            this.Prodi.Name = "Prodi";
            this.Prodi.ReadOnly = true;
            // 
            // JK
            // 
            this.JK.HeaderText = "JK";
            this.JK.MinimumWidth = 6;
            this.JK.Name = "JK";
            this.JK.ReadOnly = true;
            // 
            // Angkatan
            // 
            this.Angkatan.HeaderText = "Angkatan";
            this.Angkatan.MinimumWidth = 6;
            this.Angkatan.Name = "Angkatan";
            this.Angkatan.ReadOnly = true;
            // 
            // TglLahir
            // 
            this.TglLahir.HeaderText = "Tgl Lahir";
            this.TglLahir.MinimumWidth = 6;
            this.TglLahir.Name = "TglLahir";
            this.TglLahir.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFilterAkt);
            this.groupBox1.Controls.Add(this.labelFilterProdi);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelFilterAkt
            // 
            this.labelFilterAkt.AutoSize = true;
            this.labelFilterAkt.Location = new System.Drawing.Point(6, 51);
            this.labelFilterAkt.Name = "labelFilterAkt";
            this.labelFilterAkt.Size = new System.Drawing.Size(98, 16);
            this.labelFilterAkt.TabIndex = 3;
            this.labelFilterAkt.Text = "Filter Angkatan:";
            // 
            // labelFilterProdi
            // 
            this.labelFilterProdi.AutoSize = true;
            this.labelFilterProdi.Location = new System.Drawing.Point(6, 19);
            this.labelFilterProdi.Name = "labelFilterProdi";
            this.labelFilterProdi.Size = new System.Drawing.Size(74, 16);
            this.labelFilterProdi.TabIndex = 2;
            this.labelFilterProdi.Text = "Filter Prodi:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonUbah.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonUbah.Location = new System.Drawing.Point(950, 148);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(96, 32);
            this.buttonUbah.TabIndex = 17;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // buttonTampilkan
            // 
            this.buttonTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonTampilkan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTampilkan.Location = new System.Drawing.Point(88, 156);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(152, 24);
            this.buttonTampilkan.TabIndex = 16;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonHapus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHapus.Location = new System.Drawing.Point(1052, 148);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(96, 32);
            this.buttonHapus.TabIndex = 18;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonRefresh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(1052, 56);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 32);
            this.buttonRefresh.TabIndex = 20;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonTambah.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambah.Location = new System.Drawing.Point(848, 148);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(96, 32);
            this.buttonTambah.TabIndex = 21;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // labelTotalMhs
            // 
            this.labelTotalMhs.AutoSize = true;
            this.labelTotalMhs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMhs.Location = new System.Drawing.Point(28, 560);
            this.labelTotalMhs.Name = "labelTotalMhs";
            this.labelTotalMhs.Size = new System.Drawing.Size(121, 18);
            this.labelTotalMhs.TabIndex = 22;
            this.labelTotalMhs.Text = "Total Mahasiswa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 23;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(150, 560);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 16);
            this.labelTotal.TabIndex = 24;
            // 
            // labelTotalData
            // 
            this.labelTotalData.AutoSize = true;
            this.labelTotalData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalData.Location = new System.Drawing.Point(150, 562);
            this.labelTotalData.Name = "labelTotalData";
            this.labelTotalData.Size = new System.Drawing.Size(16, 18);
            this.labelTotalData.TabIndex = 25;
            this.labelTotalData.Text = "0";
            // 
            // FormDaftarMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.labelTotalData);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalMhs);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMhs);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonKembali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarMhs";
            this.Text = "FormDaftarMhs";
            this.Load += new System.EventHandler(this.FormDaftarMhs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMhs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.DataGridView dataGridViewMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn JK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelFilterAkt;
        private System.Windows.Forms.Label labelFilterProdi;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelTotalMhs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalData;
    }
}