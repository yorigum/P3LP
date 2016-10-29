using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity.DataSetMemberTableAdapters;
using System.Data;

namespace PP7644.Control
{
    class PresensiMemberControl
    {
        private TBL_PRESENSI_MEMBERTableAdapter TM = new TBL_PRESENSI_MEMBERTableAdapter();

        public DataTable getPresInfo()
        {
           return TM.GetData();
        }
    }
}
