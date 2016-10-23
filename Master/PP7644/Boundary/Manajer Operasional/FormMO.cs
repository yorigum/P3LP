using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Close();
        }

        private void btnKelolaPegawai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelolaPegawai kp = new FormKelolaPegawai();
            kp.ShowDialog();
            this.Close();
        }

        private void btnPengelolaanKelas_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKelolaKelas kk = new FormKelolaKelas();
            kk.ShowDialog();
            this.Close();
        }
    }
}
