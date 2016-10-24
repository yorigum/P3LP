using System.Data;
using PP7644.PP_L_7644DataSetTableAdapters;

namespace PP7644.Control
{
    internal class MenuAdminControl
    {
        private readonly TBL_PENGGUNATableAdapter TP = new TBL_PENGGUNATableAdapter();

        public DataTable showPengguna()
        {
            return TP.GetData();
        }
    }
}