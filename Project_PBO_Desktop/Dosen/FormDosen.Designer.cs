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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDosen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonLogoutDosen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonLihatKelas = new System.Windows.Forms.Button();
            this.buttonInputNilai = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewKK = new System.Windows.Forms.DataGridView();
            this.MataKuliah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaMK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKK)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogoutDosen
            // 
            this.buttonLogoutDosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.buttonLogoutDosen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLogoutDosen.Location = new System.Drawing.Point(1056, 631);
            this.buttonLogoutDosen.Name = "buttonLogoutDosen";
            this.buttonLogoutDosen.Size = new System.Drawing.Size(110, 30);
            this.buttonLogoutDosen.TabIndex = 3;
            this.buttonLogoutDosen.Text = "Logout";
            this.buttonLogoutDosen.UseVisualStyleBackColor = false;
            this.buttonLogoutDosen.Click += new System.EventHandler(this.buttonLogoutDosen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonLihatKelas);
            this.panel1.Controls.Add(this.buttonInputNilai);
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
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 56);
            this.label2.TabIndex = 11;
            this.label2.Text = "Selamat Datang, Dosen!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // buttonLihatKelas
            // 
            this.buttonLihatKelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonLihatKelas.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonLihatKelas.Image = ((System.Drawing.Image)(resources.GetObject("buttonLihatKelas.Image")));
            this.buttonLihatKelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLihatKelas.Location = new System.Drawing.Point(6, 300);
            this.buttonLihatKelas.Name = "buttonLihatKelas";
            this.buttonLihatKelas.Size = new System.Drawing.Size(240, 75);
            this.buttonLihatKelas.TabIndex = 1;
            this.buttonLihatKelas.Text = "Lihat Kelas";
            this.buttonLihatKelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLihatKelas.UseVisualStyleBackColor = false;
            this.buttonLihatKelas.Click += new System.EventHandler(this.buttonLihatKelas_Click);
            // 
            // buttonInputNilai
            // 
            this.buttonInputNilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.buttonInputNilai.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonInputNilai.Image = ((System.Drawing.Image)(resources.GetObject("buttonInputNilai.Image")));
            this.buttonInputNilai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInputNilai.Location = new System.Drawing.Point(6, 380);
            this.buttonInputNilai.Name = "buttonInputNilai";
            this.buttonInputNilai.Size = new System.Drawing.Size(240, 75);
            this.buttonInputNilai.TabIndex = 2;
            this.buttonInputNilai.Text = "Input Nilai";
            this.buttonInputNilai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInputNilai.UseVisualStyleBackColor = false;
            this.buttonInputNilai.Click += new System.EventHandler(this.buttonInputNilai_Click);
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
            this.label1.Size = new System.Drawing.Size(288, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sistem Akademik Universitas | Dosen";
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
            this.panel3.Location = new System.Drawing.Point(292, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 43);
            this.panel3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dashboard Dosen";
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.panelDashboard.Controls.Add(this.label5);
            this.panelDashboard.Controls.Add(this.label4);
            this.panelDashboard.Location = new System.Drawing.Point(292, 75);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(835, 229);
            this.panelDashboard.TabIndex = 10;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Kelas Diampu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nama Dosen:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewKK
            // 
            this.dataGridViewKK.AllowUserToAddRows = false;
            this.dataGridViewKK.AllowUserToDeleteRows = false;
            this.dataGridViewKK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MataKuliah,
            this.NamaMK,
            this.Kelas,
            this.Semester});
            this.dataGridViewKK.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(199)))), ((int)(((byte)(213)))));
            this.dataGridViewKK.Location = new System.Drawing.Point(292, 328);
            this.dataGridViewKK.MultiSelect = false;
            this.dataGridViewKK.Name = "dataGridViewKK";
            this.dataGridViewKK.ReadOnly = true;
            this.dataGridViewKK.RowHeadersVisible = false;
            this.dataGridViewKK.RowHeadersWidth = 51;
            this.dataGridViewKK.RowTemplate.Height = 24;
            this.dataGridViewKK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKK.Size = new System.Drawing.Size(835, 273);
            this.dataGridViewKK.TabIndex = 22;
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
            // Semester
            // 
            this.Semester.HeaderText = "Semester";
            this.Semester.MinimumWidth = 6;
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            // 
            // FormDosen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(227)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1178, 673);
            this.Controls.Add(this.dataGridViewKK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonLogoutDosen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDosen";
            this.Text = "FormDosen";
            this.Load += new System.EventHandler(this.FormDosen_Load);
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
        private System.Windows.Forms.Button buttonLogoutDosen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLihatKelas;
        private System.Windows.Forms.Button buttonInputNilai;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewKK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MataKuliah;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaMK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
    }
}