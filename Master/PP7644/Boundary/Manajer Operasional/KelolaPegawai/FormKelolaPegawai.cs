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
    public partial class FormKelolaPegawai : Form
    {
        public FormKelolaPegawai()
        {
            InitializeComponent();
        }

        PegawaiControl PC=new PegawaiControl();

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

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void searchDataGridView(DataGridView DG, string keyword)
        {
            DG.DataSource = PC.showPegawai();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Jenis Kelamin";
            DG.Columns[5].HeaderText = "Telepon";
            DG.Columns[6].HeaderText = "Jabatan";

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

            setDataGridView(dataGridView1);

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

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMO fm = new FormMO();
            fm.ShowDialog();
            this.Close();
        }
    }
}
