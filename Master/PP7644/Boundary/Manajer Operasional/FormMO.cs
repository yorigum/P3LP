using System;
using System.Windows.Forms;

namespace PP7644.Boundary
{
    public partial class FormMO : Form
    {
        public FormMO()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            var lf = new LoginForm();
            lf.ShowDialog();
            Close();
        }

        private void btnKelolaPegawai_Click(object sender, EventArgs e)
        {
            Hide();
            var kp = new FormKelolaPegawai();
            kp.ShowDialog();
            Close();
        }

        private void btnPengelolaanKelas_Click(object sender, EventArgs e)
        {
            Hide();
            var kk = new FormKelolaKelas();
            kk.ShowDialog();
            Close();
        }
    }
}