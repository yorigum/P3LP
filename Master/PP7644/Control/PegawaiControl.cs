using System;
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

        public DataTable getKolom()
        {
            DataTable DT = null;
            try
            {
                DT = TP.GetData();
            }
            catch (Exception ex)
            {
               // SE.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }
        public DataTable searchPegawai(string keyword)
        {
            DataTable DT = null;
            try
            {
                DT = TP.searchPegawai(keyword) as DataTable;
            }
            catch (Exception ex)
            {
              //DT.ShowMessage(ex.ToString(), "Kesalahan");
            }
            return DT;
        }
    }
}