using System;
using System.Windows.Forms;

namespace PP7644.Boundary.Manajer_Operasional.KelolaKelas
{
    public partial class FormOperasi : Form
    {
        public FormOperasi()
        {
            InitializeComponent();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Hide();
            var fm = new FormKelolaKelas();
            fm.ShowDialog();
            //fm.setTextLabel("Pengguna: Manajer Operasional -" + .Text);
            Close();
        }
    }
}