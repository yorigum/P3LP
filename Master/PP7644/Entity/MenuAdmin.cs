namespace PP7644.Entity
{
    internal class MenuAdmin
    {
        public MenuAdmin(string nama, int id_pengguna, int id_role, string password)
        {
            Nama = nama;
            Id_pengguna = id_pengguna;
            Id_role = id_role;
            Password = password;
        }

        public string Nama { get; set; }

        public int Id_pengguna { get; set; }

        public int Id_role { get; set; }

        public string Password { get; set; }
    }
}