using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Control;
using PP7644.Entity;

namespace PP7644.Boundary
{
    public partial class FormKelolaKelas : Form
    {
        public FormKelolaKelas()
        {
            InitializeComponent();
        }

        KelasControl KC = new KelasControl();
        LoginForm lf=new LoginForm();

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = KC.showKelas();
            DG.Columns[0].HeaderText = "ID Kelas";
            DG.Columns[1].HeaderText = "Nama Kelas";
            DG.Columns[2].HeaderText = "Tarif(/jam)";
            DG.Columns[3].HeaderText = "Instruktur Kelas";

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = KC.showKelas();
            DG.Columns[0].HeaderText = "ID Kelas";
            DG.Columns[1].HeaderText = "Nama Kelas";
            DG.Columns[2].HeaderText = "Tarif(/jam)";
            DG.Columns[3].HeaderText = "Instruktur Kelas";

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

            setDataGridView(dataGridView1);
            setTextLabel(LoginForm.user);

        }

        public void setTextLabel(string text)
        {
            this.lblUserLogin.Text = "Pengguna: Manajer Operasional - " + UppercaseFirst(LoginForm.user);
        }
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
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
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMO fm = new FormMO();
            fm.ShowDialog();
            this.Close();
        }

        
    }
}
