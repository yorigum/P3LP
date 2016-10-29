﻿using System;
using System.Windows.Forms;
using PP7644.Control;
using PP7644.Entity;

namespace PP7644.Boundary.Kasir.Kelola_Member
{
    public partial class UC_AddMember : UserControl
    {
        private int flagcommand;

        private MemberControl MC = new MemberControl();

        public UC_AddMember()
        {
            InitializeComponent();
        }

        public void setFlag(int flag)
        {
            flagcommand = flag;
        }

        private void UC_AddMember_Load(object sender, EventArgs e)
        {
        }

        private bool cekInput()
        {
            var temp = true;

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
                dateLahir.Focus();
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
            if (flagcommand == 1) //tambah data
            {
                if (cekInput())
                {
                   // var isiID=getID();
                    //var gender = getvalGender();
                    errorProvider1.Clear();
                   // var KM = new KelolaMember(txtNama.Text, gender.ToString, isiID.Text,txtAlamat.Text, txtTelepon.Text, txtIDno.Text, String.Format("{0:MM/dd/yyyy}", dateLahir.Text));
                    
                    this.Hide();
                    var myParent = (FormKelolaMember) Parent;
                    myParent.Enable();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearInput();
            errorProvider1.Clear();
            this.Hide();
            var myParent = (FormKelolaMember)ParentForm;
            myParent.Enable();
           // setEnableParent();
 
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

        /*public void getID()
        {
            string regist = System.DateTime.Today.ToString("dd/MM/yyyy");
            string ttl_temp = dateLahir.Value.ToString("dd/MM/yyyy");

            string yearregist = regist.Substring(8);
            string monthregist = regist.Substring(3, 2);

            string dateLahir = ttl_temp.Substring(0, 2);
            string blnLahir = ttl_temp.Substring(3, 2);
            string thnLahir = ttl_temp.Substring(6);

            int sort = MC.getCountMember() + 1;
            string tempSort = sort.ToString();

            lblIDMember.Text = monthregist + yearregist;
        }*/
    }
}