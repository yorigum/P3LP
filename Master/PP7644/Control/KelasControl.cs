using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity.DataSetKelasTableAdapters;

namespace PP7644.Control
{
    class KelasControl
    {
        private TBL_KELAS_SENAMTableAdapter TK = new TBL_KELAS_SENAMTableAdapter();

        public DataTable showKelas()
        {
            return TK.GetData();
        }
    }
}
