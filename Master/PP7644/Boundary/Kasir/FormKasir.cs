using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Boundary;

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
            this.lblUserLogin.Text = text;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void btnKelolaMember_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelolaMember fkl = new FormKelolaMember();
            fkl.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fkl.ShowDialog();
            this.Close();
        }
    }
}
