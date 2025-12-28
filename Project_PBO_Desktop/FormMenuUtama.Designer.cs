namespace Project_PBO_Desktop
{
    partial class PBO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PBO));
            this.labelMenuUtama = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelMenuUtama
            // 
            this.labelMenuUtama.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMenuUtama.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMenuUtama.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuUtama.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelMenuUtama.Image = ((System.Drawing.Image)(resources.GetObject("labelMenuUtama.Image")));
            this.labelMenuUtama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelMenuUtama.Location = new System.Drawing.Point(0, 0);
            this.labelMenuUtama.Name = "labelMenuUtama";
            this.labelMenuUtama.Size = new System.Drawing.Size(814, 69);
            this.labelMenuUtama.TabIndex = 1;
            this.labelMenuUtama.Text = "Selamat Datang di Sistem Akademik!";
            this.labelMenuUtama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMenuUtama.Click += new System.EventHandler(this.labelMenuUtama_Click);
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.Location = new System.Drawing.Point(147, 373);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(163, 27);
            this.linkLabelLogin.TabIndex = 2;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Login";
            this.linkLabelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_Click);
            // 
            // linkLabelRegister
            // 
            this.linkLabelRegister.Location = new System.Drawing.Point(493, 373);
            this.linkLabelRegister.Name = "linkLabelRegister";
            this.linkLabelRegister.Size = new System.Drawing.Size(163, 27);
            this.linkLabelRegister.TabIndex = 3;
            this.linkLabelRegister.TabStop = true;
            this.linkLabelRegister.Text = "Register";
            this.linkLabelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRegister_Click);
            // 
            // PBO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.linkLabelRegister);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.labelMenuUtama);
            this.Name = "PBO";
            this.Text = "PBO";
            this.Load += new System.EventHandler(this.PBO_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelMenuUtama;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.LinkLabel linkLabelRegister;
    }
}

