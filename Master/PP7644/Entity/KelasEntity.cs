namespace PP7644.Entity
{
    internal class KelasEntity
    {
        public KelasEntity(string id_kelas, string nama_kelas, string id_instruktur, int tarif_perjam)
        {
            Id_kelas = id_kelas;
            Nama_kelas = nama_kelas;
            Id_instruktur = id_instruktur;
            Tarif_perjam = tarif_perjam;
        }

        public int Tarif_perjam { get; set; }

        public string Id_instruktur { get; set; }

        public string Nama_kelas { get; set; }

        public string Id_kelas { get; set; }
    }
}