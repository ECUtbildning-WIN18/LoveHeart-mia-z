using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class SysAdmin : User
    {
        public int EmployeeID { get; set; }

        public SysAdmin(string firstName, string secondName, Accessibility power, int eid)
            : base(firstName, secondName, power)
        {
            EmployeeID = eid;
        }
    }
}
