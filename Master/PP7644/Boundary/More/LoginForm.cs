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
using PP7644.Boundary;

namespace PP7644.Boundary
{
    public partial class LoginForm : Form
    {

        public static string user;
        public LoginForm()
        {
            InitializeComponent();
        }

        LoginControl LC = new LoginControl();
        

        public string setText(string set)
        {
            return user = txtUser.Text;
        }

        private void btnLoginMenu_Click(object sender, EventArgs e)
        {
          if (LC.cekLogin(txtUser.Text, txtPass.Text) == true)
            {
                int role = LC.GetRoleUser(txtUser.Text, txtPass.Text);
                if (role == 1)
                {
                    this.Hide();
                    user = txtUser.Text;
                    FormAdmin fr = new FormAdmin();
                    fr.setTextLabel("Pengguna: Admin -"+txtUser.Text);
                    //fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    this.Close();
                     }
                else if (role == 2)
                {
                    this.Hide();
                    user = txtUser.Text;
                    FormMO fr = new FormMO();
                    fr.setTextLabel("Pengguna: Manajer Operasional -" + txtUser.Text);
                   // fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else if (role == 3)
                {
                    this.Hide();
                    user = txtUser.Text;
                    FormKasir fr = new FormKasir();
                    fr.setTextLabel("Pengguna: Kasir -" + txtUser.Text);
                    //fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tidak memiliki Role");
                }
            }
            else 
            {
                MessageBox.Show("Username atau Password Salah!");
            }
        }
               


        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hubungi Kami: ");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Terimakasih");
            this.Close();
        }


        public object setText(TextBox set)
        {
            throw new NotImplementedException();
        }
    }
}
