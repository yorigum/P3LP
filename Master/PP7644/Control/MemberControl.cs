using System.Data;
using PP7644.Entity;
using PP7644.Entity.DataSetMemberTableAdapters;

namespace PP7644.Control
{
    internal class MemberControl
    {
        private readonly TBL_MEMBERTableAdapter TM=new TBL_MEMBERTableAdapter();
        

        public DataTable showMember()
        {
           return TM.GetData();
        }

       

        public void addMember(KelolaMember M)
        {
            //TM.insertMember(M.IdMember, M.Nama, M.Datelahir, M.Gender, M.Alamat, M.Telepon, M.Noidentitas);
        }

        public void deleteMember(string id)
        {
            TM.DeleteMember(id);
        }

        //===========================
        public void getCountMember()
        {
            TM.getCountRowMember();
        }

    }
}