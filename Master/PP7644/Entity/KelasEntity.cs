using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
    class KelasEntity
    {
        string id_kelas, nama_kelas, id_instruktur;
        int tarif_perjam;

        
        public KelasEntity(string id_kelas, string nama_kelas, string id_instruktur, int tarif_perjam)
        {
            this.id_kelas = id_kelas;
            this.nama_kelas = nama_kelas;
            this.id_instruktur = id_instruktur;
            this.tarif_perjam = tarif_perjam;
        }

        public int Tarif_perjam
        {
            get { return tarif_perjam; }
            set { tarif_perjam = value; }
        }

        public string Id_instruktur
        {
            get { return id_instruktur; }
            set { id_instruktur = value; }
        }

        public string Nama_kelas
        {
            get { return nama_kelas; }
            set { nama_kelas = value; }
        }

        public string Id_kelas
        {
            get { return id_kelas; }
            set { id_kelas = value; }
        }

    }
}
