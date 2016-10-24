using System.Data;
using PP7644.Entity;
using PP7644.Entity.DataSetMemberTableAdapters;

namespace PP7644.Control
{
    internal class MemberControl
    {
        private readonly TBL_MEMBERTableAdapter TM = new TBL_MEMBERTableAdapter();
        private readonly TBL_KELAS_SENAMTableAdapter TS = new TBL_KELAS_SENAMTableAdapter();

        public DataTable showMember()
        {
            return TM.GetData();
        }

        public DataTable searchMember(string Keyword)
        {
            return TM.GetDataBy(Keyword);
        }

        public void addMember(KelolaMember M)
        {
        }

        //===========================

        public DataTable getKelas()
        {
            return TS.GetData();
        }

        public int getIDKelas(string kelas)
        {
            return TS.GetIdKelas(kelas).Value;
        }
    }
}