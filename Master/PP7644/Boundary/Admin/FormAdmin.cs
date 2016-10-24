using System;
using System.Windows.Forms;
using PP7644.Control;

namespace PP7644.Boundary
{
    public partial class FormAdmin : Form
    {
        private readonly MenuAdminControl MAC = new MenuAdminControl();

        public FormAdmin()
        {
            InitializeComponent();
        }

        public void setDatagridview(DataGridView DG)
        {
            DG.DataSource = MAC.showPengguna();
        }

        public void setTextLabel(string text)
        {
            lblUserLogin.Text = "Pengguna: Admin - " + UppercaseFirst(LoginForm.user);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var lf = new LoginForm();
            lf.Show();
            Close();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            setDatagridview(dataGridView1);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}