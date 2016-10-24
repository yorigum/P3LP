using System.Data;
using PP7644.Entity;
using PP7644.Entity.DataSetKelasTableAdapters;

namespace PP7644.Control
{
    internal class KelasControl
    {
        private readonly TBL_KELAS_SENAMTableAdapter TK = new TBL_KELAS_SENAMTableAdapter();

        public DataTable showKelas()
        {
            return TK.GetData();
        }

        public DataTable searchKelas(string Keyword)
        {
            return TK.GetDataBy(Keyword);
        }

        public void addKelas(KelasEntity KE)
        {
            TK.InsertKelas(KE.Nama_kelas, KE.Tarif_perjam, KE.Id_instruktur);
        }
    }
}