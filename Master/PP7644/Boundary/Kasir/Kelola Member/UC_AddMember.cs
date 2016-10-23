using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Control;

namespace PP7644.Boundary.Kasir.Kelola_Member
{
    public partial class UC_AddMember : UserControl
    {
        public UC_AddMember()
        {
            InitializeComponent();
        }

        MemberControl MC = new MemberControl();

        int flagcommand = 0;
        public void setFlag(int flag)
        {
            flagcommand = flag;
        }

        private void UC_AddMember_Load(object sender, EventArgs e)
        {
          

        }

        private bool cekInput()
        {
            bool temp = true;

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtIDno, "Silahkan isi bidang nama");
                txtIDno.Focus();
                temp = false;
            }

            if (txtAlamat.Text == "")
            {
                errorProvider1.SetError(txtAlamat, "Silahkan isi bidang Alamat");
                txtAlamat.Focus();
                temp = false;
            }

            if (txtIDno.Text == "")
            {
                errorProvider1.SetError(txtAlamat, "Silahkan isi NomorIdentitas");
                txtIDno.Focus();
                temp = false;
            }

            if (txtTelepon.Text == "")
            {
                errorProvider1.SetError(txtTelepon, "Silahkan isi Nomor Telepon");
                txtIDno.Focus();
                temp = false;
            }

            if (radioMale.Text == "")
            {
                errorProvider1.SetError(radioMale, "Silahkan pilih jenis kelamin");
                radioMale.Focus();
                temp = false;
            }

            if (radioFemale.Text == "")
            {
                errorProvider1.SetError(radioMale, "Silahkan pilih jenis kelamin");
                radioMale.Focus();
                temp = false;
            }
            if (dateLahir.Text == "")
            {
                errorProvider1.SetError(dateLahir, "Silahkan pilih tanggal lahir.");
                radioMale.Focus();
                temp = false;
                
            }

            return temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearInput()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtIDno.Clear();
            txtTelepon.Clear();
            dateLahir.ResetText();
            radioFemale.Checked = false;
            radioMale.Checked = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (flagcommand == 1)//tambah data
            {
                if (cekInput() == true)
                {
                    errorProvider1.Clear();
                  //  PP7644.Entity.KelolaMember KM = new Entity.KelolaMember(txtNama.Text, lblIDMember.Text, txtAlamat.Text, txtTelepon.Text, txtIDno.Text,"","","",dateLahir.Value.ToShortDateString());
                    this.Hide();
                    FormKelolaMember myParent = (FormKelolaMember)this.Parent;
                    myParent.Enable();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearInput();
            //errorProvider1.Clear();
            this.Hide();
            FormKelolaMember myParent = (FormKelolaMember)this.Parent;
            myParent.Enable();
        }
    }
}
