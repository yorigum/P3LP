using System;
using PP7644.Entity.dsFitNFunTableAdapters;

namespace PP7644.Control
{
    internal class LoginControl
    {
        private readonly TBL_PENGGUNATableAdapter TP = new TBL_PENGGUNATableAdapter();

        public bool cekLogin(string user, string pass)
        {
            var cek = false;
            try
            {
                if (TP.GetUser(user, pass) != "")
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
            var role = 0;
            try
            {
                role = int.Parse(TP.GetRole(user, pass).ToString());
            }
            catch (Exception ex)
            {
                role = 0;
            }
            return role;
        }
    }
}