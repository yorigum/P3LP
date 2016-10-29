using System;
using System.Windows.Forms;
using PP7644.Boundary.Kasir;
using PP7644.Boundary.Kasir.PresensiMember;
using PP7644.Boundary.Kasir.Presensi_Instruktur;

namespace PP7644.Boundary
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void pengelolaanDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
        }

        public void setTextLabel(string text)
        {
            lblUserLogin.Text = text;
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

        private void btnKelolaMember_Click(object sender, EventArgs e)
        {
            Hide();
            var fkl = new FormKelolaMember();
            fkl.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fkl.ShowDialog();
            Close();
        }

        private void btnPresensiMember_Click(object sender, EventArgs e)
        {
            Hide();
            var fkl = new PresensiMember();
            fkl.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fkl.ShowDialog();
            Close();
        }

        private void btnPresensiInstruktur_Click(object sender, EventArgs e)
        {
            Hide();
            var fkl = new PresensiInstruktur();
            fkl.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fkl.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var fkl = new FormKasir();
            fkl.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fkl.ShowDialog();
            Close();
        }


    }
}