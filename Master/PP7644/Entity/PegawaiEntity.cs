using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
    class PegawaiEntity
    {
        string nama, alamat, gender, jabatan, contact;
        DateTime tglLahir;

        public PegawaiEntity(string nama, string alamat, string gender, string jabatan, string contact,
            DateTime tglLahir)
        {
            this.nama = nama;
            this.alamat = alamat;
            this.gender = gender;
            this.jabatan = jabatan;
            this.contact = contact;
            this.tglLahir = tglLahir;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Jabatan
        {
            get { return jabatan; }
            set { jabatan = value; }
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }

        public DateTime TglLahir
        {
            get { return tglLahir; }
            set { tglLahir = value; }
        }
    }
}