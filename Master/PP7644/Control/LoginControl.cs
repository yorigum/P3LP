using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PP7644.Entity.dsFitNFunTableAdapters;


namespace PP7644.Control
{
    class LoginControl
    {
        TBL_PENGGUNATableAdapter TP = new TBL_PENGGUNATableAdapter();
        
        public bool cekLogin(string user, string pass)
        {
            bool cek = false;
            try
            {
                if (TP.GetUser(user, pass).ToString() != "")
                    cek = true;
            }
            catch (Exception ex)
            {
                cek = false;
            }
            return cek;
        }

        public int GetRoleUser(string user, string pass)
        {
            int role = 0;
            try 
            {
                role = int.Parse(TP.GetRole(user, pass).ToString());
            }
            catch (Exception ex)
            {
                role=0;
            }
            return role;
        }


    }

}


