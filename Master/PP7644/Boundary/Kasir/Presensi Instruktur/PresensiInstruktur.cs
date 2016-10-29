using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP7644.Boundary.Kasir.Presensi_Instruktur
{
    public partial class PresensiInstruktur : Form
    {
        public PresensiInstruktur()
        {
            InitializeComponent();
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
