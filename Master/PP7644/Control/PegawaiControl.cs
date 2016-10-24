using System.Data;
using PP7644.Entity.DataSetPegawaiTableAdapters;

namespace PP7644.Entity
{
    internal class PegawaiControl
    {
        private readonly TBL_PEGAWAITableAdapter TP = new TBL_PEGAWAITableAdapter();

        public DataTable showPegawai()
        {
            return TP.GetData();
        }
    }
}