using System;
using System.Drawing;
using System.Windows.Forms;
using PP7644.Control;

namespace PP7644.Boundary
{
    public partial class LoginForm : Form
    {
        public static string user;

        private readonly LoginControl LC = new LoginControl();

        public LoginForm()
        {
            this.MinimumSize = new Size(575,409);
            this.MaximumSize = new Size(575,409);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            InitializeComponent();
        }


        public string setText(string set)
        {
            return user = txtUser.Text;
        }

        private void btnLoginMenu_Click(object sender, EventArgs e)
        {
            if (LC.cekLogin(txtUser.Text, txtPass.Text))
            {
                var role = LC.GetRoleUser(txtUser.Text, txtPass.Text);
                if (role == 1)
                {
                    Hide();
                    user = txtUser.Text;
                    var fr = new FormAdmin();
                    fr.setTextLabel("Pengguna: Admin -" + txtUser.Text);
                    //fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    Close();
                }
                else if (role == 2)
                {
                    Hide();
                    user = txtUser.Text;
                    var fr = new FormMO();
                    fr.setTextLabel("Pengguna: Manajer Operasional -" + txtUser.Text);
                    // fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    Close();
                }
                else if (role == 3)
                {
                    Hide();
                    user = txtUser.Text;
                    var fr = new FormKasir();
                    fr.setTextLabel("Pengguna: Kasir -" + txtUser.Text);
                    //fr.setVisibleMenu(true);
                    fr.ShowDialog();
                    Close();
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
            Hide();
            MessageBox.Show("Terimakasih");
            Close();
        }


        public object setText(TextBox set)
        {
            throw new NotImplementedException();
        }
    }
}