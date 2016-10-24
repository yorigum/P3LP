namespace PP7644.Boundary
{
    partial class FormKelolaMember
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegist = new System.Windows.Forms.TabPage();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbMember = new System.Windows.Forms.GroupBox();
            this.txtAlamat = new System.Windows.Forms.RichTextBox();
            this.dateLahir = new System.Windows.Forms.DateTimePicker();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabAktivasi = new System.Windows.Forms.TabPage();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.uC_AddMember1 = new PP7644.Boundary.Kasir.Kelola_Member.UC_AddMember();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRegist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(392, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 85);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fit N Fun";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(907, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lblExit);
            this.panel1.Controls.Add(this.lblUserLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 570);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblExit.Location = new System.Drawing.Point(1039, 8);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(15, 13);
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.Location = new System.Drawing.Point(918, 72);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(35, 13);
            this.lblUserLogin.TabIndex = 3;
            this.lblUserLogin.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 453);
            this.panel2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegist);
            this.tabControl1.Controls.Add(this.tabAktivasi);
            this.tabControl1.Controls.Add(this.tabDeposit);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRegist
            // 
            this.tabRegist.Controls.Add(this.uC_AddMember1);
            this.tabRegist.Controls.Add(this.btnSelesai);
            this.tabRegist.Controls.Add(this.btnBatal);
            this.tabRegist.Controls.Add(this.btnHapus);
            this.tabRegist.Controls.Add(this.btnEdit);
            this.tabRegist.Controls.Add(this.btnTambah);
            this.tabRegist.Controls.Add(this.btnSearch);
            this.tabRegist.Controls.Add(this.txtSearch);
            this.tabRegist.Controls.Add(this.dataGridView1);
            this.tabRegist.Controls.Add(this.gbMember);
            this.tabRegist.Location = new System.Drawing.Point(4, 22);
            this.tabRegist.Name = "tabRegist";
            this.tabRegist.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegist.Size = new System.Drawing.Size(1057, 427);
            this.tabRegist.TabIndex = 0;
            this.tabRegist.Text = "Registrasi Member";
            this.tabRegist.UseVisualStyleBackColor = true;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(803, 383);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(94, 23);
            this.btnSelesai.TabIndex = 8;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(673, 383);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 23);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(583, 383);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(94, 23);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(492, 383);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(402, 383);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(94, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(956, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(403, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(536, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // gbMember
            // 
            this.gbMember.BackColor = System.Drawing.Color.Transparent;
            this.gbMember.Controls.Add(this.txtAlamat);
            this.gbMember.Controls.Add(this.dateLahir);
            this.gbMember.Controls.Add(this.radioFemale);
            this.gbMember.Controls.Add(this.radioMale);
            this.gbMember.Controls.Add(this.label4);
            this.gbMember.Controls.Add(this.label2);
            this.gbMember.Controls.Add(this.label3);
            this.gbMember.Controls.Add(this.txtNama);
            this.gbMember.Controls.Add(this.txtUser);
            this.gbMember.Controls.Add(this.lblpass);
            this.gbMember.Controls.Add(this.lblUser);
            this.gbMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbMember.Location = new System.Drawing.Point(7, 23);
            this.gbMember.Name = "gbMember";
            this.gbMember.Size = new System.Drawing.Size(375, 383);
            this.gbMember.TabIndex = 0;
            this.gbMember.TabStop = false;
            this.gbMember.Text = "Member";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(104, 173);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(238, 183);
            this.txtAlamat.TabIndex = 16;
            this.txtAlamat.Text = "";
            // 
            // dateLahir
            // 
            this.dateLahir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.dateLahir.Location = new System.Drawing.Point(104, 143);
            this.dateLahir.Name = "dateLahir";
            this.dateLahir.Size = new System.Drawing.Size(238, 22);
            this.dateLahir.TabIndex = 15;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioFemale.Location = new System.Drawing.Point(178, 111);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(85, 17);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Perempuan";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioMale.Location = new System.Drawing.Point(104, 111);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(68, 17);
            this.radioMale.TabIndex = 13;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Laki-laki";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alamat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tanggal Lahir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jenis Kelamin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Location = new System.Drawing.Point(104, 81);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(238, 22);
            this.txtNama.TabIndex = 9;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Location = new System.Drawing.Point(104, 49);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(238, 22);
            this.txtUser.TabIndex = 8;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(12, 81);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(74, 13);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "No. Identitas";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Nama";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabAktivasi
            // 
            this.tabAktivasi.Location = new System.Drawing.Point(4, 22);
            this.tabAktivasi.Name = "tabAktivasi";
            this.tabAktivasi.Padding = new System.Windows.Forms.Padding(3);
            this.tabAktivasi.Size = new System.Drawing.Size(1057, 427);
            this.tabAktivasi.TabIndex = 1;
            this.tabAktivasi.Text = "Aktivasi Member";
            this.tabAktivasi.UseVisualStyleBackColor = true;
            // 
            // tabDeposit
            // 
            this.tabDeposit.Location = new System.Drawing.Point(4, 22);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Size = new System.Drawing.Size(1057, 427);
            this.tabDeposit.TabIndex = 2;
            this.tabDeposit.Text = "Deposit Member";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // uC_AddMember1
            // 
            this.uC_AddMember1.Location = new System.Drawing.Point(307, 23);
            this.uC_AddMember1.Name = "uC_AddMember1";
            this.uC_AddMember1.Size = new System.Drawing.Size(460, 376);
            this.uC_AddMember1.TabIndex = 9;
            // 
            // FormKelolaMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormKelolaMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabRegist.ResumeLayout(false);
            this.tabRegist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbMember.ResumeLayout(false);
            this.gbMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbMember;
        private System.Windows.Forms.TabPage tabAktivasi;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RichTextBox txtAlamat;
        private System.Windows.Forms.DateTimePicker dateLahir;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUser;
        private Kasir.Kelola_Member.UC_AddMember uC_AddMember1;

    }
}