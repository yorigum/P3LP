using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Entity;

namespace PP7644.Boundary.Manajer_Operasional.KelolaPegawai
{
    public partial class FormKelolaPegawai2 : Form
    {
        private readonly PegawaiControl PC = new PegawaiControl();
        public FormKelolaPegawai2()
        {
            InitializeComponent();
        }

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = PC.showPegawai();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Jenis Kelamin";
            DG.Columns[4].HeaderText = "Alamat";
            DG.Columns[5].HeaderText = "No.Handphone";
            DG.Columns[6].HeaderText = "No.Identitas";
            DG.Columns[7].HeaderText = "Jabatan";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchPegawai(keyword);

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Jenis Kelamin";
            DG.Columns[4].HeaderText = "Alamat";
            DG.Columns[5].HeaderText = "No.Handphone";
            DG.Columns[6].HeaderText = "No.Identitas";
            DG.Columns[7].HeaderText = "Jabatan";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormKelolaPegawai2_Load(object sender, EventArgs e)
        {
            setDataGridView(dataGridView1);
            ucPegawai1.Visible = false;
        }

        public void setTextLabel(string text)
        {
            lblUserLogin.Text = "Pengguna: Manajer Operasional - " + UppercaseFirst(LoginForm.user);
        }

        private static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            var a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        
        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            var lf = new LoginForm();
            lf.ShowDialog();
            Close();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            Hide();
            var fm = new FormMO();
            fm.ShowDialog();
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tvNama.Text = getKolom(dataGridView1, 1);
            tvtglLahir.Text = getKolom(dataGridView1, 2);
            tvGender.Text = getKolom(dataGridView1, 3);
            tvAlamat.Text = getKolom(dataGridView1, 4);
            tvNoTLP.Text = getKolom(dataGridView1, 5);
            tvNoID.Text = getKolom(dataGridView1, 6);
            txtID.Text = getKolom(dataGridView1, 0);
        }
        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchDataGridView(dataGridView1, txtSearch.Text);
        }

        private void disable()
        {
            txtSearch.Enabled = false;
            dataGridView1.Enabled = false;
            btnBatal.Enabled = false;
            btnEdit.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = false;
            btnSelesai.Enabled = false;
        }

        public void enable()
        {
            txtSearch.Enabled = true;
            dataGridView1.Enabled = true;
            btnBatal.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnTambah.Enabled = true;
            btnSelesai.Enabled = true;
            setDataGridView(dataGridView1);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            ucPegawai1.setflag(1);
            ucPegawai1.Visible = true;
            disable();
        }

        private void btnSelesai_Click_1(object sender, EventArgs e)
        {
            Hide();
            var fm = new LoginForm();
            fm.ShowDialog();
            Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Hide();
            var fm = new FormMO();
            fm.ShowDialog();
            Close();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Silahkan pilih data yang hendak dihapus.");
                dataGridView1.Focus();
            }
            else
            {
                var dr = MessageBox.Show("Apakah Anda yakin ingin menghapus data " + getKolom(dataGridView1, 1),
                    "Pertanyaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    PC.deletePegawai(int.Parse(txtID.Text));
                }
                this.enable();

            }
        }


    }

}
