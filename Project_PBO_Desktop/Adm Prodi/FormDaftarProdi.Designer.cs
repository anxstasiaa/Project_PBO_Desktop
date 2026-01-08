namespace Project_PBO_Desktop
{
    partial class FormDaftarProdi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftarProdi));
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.dataGridViewDaftarProdi = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AliasProdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMhs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTambahProdi = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarProdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonKembali.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonKembali.Location = new System.Drawing.Point(1032, 617);
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
            this.label1.Size = new System.Drawing.Size(330, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Daftar Prodi";
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
            // dataGridViewDaftarProdi
            // 
            this.dataGridViewDaftarProdi.AllowUserToAddRows = false;
            this.dataGridViewDaftarProdi.AllowUserToDeleteRows = false;
            this.dataGridViewDaftarProdi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaftarProdi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDaftarProdi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDaftarProdi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDaftarProdi.ColumnHeadersHeight = 50;
            this.dataGridViewDaftarProdi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.KodeProdi,
            this.NamaProdi,
            this.AliasProdi,
            this.TotalMhs});
            this.dataGridViewDaftarProdi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewDaftarProdi.Location = new System.Drawing.Point(57, 165);
            this.dataGridViewDaftarProdi.MultiSelect = false;
            this.dataGridViewDaftarProdi.Name = "dataGridViewDaftarProdi";
            this.dataGridViewDaftarProdi.ReadOnly = true;
            this.dataGridViewDaftarProdi.RowHeadersVisible = false;
            this.dataGridViewDaftarProdi.RowHeadersWidth = 51;
            this.dataGridViewDaftarProdi.RowTemplate.Height = 24;
            this.dataGridViewDaftarProdi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaftarProdi.Size = new System.Drawing.Size(1071, 425);
            this.dataGridViewDaftarProdi.TabIndex = 10;
            this.dataGridViewDaftarProdi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // KodeProdi
            // 
            this.KodeProdi.HeaderText = "Kode Prodi";
            this.KodeProdi.MinimumWidth = 6;
            this.KodeProdi.Name = "KodeProdi";
            this.KodeProdi.ReadOnly = true;
            // 
            // NamaProdi
            // 
            this.NamaProdi.HeaderText = "Nama Prodi";
            this.NamaProdi.MinimumWidth = 6;
            this.NamaProdi.Name = "NamaProdi";
            this.NamaProdi.ReadOnly = true;
            // 
            // AliasProdi
            // 
            this.AliasProdi.HeaderText = "Alias";
            this.AliasProdi.MinimumWidth = 6;
            this.AliasProdi.Name = "AliasProdi";
            this.AliasProdi.ReadOnly = true;
            // 
            // TotalMhs
            // 
            this.TotalMhs.HeaderText = "Total Mahasiswa";
            this.TotalMhs.MinimumWidth = 6;
            this.TotalMhs.Name = "TotalMhs";
            this.TotalMhs.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cari Prodi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(446, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 22);
            this.textBox1.TabIndex = 13;
            // 
            // buttonTambahProdi
            // 
            this.buttonTambahProdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonTambahProdi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonTambahProdi.Location = new System.Drawing.Point(913, 101);
            this.buttonTambahProdi.Name = "buttonTambahProdi";
            this.buttonTambahProdi.Size = new System.Drawing.Size(96, 32);
            this.buttonTambahProdi.TabIndex = 14;
            this.buttonTambahProdi.Text = "Tambah";
            this.buttonTambahProdi.UseVisualStyleBackColor = false;
            this.buttonTambahProdi.Click += new System.EventHandler(this.buttonTambahProdi_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonRefresh.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonRefresh.Location = new System.Drawing.Point(1032, 101);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 32);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // FormDaftarProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonTambahProdi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewDaftarProdi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonKembali);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDaftarProdi";
            this.Text = "FormDaftarProdi";
            this.Load += new System.EventHandler(this.FormDaftarProdi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarProdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.DataGridView dataGridViewDaftarProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AliasProdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMhs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTambahProdi;
        private System.Windows.Forms.Button buttonRefresh;
    }
}