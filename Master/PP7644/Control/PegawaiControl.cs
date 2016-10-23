using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity.DataSetPegawaiTableAdapters;
using System.Data;

namespace PP7644.Entity
{
    class PegawaiControl
    {
        private TBL_PEGAWAITableAdapter TP = new TBL_PEGAWAITableAdapter();

        public DataTable showPegawai()
        {
            return TP.GetData();
        }
    }
}
