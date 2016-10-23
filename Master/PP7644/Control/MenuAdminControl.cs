using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.PP_L_7644DataSetTableAdapters;
using System.Data;

namespace PP7644.Control
{
    class MenuAdminControl
    {
        private TBL_PENGGUNATableAdapter TP=new TBL_PENGGUNATableAdapter();

        public DataTable showPengguna()
        {
            return TP.GetData();
        }
 
    }
}
