using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class User
    {
        public enum Accessibility
        {
            SysAdmin,
            Veterinarian,
            Receptionist,
            Patient
        }

        string FirstName { get; }
        string SecondName { get; }
        Accessibility Power { get; }

        public User(string firstName, string secondName, Accessibility power)
        {
            FirstName = firstName;
            SecondName = secondName;
            Power = power;
        }
    }
}
