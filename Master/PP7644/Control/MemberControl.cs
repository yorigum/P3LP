using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity.DataSetMemberTableAdapters;
using PP7644.Entity;
using System.Data;

namespace PP7644.Control
{
    class MemberControl
    {
        private TBL_MEMBERTableAdapter TM = new TBL_MEMBERTableAdapter();
        private TBL_KELAS_SENAMTableAdapter TS = new TBL_KELAS_SENAMTableAdapter();
        
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
