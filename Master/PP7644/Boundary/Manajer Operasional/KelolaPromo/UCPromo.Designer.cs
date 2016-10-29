namespace PP7644.Boundary.Manajer_Operasional.KelolaPromo
{
    partial class UCPromo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblIDPromo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAplikasi = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDPromo
            // 
            this.lblIDPromo.AutoSize = true;
            this.lblIDPromo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPromo.Location = new System.Drawing.Point(107, 79);
            this.lblIDPromo.Name = "lblIDPromo";
            this.lblIDPromo.Size = new System.Drawing.Size(19, 13);
            this.lblIDPromo.TabIndex = 51;
            this.lblIDPromo.Text = "00";
            this.lblIDPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "ID Promo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtJenis
            // 
            this.txtJenis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJenis.Location = new System.Drawing.Point(110, 139);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(238, 13);
            this.txtJenis.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Jenis Promo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(254, 227);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(94, 24);
            this.btnBatal.TabIndex = 47;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(110, 227);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(94, 24);
            this.btnSimpan.TabIndex = 46;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHarga.Location = new System.Drawing.Point(110, 168);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(238, 13);
            this.txtHarga.TabIndex = 38;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Location = new System.Drawing.Point(110, 108);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(238, 13);
            this.txtNama.TabIndex = 37;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(18, 168);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(38, 13);
            this.lblpass.TabIndex = 36;
            this.lblpass.Text = "Harga";
            this.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(18, 108);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 13);
            this.lblUser.TabIndex = 35;
            this.lblUser.Text = "Nama Promo";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAplikasi
            // 
            this.lblAplikasi.AutoSize = true;
            this.lblAplikasi.Font = new System.Drawing.Font("Bebas", 24F, System.Drawing.FontStyle.Bold);
            this.lblAplikasi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAplikasi.Location = new System.Drawing.Point(116, 17);
            this.lblAplikasi.Name = "lblAplikasi";
            this.lblAplikasi.Size = new System.Drawing.Size(140, 43);
            this.lblAplikasi.TabIndex = 34;
            this.lblAplikasi.Text = "Fit N Fun";
            this.lblAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBonus
            // 
            this.txtBonus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBonus.Location = new System.Drawing.Point(110, 197);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(238, 13);
            this.txtBonus.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Bonus";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UCPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIDPromo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtJenis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblAplikasi);
            this.Name = "UCPromo";
            this.Size = new System.Drawing.Size(367, 435);
            this.Load += new System.EventHandler(this.UCPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDPromo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblAplikasi;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label2;
    }
}
