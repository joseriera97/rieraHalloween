using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sakila
{
    class Staff
    {

        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public string FullInfo
        {
            get
            {
                return username + password + email;
            }
        }
    }
}
