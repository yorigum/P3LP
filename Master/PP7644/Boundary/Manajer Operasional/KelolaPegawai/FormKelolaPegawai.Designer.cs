namespace PP7644.Boundary
{
    partial class FormKelolaPegawai
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
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.gbPegawai = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tvNama = new System.Windows.Forms.Label();
            this.tvNoID = new System.Windows.Forms.Label();
            this.tvtglLahir = new System.Windows.Forms.Label();
            this.tvGender = new System.Windows.Forms.Label();
            this.tvNoTLP = new System.Windows.Forms.Label();
            this.tvAlamat = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbPegawai.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblUserLogin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 570);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.panel2.Controls.Add(this.btnSelesai);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.btnBatal);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Controls.Add(this.gbPegawai);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 471);
            this.panel2.TabIndex = 0;
            // 
            // btnSelesai
            // 
            this.btnSelesai.Location = new System.Drawing.Point(811, 404);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(94, 23);
            this.btnSelesai.TabIndex = 13;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = true;
            this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(964, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(681, 404);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 23);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(411, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(536, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(591, 404);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(94, 23);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(500, 404);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(411, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 319);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(410, 404);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(94, 23);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // gbPegawai
            // 
            this.gbPegawai.BackColor = System.Drawing.Color.Transparent;
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
            this.gbPegawai.Controls.Add(this.txtNama);
            this.gbPegawai.Controls.Add(this.lblpass);
            this.gbPegawai.Controls.Add(this.lblUser);
            this.gbPegawai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gbPegawai.Location = new System.Drawing.Point(15, 44);
            this.gbPegawai.Name = "gbPegawai";
            this.gbPegawai.Size = new System.Drawing.Size(375, 383);
            this.gbPegawai.TabIndex = 4;
            this.gbPegawai.TabStop = false;
            this.gbPegawai.Text = "Pegawai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
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
            this.label2.Location = new System.Drawing.Point(12, 144);
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
            this.label3.Location = new System.Drawing.Point(12, 112);
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
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(12, 80);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "No. Telepon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvNama
            // 
            this.tvNama.AutoSize = true;
            this.tvNama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNama.Location = new System.Drawing.Point(114, 49);
            this.tvNama.Name = "tvNama";
            this.tvNama.Size = new System.Drawing.Size(43, 17);
            this.tvNama.TabIndex = 14;
            this.tvNama.Text = "label6";
            // 
            // tvNoID
            // 
            this.tvNoID.AutoSize = true;
            this.tvNoID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNoID.Location = new System.Drawing.Point(114, 77);
            this.tvNoID.Name = "tvNoID";
            this.tvNoID.Size = new System.Drawing.Size(43, 17);
            this.tvNoID.TabIndex = 15;
            this.tvNoID.Text = "label6";
            // 
            // tvtglLahir
            // 
            this.tvtglLahir.AutoSize = true;
            this.tvtglLahir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvtglLahir.Location = new System.Drawing.Point(114, 144);
            this.tvtglLahir.Name = "tvtglLahir";
            this.tvtglLahir.Size = new System.Drawing.Size(43, 17);
            this.tvtglLahir.TabIndex = 17;
            this.tvtglLahir.Text = "label6";
            // 
            // tvGender
            // 
            this.tvGender.AutoSize = true;
            this.tvGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvGender.Location = new System.Drawing.Point(114, 112);
            this.tvGender.Name = "tvGender";
            this.tvGender.Size = new System.Drawing.Size(43, 17);
            this.tvGender.TabIndex = 16;
            this.tvGender.Text = "label6";
            // 
            // tvNoTLP
            // 
            this.tvNoTLP.AutoSize = true;
            this.tvNoTLP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNoTLP.Location = new System.Drawing.Point(114, 172);
            this.tvNoTLP.Name = "tvNoTLP";
            this.tvNoTLP.Size = new System.Drawing.Size(43, 17);
            this.tvNoTLP.TabIndex = 18;
            this.tvNoTLP.Text = "label6";
            // 
            // tvAlamat
            // 
            this.tvAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAlamat.Location = new System.Drawing.Point(117, 197);
            this.tvAlamat.Name = "tvAlamat";
            this.tvAlamat.Size = new System.Drawing.Size(178, 96);
            this.tvAlamat.TabIndex = 19;
            this.tvAlamat.Text = "";
            // 
            // FormKelolaPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 572);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "FormKelolaPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbPegawai.ResumeLayout(false);
            this.gbPegawai.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbPegawai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.RichTextBox tvAlamat;
        private System.Windows.Forms.Label tvNoTLP;
        private System.Windows.Forms.Label tvtglLahir;
        private System.Windows.Forms.Label tvGender;
        private System.Windows.Forms.Label tvNoID;
        private System.Windows.Forms.Label tvNama;
        private System.Windows.Forms.Label label5;

    }
}