using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PP7644.Entity;

namespace PP7644.Boundary.Manajer_Operasional.KelolaPegawai
{
    public partial class UCPegawai : UserControl
    {
        public UCPegawai()
        {
            InitializeComponent();
        }

        static int flagCommand = 0;

        public void setflag(int flag)
        {
            flagCommand = flag;
        }

        PegawaiControl PC=new PegawaiControl();

        private void UCPegawai_Load(object sender, EventArgs e)
        {
            cbJabatan.DataSource = PC.getJabatan();
            cbJabatan.DisplayMember = "nama_jabatan";
        }

        private bool cekInput()
        {
            var temp = true;

            if (txtNama.Text == "")
            {
                errorProvider1.SetError(txtNama, "Silahkan isi bidang nama");
                txtNama.Focus();
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
                dateLahir.Focus();
                temp = false;
            }
            return temp;
        }

        private void clearInput()
        {
            txtNama.Clear();
            txtAlamat.Clear();
            txtIDno.Clear();
            txtTelepon.Clear();
            dateLahir.ResetText();
            cbJabatan.SelectedIndex = -1;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (flagCommand == 1) //tambah data
            {
                if (cekInput())
                {
                    errorProvider1.Clear();
                    int IDjabatan = PC.getJabatan(cbJabatan.Text);
                    var P = new Entity.PegawaiEntity(txtNama.Text,String.Format("{0:MM/dd/yyyy}",dateLahir.Text), cbJabatan.Text,txtAlamat.Text,txtTelepon.Text,txtIDno.Text,IDjabatan );
                    PC.addPegawai(P);
                    this.Hide();
                    var myParent = (FormKelolaPegawai2)Parent;
                    myParent.enable();
                }
                /*else
                {
                    errorProvider1.Clear();
                    int IDjabatan = PC.getJabatan(cbJabatan.Text);
                    //var P = new Entity.PegawaiEntity(txtNama.Text, txtAlamat.Text, getvalGender(Text), txtAlamat.Text,
                        //txtTelepon.Text, cbJabatan.Text, txtIDno.Text, String.Format("{0:YY-MM-DD/}", dateLahir));
                    var P=new Entity.PegawaiEntity(txtNama.Text,String.Format("{0:DD/MM/YYYY}",dateLahir),getvalGender(Text),txtAlamat.Text,txtTelepon.Text,cbJabatan.Text,txtIDno.Text, );
                    this.Hide();
                    var myParent = (FormKelolaMember)Parent;
                    myParent.Enable();
                }*/
            }
        }
        public string getvalGender(string text)
        {
            string gender = null;

            if (radioMale.Checked)
            {
                gender = "Laki-laki";
            }
            else if (radioFemale.Checked)
            {
                gender = "Perempuan";
            }

            return gender;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearInput();
            errorProvider1.Clear();
            this.Hide();
            var myParent = (FormKelolaPegawai2)ParentForm;
            myParent.enable();
        }


    }
}
