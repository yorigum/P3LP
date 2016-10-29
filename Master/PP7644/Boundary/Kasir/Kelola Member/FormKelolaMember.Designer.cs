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
            this.gbPegawai = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tvAlamat = new System.Windows.Forms.RichTextBox();
            this.tvNoTLP = new System.Windows.Forms.Label();
            this.tvtglLahir = new System.Windows.Forms.Label();
            this.tvGender = new System.Windows.Forms.Label();
            this.tvNoID = new System.Windows.Forms.Label();
            this.tvNama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tabAktivasi = new System.Windows.Forms.TabPage();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.uC_AddMember1 = new PP7644.Boundary.Kasir.Kelola_Member.UC_AddMember();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabRegist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPegawai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(392, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 73);
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
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 100);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegist);
            this.tabControl1.Controls.Add(this.tabAktivasi);
            this.tabControl1.Controls.Add(this.tabDeposit);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(2, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 465);
            this.tabControl1.TabIndex = 5;
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
            this.tabRegist.Controls.Add(this.gbPegawai);
            this.tabRegist.Location = new System.Drawing.Point(4, 22);
            this.tabRegist.Name = "tabRegist";
            this.tabRegist.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegist.Size = new System.Drawing.Size(1065, 439);
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
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
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
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click_1);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 319);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbPegawai
            // 
            this.gbPegawai.BackColor = System.Drawing.Color.Transparent;
            this.gbPegawai.Controls.Add(this.txtID);
            this.gbPegawai.Controls.Add(this.tvAlamat);
            this.gbPegawai.Controls.Add(this.tvNoTLP);
            this.gbPegawai.Controls.Add(this.tvtglLahir);
            this.gbPegawai.Controls.Add(this.tvGender);
            this.gbPegawai.Controls.Add(this.tvNoID);
            this.gbPegawai.Controls.Add(this.tvNama);
            this.gbPegawai.Controls.Add(this.label5);
            this.gbPegawai.Controls.Add(this.label4);
            this.gbPegawai.Controls.Add(this.label2);
            this.gbPegawai.Controls.Add(this.label3);
            this.gbPegawai.Controls.Add(this.lblpass);
            this.gbPegawai.Controls.Add(this.lblUser);
            this.gbPegawai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbPegawai.Location = new System.Drawing.Point(6, 23);
            this.gbPegawai.Name = "gbPegawai";
            this.gbPegawai.Size = new System.Drawing.Size(375, 383);
            this.gbPegawai.TabIndex = 10;
            this.gbPegawai.TabStop = false;
            this.gbPegawai.Text = "Member";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(246, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 22);
            this.txtID.TabIndex = 21;
            // 
            // tvAlamat
            // 
            this.tvAlamat.BackColor = System.Drawing.SystemColors.Control;
            this.tvAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAlamat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tvAlamat.Location = new System.Drawing.Point(117, 221);
            this.tvAlamat.Name = "tvAlamat";
            this.tvAlamat.Size = new System.Drawing.Size(178, 96);
            this.tvAlamat.TabIndex = 19;
            this.tvAlamat.Text = "";
            // 
            // tvNoTLP
            // 
            this.tvNoTLP.AutoSize = true;
            this.tvNoTLP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNoTLP.Location = new System.Drawing.Point(114, 187);
            this.tvNoTLP.Name = "tvNoTLP";
            this.tvNoTLP.Size = new System.Drawing.Size(43, 17);
            this.tvNoTLP.TabIndex = 18;
            this.tvNoTLP.Text = "label6";
            // 
            // tvtglLahir
            // 
            this.tvtglLahir.AutoSize = true;
            this.tvtglLahir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvtglLahir.Location = new System.Drawing.Point(114, 159);
            this.tvtglLahir.Name = "tvtglLahir";
            this.tvtglLahir.Size = new System.Drawing.Size(43, 17);
            this.tvtglLahir.TabIndex = 17;
            this.tvtglLahir.Text = "label6";
            // 
            // tvGender
            // 
            this.tvGender.AutoSize = true;
            this.tvGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvGender.Location = new System.Drawing.Point(114, 127);
            this.tvGender.Name = "tvGender";
            this.tvGender.Size = new System.Drawing.Size(43, 17);
            this.tvGender.TabIndex = 16;
            this.tvGender.Text = "label6";
            // 
            // tvNoID
            // 
            this.tvNoID.AutoSize = true;
            this.tvNoID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNoID.Location = new System.Drawing.Point(114, 92);
            this.tvNoID.Name = "tvNoID";
            this.tvNoID.Size = new System.Drawing.Size(43, 17);
            this.tvNoID.TabIndex = 15;
            this.tvNoID.Text = "label6";
            // 
            // tvNama
            // 
            this.tvNama.AutoSize = true;
            this.tvNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNama.Location = new System.Drawing.Point(114, 64);
            this.tvNama.Name = "tvNama";
            this.tvNama.Size = new System.Drawing.Size(43, 17);
            this.tvNama.TabIndex = 14;
            this.tvNama.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "No. Telepon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 212);
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
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tanggal Lahir";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jenis Kelamin";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(12, 95);
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
            this.lblUser.Location = new System.Drawing.Point(12, 64);
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
            this.tabAktivasi.Size = new System.Drawing.Size(1065, 439);
            this.tabAktivasi.TabIndex = 1;
            this.tabAktivasi.Text = "Aktivasi Member";
            this.tabAktivasi.UseVisualStyleBackColor = true;
            // 
            // tabDeposit
            // 
            this.tabDeposit.Location = new System.Drawing.Point(4, 22);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Size = new System.Drawing.Size(1065, 439);
            this.tabDeposit.TabIndex = 2;
            this.tabDeposit.Text = "Deposit Member";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // uC_AddMember1
            // 
            this.uC_AddMember1.Location = new System.Drawing.Point(297, 3);
            this.uC_AddMember1.Name = "uC_AddMember1";
            this.uC_AddMember1.Size = new System.Drawing.Size(460, 376);
            this.uC_AddMember1.TabIndex = 9;
            // 
            // FormKelolaMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 572);
            this.Controls.Add(this.tabControl1);
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
            this.tabControl1.ResumeLayout(false);
            this.tabRegist.ResumeLayout(false);
            this.tabRegist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPegawai.ResumeLayout(false);
            this.gbPegawai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegist;
        private Kasir.Kelola_Member.UC_AddMember uC_AddMember1;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabAktivasi;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.GroupBox gbPegawai;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox tvAlamat;
        private System.Windows.Forms.Label tvNoTLP;
        private System.Windows.Forms.Label tvtglLahir;
        private System.Windows.Forms.Label tvGender;
        private System.Windows.Forms.Label tvNoID;
        private System.Windows.Forms.Label tvNama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUser;

    }
}