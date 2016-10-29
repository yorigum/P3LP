using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP7644.Entity
{
  
    class PresensiMemberEntity
    {
        string idMember, namaMember, statusMember, kelasMember;

        public string KelasMember
        {
            get { return kelasMember; }
            set { kelasMember = value; }
        }

        public string StatusMember
        {
            get { return statusMember; }
            set { statusMember = value; }
        }

        public string NamaMember
        {
            get { return namaMember; }
            set { namaMember = value; }
        }

        public string IdMember
        {
            get { return idMember; }
            set { idMember = value; }
        }

        public PresensiMemberEntity(string idmember,string namaMember,string statusMember,string kelasmember)
        {
            this.IdMember=idmember;
            this.NamaMember=namaMember;
            this.StatusMember=statusMember;
            this.KelasMember=kelasmember;
        }
    
        
    }
}
