namespace Project_PBO_Desktop
{
    partial class FormDaftarKKDosen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.buttonTampilkan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFilterProdi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewMhs = new System.Windows.Forms.DataGridView();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeKelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peserta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMhs)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Daftar Kelas Kuliah";
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
            // buttonTampilkan
            // 
            this.buttonTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonTampilkan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTampilkan.Location = new System.Drawing.Point(79, 124);
            this.buttonTampilkan.Name = "buttonTampilkan";
            this.buttonTampilkan.Size = new System.Drawing.Size(152, 24);
            this.buttonTampilkan.TabIndex = 18;
            this.buttonTampilkan.Text = "Tampilkan";
            this.buttonTampilkan.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFilterProdi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // labelFilterProdi
            // 
            this.labelFilterProdi.AutoSize = true;
            this.labelFilterProdi.Location = new System.Drawing.Point(6, 19);
            this.labelFilterProdi.Name = "labelFilterProdi";
            this.labelFilterProdi.Size = new System.Drawing.Size(67, 16);
            this.labelFilterProdi.TabIndex = 2;
            this.labelFilterProdi.Text = "Semester:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
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
            this.KodeKelas,
            this.MK,
            this.Kelas,
            this.Kapasitas,
            this.Peserta});
            this.dataGridViewMhs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMhs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewMhs.Location = new System.Drawing.Point(29, 186);
            this.dataGridViewMhs.MultiSelect = false;
            this.dataGridViewMhs.Name = "dataGridViewMhs";
            this.dataGridViewMhs.ReadOnly = true;
            this.dataGridViewMhs.RowHeadersVisible = false;
            this.dataGridViewMhs.RowHeadersWidth = 51;
            this.dataGridViewMhs.RowTemplate.Height = 24;
            this.dataGridViewMhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMhs.Size = new System.Drawing.Size(1117, 365);
            this.dataGridViewMhs.TabIndex = 19;
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKembali.Location = new System.Drawing.Point(1070, 604);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 20;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // Nomor
            // 
            this.Nomor.HeaderText = "No.";
            this.Nomor.MinimumWidth = 6;
            this.Nomor.Name = "Nomor";
            this.Nomor.ReadOnly = true;
            this.Nomor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KodeKelas
            // 
            this.KodeKelas.HeaderText = "Kode Kelas";
            this.KodeKelas.MinimumWidth = 6;
            this.KodeKelas.Name = "KodeKelas";
            this.KodeKelas.ReadOnly = true;
            // 
            // MK
            // 
            this.MK.HeaderText = "Mata Kuliah";
            this.MK.MinimumWidth = 6;
            this.MK.Name = "MK";
            this.MK.ReadOnly = true;
            // 
            // Kelas
            // 
            this.Kelas.HeaderText = "Kelas";
            this.Kelas.MinimumWidth = 6;
            this.Kelas.Name = "Kelas";
            this.Kelas.ReadOnly = true;
            // 
            // Kapasitas
            // 
            this.Kapasitas.HeaderText = "Kapasitas Kelas";
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
            // FormDaftarKKDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.dataGridViewMhs);
            this.Controls.Add(this.buttonTampilkan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarKKDosen";
            this.Text = "FormDaftarKKDosen";
            this.Load += new System.EventHandler(this.FormDaftarKKDosen_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMhs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Button buttonTampilkan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFilterProdi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeKelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn MK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peserta;
        private System.Windows.Forms.Button buttonKembali;
    }
}