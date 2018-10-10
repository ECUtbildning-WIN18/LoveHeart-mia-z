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

        public string FirstName { get; }
        public string SecondName { get; }
        public string Password { get; set; }
        public Accessibility Power { get; }

        public User(string firstName, string secondName, string password, Accessibility power)
        {
            FirstName = firstName;
            SecondName = secondName;
            Password = password;
            Power = power;
        }
    }
}
