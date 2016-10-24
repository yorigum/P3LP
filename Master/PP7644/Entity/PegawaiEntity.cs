using System;

namespace PP7644.Entity
{
    internal class PegawaiEntity
    {
        public PegawaiEntity(string nama, string alamat, string gender, string jabatan, string contact,
            DateTime tglLahir)
        {
            Nama = nama;
            Alamat = alamat;
            Gender = gender;
            Jabatan = jabatan;
            Contact = contact;
            TglLahir = tglLahir;
        }

        public string Nama { get; set; }

        public string Alamat { get; set; }

        public string Gender { get; set; }

        public string Jabatan { get; set; }

        public string Contact { get; set; }

        public DateTime TglLahir { get; set; }
    }
}