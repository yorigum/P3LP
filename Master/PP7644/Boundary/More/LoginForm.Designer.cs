namespace PP7644.Boundary
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lblAplikasi = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblMasuk = new System.Windows.Forms.Label();
            this.help = new System.Windows.Forms.Label();
            this.cbmasuk = new System.Windows.Forms.CheckBox();
            this.pict = new System.Windows.Forms.PictureBox();
            this.btnLoginMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAplikasi
            // 
            this.lblAplikasi.AutoSize = true;
            this.lblAplikasi.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Bold);
            this.lblAplikasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAplikasi.Location = new System.Drawing.Point(361, 65);
            this.lblAplikasi.Name = "lblAplikasi";
            this.lblAplikasi.Size = new System.Drawing.Size(140, 43);
            this.lblAplikasi.TabIndex = 0;
            this.lblAplikasi.Text = "Fit N Fun";
            this.lblAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKeterangan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKeterangan.Location = new System.Drawing.Point(322, 113);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(216, 26);
            this.lblKeterangan.TabIndex = 1;
            this.lblKeterangan.Text = "Silahkan Login terlebih dahulu.\r\nGunakan Username dan Password Anda!";
            this.lblKeterangan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(297, 156);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(297, 188);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(58, 13);
            this.lblpass.TabIndex = 3;
            this.lblpass.Text = "Password";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(364, 156);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(158, 13);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Location = new System.Drawing.Point(364, 188);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(158, 13);
            this.txtPass.TabIndex = 5;
            // 
            // lblMasuk
            // 
            this.lblMasuk.AutoSize = true;
            this.lblMasuk.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMasuk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMasuk.Location = new System.Drawing.Point(325, 289);
            this.lblMasuk.Name = "lblMasuk";
            this.lblMasuk.Size = new System.Drawing.Size(99, 13);
            this.lblMasuk.TabIndex = 7;
            this.lblMasuk.Text = "Tidak bisa masuk?";
            this.lblMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.help.Location = new System.Drawing.Point(425, 289);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(51, 13);
            this.help.TabIndex = 8;
            this.help.Text = "Bantuan";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbmasuk
            // 
            this.cbmasuk.AutoSize = true;
            this.cbmasuk.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmasuk.Location = new System.Drawing.Point(364, 227);
            this.cbmasuk.Name = "cbmasuk";
            this.cbmasuk.Size = new System.Drawing.Size(89, 17);
            this.cbmasuk.TabIndex = 10;
            this.cbmasuk.Text = "tetap masuk";
            this.cbmasuk.UseVisualStyleBackColor = true;
            // 
            // pict
            // 
            this.pict.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pict.BackgroundImage")));
            this.pict.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pict.Dock = System.Windows.Forms.DockStyle.Left;
            this.pict.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pict.ErrorImage")));
            this.pict.InitialImage = ((System.Drawing.Image)(resources.GetObject("pict.InitialImage")));
            this.pict.Location = new System.Drawing.Point(0, 0);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(291, 370);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pict.TabIndex = 11;
            this.pict.TabStop = false;
            // 
            // btnLoginMenu
            // 
            this.btnLoginMenu.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLoginMenu.Location = new System.Drawing.Point(459, 221);
            this.btnLoginMenu.Name = "btnLoginMenu";
            this.btnLoginMenu.Size = new System.Drawing.Size(63, 23);
            this.btnLoginMenu.TabIndex = 12;
            this.btnLoginMenu.Text = "Log In";
            this.btnLoginMenu.UseVisualStyleBackColor = true;
            this.btnLoginMenu.Click += new System.EventHandler(this.btnLoginMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(533, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(14, 13);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(559, 370);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoginMenu);
            this.Controls.Add(this.pict);
            this.Controls.Add(this.cbmasuk);
            this.Controls.Add(this.help);
            this.Controls.Add(this.lblMasuk);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblAplikasi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAplikasi;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblMasuk;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.CheckBox cbmasuk;
        private System.Windows.Forms.PictureBox pict;
        private System.Windows.Forms.Button btnLoginMenu;
        private System.Windows.Forms.Label btnExit;

    }
}