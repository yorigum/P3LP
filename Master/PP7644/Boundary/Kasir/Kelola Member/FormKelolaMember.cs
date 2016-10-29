using System;
using System.Windows.Forms;
using PP7644.Control;

namespace PP7644.Boundary
{
    public partial class FormKelolaMember : Form
    {
        private readonly MemberControl MC = new MemberControl();

        public FormKelolaMember()
        {
            InitializeComponent();
        }

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = MC.showMember();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Jenis Kelamin";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Status";
            DG.Columns[5].HeaderText = "Kelas Senam";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = MC.showMember();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Jenis Kelamin";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Status";
            DG.Columns[5].HeaderText = "Kelas Senam";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            setDataGridView(dataGridView1);
            uC_AddMember1.Visible = false;
        }

        public void setTextLabel(string text)
        {
            lblUserLogin.Text = "Pengguna: Kasir - " + UppercaseFirst(LoginForm.user);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Hide();
            var lf = new LoginForm();
            lf.ShowDialog();
            Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Hide();
            var fk = new FormKasir();
            fk.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fk.ShowDialog();
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchDataGridView(dataGridView1, txtSearch.Text);
        }

        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
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

        public void Enable()
        {
            txtSearch.Enabled = true;
            dataGridView1.Enabled = true;
            btnBatal.Enabled = true;
            btnEdit.Enabled = true;
            btnHapus.Enabled = true;
            btnTambah.Enabled = true;
            btnSelesai.Enabled = true;

            setDataGridView(dataGridView1);
            dataGridView1.Rows[0].Selected = true;
        }

        private void btnTambah_Click_1(object sender, EventArgs e)
        {
            uC_AddMember1.setFlag(1);
            uC_AddMember1.Visible = true;
            disable();
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
                    MC.deleteMember(txtID.Text);
                }
                this.Enable();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tvNama.Text = getKolom(dataGridView1, 1);
            tvtglLahir.Text = getKolom(dataGridView1, 2);
            tvGender.Text = getKolom(dataGridView1, 3);
            tvAlamat.Text = getKolom(dataGridView1, 4);
            tvNoTLP.Text = getKolom(dataGridView1, 5);
            tvNoID.Text = getKolom(dataGridView1, 6);
            txtID.Text = getKolom(dataGridView1, 0);
        }
    }
}