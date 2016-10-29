using System;
using System.Runtime.CompilerServices;

namespace PP7644.Entity
{
    internal class PegawaiEntity
    {
        string nama, alamat, gender, jabatan, contact, noIdentitas,tglLahir;
        int idJabatan;

        public PegawaiEntity(string nama, string tglLahir, string gender, string alamat, string contact, string noIdentitas, int idJabatan)
        {
            Nama = nama;
            Alamat = alamat;
            Gender = gender;
            Contact = contact;
            NoIdentitas = noIdentitas;
            TglLahir = tglLahir;
            IDJabatan = idJabatan;
        }

        public string Nama { get; set; }

        public string Alamat { get; set; }

        public string Gender { get; set; }

        public string Contact { get; set; }
        
        public int IDJabatan { get; set; }

        public string TglLahir { get; set; }

        public string NoIdentitas { get; set; }
    }
}