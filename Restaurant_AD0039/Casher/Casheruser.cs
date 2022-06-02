using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_AD0039
{
    class Casheruser
    {
        public  string CashName { get; set; }
        public string Password { get; set; }
        public Casheruser(string cashname, string password)
        {
            CashName = cashname;
            Password = password;
        }
    }
}
