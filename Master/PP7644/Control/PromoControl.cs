using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity;
using PP7644.Entity.DataSet1TableAdapters;

namespace PP7644.Control
{
    class PromoControl
    {
        private TBL_PROMOTableAdapter TP=new TBL_PROMOTableAdapter();

        public DataTable showPromo()
        {
            return TP.GetData();
        }

        
        public void addPromo(PromoEntity POC)
        {
           TP.InsertPromo(POC.Nama,POC.Jenis,POC.Harga,POC.Bonus);
        }

        public void deletePromo(int idpromo)
        {
            TP.DeletePromo(idpromo);
        }

    }
}
