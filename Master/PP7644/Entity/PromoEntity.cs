using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
    class PromoEntity
    {
        string nama, jenis;
        int harga, bonus;

        public PromoEntity(string nama, string jenis, int harga, int bonus)
        {
            Nama = nama;
            Jenis = jenis;
            Harga = harga;
            Bonus = bonus;
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
    }
}
