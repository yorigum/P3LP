using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
    class KelolaMember
    {
        string nama, id_member, notelpon, noID, alamat, kelasSenam, gender, status_anggota;

        
        DateTime tglLahir;

        public KelolaMember(string nama,string id_member,string alamat,string notelpon,string noID,string gender,string kelasSenam,string status_anggota,DateTime tglLahir)
        {
            this.nama=nama;
            this.id_member=id_member;
            this.noID = noID;
            this.notelpon = notelpon;
            this.alamat=alamat;
            this.kelasSenam=kelasSenam;
            this.status_anggota=status_anggota;
            this.tglLahir=tglLahir;
        }
         public string Status_anggota
        {
         get { return status_anggota; }
            set { status_anggota = value; }
        }

        public string Alamat
        {
             get { return alamat; }
                set { alamat = value; }
        }

        public string KelasSenam
        {
             get { return kelasSenam; }
            set { kelasSenam = value; }
        }

        public string Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public DateTime TglLahir
        {
            get { return tglLahir; }
            set { tglLahir = value; }
        }

        public string Notelpon
        {
            get { return notelpon; }
            set { notelpon = value; }
        }

        public string NoID
        {
            get { return noID; }
            set { noID = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
       

    }
}
