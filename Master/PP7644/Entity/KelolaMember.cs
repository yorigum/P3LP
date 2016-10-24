using System;

namespace PP7644.Entity
{
    internal class KelolaMember
    {
        //txtNama.Text, lblIDMember.Text, txtAlamat.Text, txtTelepon.Text, txtIDno.Text,"","","",dateLahir.Value.ToShortDateString()
        private string nama;
        private string idMember;
        private string alamat;
        private string telepon;
        private string noidentitas;
        private DateTime datelahir;
        
        public KelolaMember(string nama, string idMember , string alamat, string telepon, string noidentitas, DateTime dateLahir)
        {
            // TODO: Complete member initialization
            this.nama = nama;
            this.alamat = alamat;
            this.telepon = telepon;
            this.noidentitas = noidentitas;
            this.datelahir = dateLahir;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string IdMember
        {
            get { return idMember; }
            set { idMember = value; }
        }

        public string Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public string Telepon
        {
            get { return telepon; }
            set { telepon = value; }
        }

        public string Noidentitas
        {
            get { return noidentitas; }
            set { noidentitas = value; }
        }

        public DateTime Datelahir
        {
            get { return datelahir; }
            set { datelahir = value; }
        }
    }
}