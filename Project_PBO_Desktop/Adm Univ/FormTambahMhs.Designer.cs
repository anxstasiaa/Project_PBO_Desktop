namespace Project_PBO_Desktop
{
    partial class FormTambahMhs
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
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.labelNIM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTambah = new System.Windows.Forms.Label();
            this.comboBoxJenisKelamin = new System.Windows.Forms.ComboBox();
            this.buttonKembali = new System.Windows.Forms.Button();
            this.panelTambahBawah = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProdi = new System.Windows.Forms.ComboBox();
            this.buttonSimpanMhs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTambahBawah.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(275, 140);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(307, 22);
            this.textBoxNIM.TabIndex = 0;
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(225, 143);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(34, 16);
            this.labelNIM.TabIndex = 1;
            this.labelNIM.Text = "NIM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama:";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(275, 178);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(307, 22);
            this.textBoxNama.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Jenis Kelamin:";
            // 
            // labelTambah
            // 
            this.labelTambah.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelTambah.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTambah.Location = new System.Drawing.Point(0, 0);
            this.labelTambah.Name = "labelTambah";
            this.labelTambah.Size = new System.Drawing.Size(800, 64);
            this.labelTambah.TabIndex = 6;
            this.labelTambah.Text = "Tambah";
            this.labelTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTambah.Click += new System.EventHandler(this.labelTambah_Click);
            // 
            // comboBoxJenisKelamin
            // 
            this.comboBoxJenisKelamin.FormattingEnabled = true;
            this.comboBoxJenisKelamin.Items.AddRange(new object[] {
            "Perempuan",
            "Laki-laki"});
            this.comboBoxJenisKelamin.Location = new System.Drawing.Point(275, 217);
            this.comboBoxJenisKelamin.Name = "comboBoxJenisKelamin";
            this.comboBoxJenisKelamin.Size = new System.Drawing.Size(121, 24);
            this.comboBoxJenisKelamin.TabIndex = 7;
            this.comboBoxJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBoxJenisKelamin_SelectedIndexChanged);
            // 
            // buttonKembali
            // 
            this.buttonKembali.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKembali.Location = new System.Drawing.Point(692, 6);
            this.buttonKembali.Name = "buttonKembali";
            this.buttonKembali.Size = new System.Drawing.Size(96, 32);
            this.buttonKembali.TabIndex = 9;
            this.buttonKembali.Text = "Kembali";
            this.buttonKembali.UseVisualStyleBackColor = false;
            this.buttonKembali.Click += new System.EventHandler(this.buttonKembali_Click);
            // 
            // panelTambahBawah
            // 
            this.panelTambahBawah.BackColor = System.Drawing.Color.SlateGray;
            this.panelTambahBawah.Controls.Add(this.buttonKembali);
            this.panelTambahBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTambahBawah.Location = new System.Drawing.Point(0, 409);
            this.panelTambahBawah.Name = "panelTambahBawah";
            this.panelTambahBawah.Size = new System.Drawing.Size(800, 41);
            this.panelTambahBawah.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prodi:";
            // 
            // comboBoxProdi
            // 
            this.comboBoxProdi.FormattingEnabled = true;
            this.comboBoxProdi.Items.AddRange(new object[] {
            "Ilkom",
            "Biologi",
            "Fisika",
            "Kedokteran"});
            this.comboBoxProdi.Location = new System.Drawing.Point(275, 254);
            this.comboBoxProdi.Name = "comboBoxProdi";
            this.comboBoxProdi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProdi.TabIndex = 13;
            // 
            // buttonSimpanMhs
            // 
            this.buttonSimpanMhs.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSimpanMhs.Location = new System.Drawing.Point(692, 359);
            this.buttonSimpanMhs.Name = "buttonSimpanMhs";
            this.buttonSimpanMhs.Size = new System.Drawing.Size(96, 32);
            this.buttonSimpanMhs.TabIndex = 14;
            this.buttonSimpanMhs.Text = "SImpan";
            this.buttonSimpanMhs.UseVisualStyleBackColor = false;
            this.buttonSimpanMhs.Click += new System.EventHandler(this.buttonSimpanMhs_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ilkom",
            "Biologi",
            "Fisika",
            "Kedokteran"});
            this.comboBox1.Location = new System.Drawing.Point(275, 293);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tahun Masuk:";
            // 
            // FormTambahMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSimpanMhs);
            this.Controls.Add(this.comboBoxProdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTambahBawah);
            this.Controls.Add(this.comboBoxJenisKelamin);
            this.Controls.Add(this.labelTambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.labelNIM);
            this.Controls.Add(this.textBoxNIM);
            this.Name = "FormTambahMhs";
            this.Text = "FormTambahMahasiswa";
            this.panelTambahBawah.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTambah;
        private System.Windows.Forms.ComboBox comboBoxJenisKelamin;
        private System.Windows.Forms.Button buttonKembali;
        private System.Windows.Forms.Panel panelTambahBawah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProdi;
        private System.Windows.Forms.Button buttonSimpanMhs;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}