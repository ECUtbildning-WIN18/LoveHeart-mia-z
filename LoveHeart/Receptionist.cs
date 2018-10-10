﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeart
{
    class Receptionist : User
    {
        public int EmployeeID { get; set; }

        public Receptionist(string firstName, string secondName, Accessibility power, int eid)
            : base(firstName, secondName, power)
        {
            EmployeeID = eid;
        }
    }
}