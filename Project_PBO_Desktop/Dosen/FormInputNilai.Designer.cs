namespace Project_PBO_Desktop
{
    partial class FormInputNilai
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelFilterProdi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewMhs = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NilaiAkhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HurufMutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonHitung = new System.Windows.Forms.Button();
            this.textBoxNilaiAkhir = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxAngkaMutu = new System.Windows.Forms.TextBox();
            this.textBoxHurufMutu = new System.Windows.Forms.TextBox();
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
            this.label1.Size = new System.Drawing.Size(317, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Input Nilai";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelFilterProdi);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 84);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pilih Kelas";
            // 
            // labelFilterProdi
            // 
            this.labelFilterProdi.AutoSize = true;
            this.labelFilterProdi.Location = new System.Drawing.Point(6, 48);
            this.labelFilterProdi.Name = "labelFilterProdi";
            this.labelFilterProdi.Size = new System.Drawing.Size(42, 16);
            this.labelFilterProdi.TabIndex = 2;
            this.labelFilterProdi.Text = "Kelas:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
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
            this.NIM,
            this.NamaMhs,
            this.NilaiAkhir,
            this.HurufMutu});
            this.dataGridViewMhs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMhs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewMhs.Location = new System.Drawing.Point(26, 150);
            this.dataGridViewMhs.MultiSelect = false;
            this.dataGridViewMhs.Name = "dataGridViewMhs";
            this.dataGridViewMhs.ReadOnly = true;
            this.dataGridViewMhs.RowHeadersVisible = false;
            this.dataGridViewMhs.RowHeadersWidth = 51;
            this.dataGridViewMhs.RowTemplate.Height = 24;
            this.dataGridViewMhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMhs.Size = new System.Drawing.Size(1122, 240);
            this.dataGridViewMhs.TabIndex = 20;
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
            // NamaMhs
            // 
            this.NamaMhs.HeaderText = "Nama Mahasiswa";
            this.NamaMhs.MinimumWidth = 6;
            this.NamaMhs.Name = "NamaMhs";
            this.NamaMhs.ReadOnly = true;
            // 
            // NilaiAkhir
            // 
            this.NilaiAkhir.HeaderText = "Nilai Akhir";
            this.NilaiAkhir.MinimumWidth = 6;
            this.NilaiAkhir.Name = "NilaiAkhir";
            this.NilaiAkhir.ReadOnly = true;
            // 
            // HurufMutu
            // 
            this.HurufMutu.HeaderText = "Huruf Mutu";
            this.HurufMutu.MinimumWidth = 6;
            this.HurufMutu.Name = "HurufMutu";
            this.HurufMutu.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.groupBox2.Location = new System.Drawing.Point(26, 405);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1122, 116);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nilai Akhir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Angka Mutu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Huruf Mutu:";
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKembali.Location = new System.Drawing.Point(1052, 609);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 25;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(229)))));
            this.buttonSimpan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonSimpan.Location = new System.Drawing.Point(1043, 97);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(105, 40);
            this.buttonSimpan.TabIndex = 27;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // buttonHitung
            // 
            this.buttonHitung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(174)))), ((int)(((byte)(229)))));
            this.buttonHitung.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonHitung.Location = new System.Drawing.Point(912, 97);
            this.buttonHitung.Name = "buttonHitung";
            this.buttonHitung.Size = new System.Drawing.Size(105, 40);
            this.buttonHitung.TabIndex = 26;
            this.buttonHitung.Text = "Hitung";
            this.buttonHitung.UseVisualStyleBackColor = false;
            // 
            // textBoxNilaiAkhir
            // 
            this.textBoxNilaiAkhir.Location = new System.Drawing.Point(102, 531);
            this.textBoxNilaiAkhir.Name = "textBoxNilaiAkhir";
            this.textBoxNilaiAkhir.Size = new System.Drawing.Size(100, 22);
            this.textBoxNilaiAkhir.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxAngkaMutu
            // 
            this.textBoxAngkaMutu.Location = new System.Drawing.Point(565, 530);
            this.textBoxAngkaMutu.Name = "textBoxAngkaMutu";
            this.textBoxAngkaMutu.Size = new System.Drawing.Size(100, 22);
            this.textBoxAngkaMutu.TabIndex = 30;
            // 
            // textBoxHurufMutu
            // 
            this.textBoxHurufMutu.Location = new System.Drawing.Point(987, 530);
            this.textBoxHurufMutu.Name = "textBoxHurufMutu";
            this.textBoxHurufMutu.Size = new System.Drawing.Size(100, 22);
            this.textBoxHurufMutu.TabIndex = 31;
            // 
            // FormInputNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.textBoxHurufMutu);
            this.Controls.Add(this.textBoxAngkaMutu);
            this.Controls.Add(this.textBoxNilaiAkhir);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.buttonHitung);
            this.Controls.Add(this.buttonKembali);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewMhs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInputNilai";
            this.Text = "FormInputNilai";
            this.Load += new System.EventHandler(this.FormInputNilai_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelFilterProdi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMhs;
        private System.Windows.Forms.DataGridViewTextBoxColumn NilaiAkhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn HurufMutu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.Button buttonHitung;
        private System.Windows.Forms.TextBox textBoxNilaiAkhir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxAngkaMutu;
        private System.Windows.Forms.TextBox textBoxHurufMutu;
    }
}