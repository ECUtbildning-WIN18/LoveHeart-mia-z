using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class User
    {
        public enum Accessability
        {
            SysAdmin,
            Veterinarian,
            Receptionist,
            Patient
        }

        string Name { get; }
        int EmployeeID { get; }
        Accessability Power { get; }

        public User(string name, int eid, Accessability power)
        {
            Name = name;
            EmployeeID = eid;
            Power = power;
        }
    }
}
