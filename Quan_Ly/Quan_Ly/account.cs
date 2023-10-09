using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly
{
    internal class account
    {
        public string user { get; set; }
        public string password { get; set; }
        public string permission { get; set; }
        public string nameOfUser { get; set; }
        public string cauHoi { get; set; }
        public string DapAn { get; set; }
        public account() { }
        public account(string user, string password, string permission, string nameOfUser)
        {
            this.user = user;
            this.password = password;
            this.permission = permission;
            this.nameOfUser = nameOfUser;
        }
        public account(string user, string CauHoi, string DapAn)
        {
            this.user = user;
            this.cauHoi = CauHoi;
            this.DapAn = DapAn;
        }
    }
}
