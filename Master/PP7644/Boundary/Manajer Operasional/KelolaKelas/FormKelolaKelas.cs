using System;
using System.Windows.Forms;
using PP7644.Boundary.Manajer_Operasional.KelolaKelas;
using PP7644.Control;

namespace PP7644.Boundary
{
    public partial class FormKelolaKelas : Form
    {
        private readonly KelasControl KC = new KelasControl();
        private LoginForm lf = new LoginForm();

        public FormKelolaKelas()
        {
            InitializeComponent();
        }

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = KC.showKelas();
            DG.Columns[0].HeaderText = "ID Kelas";
            DG.Columns[1].HeaderText = "Nama Kelas";
            DG.Columns[2].HeaderText = "Tarif(/jam)";
            DG.Columns[3].HeaderText = "Instruktur Kelas";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = KC.showKelas();
            DG.Columns[0].HeaderText = "ID Kelas";
            DG.Columns[1].HeaderText = "Nama Kelas";
            DG.Columns[2].HeaderText = "Tarif(/jam)";
            DG.Columns[3].HeaderText = "Instruktur Kelas";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            setDataGridView(dataGridView1);
            setTextLabel(LoginForm.user);
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Hide();
            var fm = new FormOperasi();
            fm.ShowDialog();
            Close();
        }
    }
}