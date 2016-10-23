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

namespace PP7644.Boundary
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        MenuAdminControl MAC = new MenuAdminControl();

        public void setDatagridview(DataGridView DG)
        {
            DG.DataSource = MAC.showPengguna();
        }

        public void setTextLabel(string text)
        {
            this.lblUserLogin.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            setDatagridview(this.dataGridView1);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
