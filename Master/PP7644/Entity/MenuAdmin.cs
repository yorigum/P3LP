using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
    class MenuAdmin
    {
        string nama;
        int id_pengguna;
        int id_role;
        string password;



        public MenuAdmin(string nama, int id_pengguna,int id_role, string password)
        {
            this.nama=nama;
            this.id_pengguna=id_pengguna;
            this.id_role=id_role;
            this.password = password;
        }

        public string Nama
        {
            get{return nama;}
            set{nama=value;}
        }

        public int Id_pengguna
        {
            get { return id_pengguna; }
            set { id_pengguna = value; }
        }

        public int Id_role
        {
            get { return id_role; }
            set { id_role = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }



    }
}
