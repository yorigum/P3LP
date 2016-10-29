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

namespace PP7644.Boundary.Kasir.PresensiMember
{
    public partial class PresensiMember : Form
    {
        public PresensiMember()
        {
            InitializeComponent();
        }

        PresensiMemberControl PC = new PresensiMemberControl();

        public void setDataGridView(DataGridView DG)
        {
            DG.DataSource = PC.getPresInfo();
            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Status";
            DG.Columns[3].HeaderText = "Kelas Senam";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void PresensiMember_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
        }

        private void tvNama_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
            var fk = new FormKasir();
            fk.setTextLabel("Pengguna: Kasir -" + lblUserLogin.Text);
            fk.ShowDialog();
            Close();
        }
    }
}
