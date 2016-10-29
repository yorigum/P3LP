using System;
using System.Data;
using PP7644.Entity.DataSetPegawaiTableAdapters;

namespace PP7644.Entity
{
    internal class PegawaiControl
    {
        private TBL_PEGAWAITableAdapter TP = new TBL_PEGAWAITableAdapter();
        private TBL_JABATANTableAdapter TJ=new TBL_JABATANTableAdapter();

        public DataTable getJabatan()
        {
            return TJ.GetData();
        }

        public int getJabatan(string jabatan)
        {
            return (int) TJ.getJabatan(jabatan);
        }

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
                return TP.searchPegawai(keyword);

        }

        public void addPegawai(PegawaiEntity P)
        {

            TP.InsertPegawai(P.Nama, P.TglLahir, P.Gender, P.Alamat, P.Contact,P.IDJabatan, P.NoIdentitas);
                //@nama,@tgl_lahir,@gender,@alamat,@noHP,@idJabatan,@noIdentitas)
        }

        public void deletePegawai(int idPegawai)
        {
            TP.DeletePegawai(idPegawai);
        }
    }
}