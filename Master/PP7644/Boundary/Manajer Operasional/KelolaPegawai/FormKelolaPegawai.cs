using System;
using System.Windows.Forms;
using PP7644.Entity;

namespace PP7644.Boundary
{
    public partial class FormKelolaPegawai : Form
    {
        private readonly PegawaiControl PC = new PegawaiControl();

        public FormKelolaPegawai()
        {
            InitializeComponent();
        }

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = PC.showPegawai();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Jenis Kelamin";
            DG.Columns[5].HeaderText = "Telepon";
            DG.Columns[6].HeaderText = "Jabatan";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoGenerateColumns = false;
        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.searchPegawai(keyword);
            DG.DataSource = PC.showPegawai();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Jenis Kelamin";
            DG.Columns[5].HeaderText = "Telepon";
            DG.Columns[6].HeaderText = "Jabatan";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            setDataGridView(dataGridView1);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
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
            tvNoID.Text = getKolom(dataGridView1, 0);
            tvNama.Text = getKolom(dataGridView1, 1);
        }
        private string getKolom(DataGridView dg, int i)
        {
            return dg[dg.Columns[i].Index, dg.CurrentRow.Index].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchDataGridView(dataGridView1,txtSearch.Text);
            if (txtSearch.Text == "")
            {
                setDataGridView(dataGridView1);
            }
        }
    }
}