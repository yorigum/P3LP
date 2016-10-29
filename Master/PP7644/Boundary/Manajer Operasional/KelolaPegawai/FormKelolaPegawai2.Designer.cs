namespace PP7644.Boundary.Manajer_Operasional.KelolaPegawai
{
    partial class FormKelolaPegawai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbPegawai = new System.Windows.Forms.GroupBox();
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
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ucPegawai1 = new PP7644.Boundary.Manajer_Operasional.KelolaPegawai.UCPegawai();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPegawai.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.CausesValidation = false;
            this.panel1.Controls.Add(this.lblUserLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 104);
            this.panel1.TabIndex = 4;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(907, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(959, 117);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(406, 117);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(536, 20);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(406, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 319);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            this.gbPegawai.Location = new System.Drawing.Point(12, 117);
            this.gbPegawai.Name = "gbPegawai";
            this.gbPegawai.Size = new System.Drawing.Size(375, 383);
            this.gbPegawai.TabIndex = 8;
            this.gbPegawai.TabStop = false;
            this.gbPegawai.Text = "Pegawai";
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
            this.label5.Size = new System.Drawing.Size(70, 13);
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
            this.label2.Size = new System.Drawing.Size(77, 13);
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
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(808, 483);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(94, 23);
            this.btnSelesai.TabIndex = 24;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click_1);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(678, 483);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 23);
            this.btnBatal.TabIndex = 23;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(588, 483);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(94, 23);
            this.btnHapus.TabIndex = 22;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(497, 483);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(407, 483);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(94, 23);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            // ucPegawai1
            // 
            this.ucPegawai1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ucPegawai1.Location = new System.Drawing.Point(338, 26);
            this.ucPegawai1.Name = "ucPegawai1";
            this.ucPegawai1.Size = new System.Drawing.Size(367, 435);
            this.ucPegawai1.TabIndex = 25;
            // 
            // FormKelolaPegawai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 525);
            this.Controls.Add(this.ucPegawai1);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbPegawai);
            this.MaximumSize = new System.Drawing.Size(1081, 564);
            this.MinimumSize = new System.Drawing.Size(1081, 564);
            this.Name = "FormKelolaPegawai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKelolaPegawai2";
            this.Load += new System.EventHandler(this.FormKelolaPegawai2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPegawai.ResumeLayout(false);
            this.gbPegawai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPegawai;
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
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private UCPegawai ucPegawai1;
        private System.Windows.Forms.TextBox txtID;
    }
}