using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HocDeLamNguoi_Buoi2
{
    class Employee : People
    {
        public double Salary { get; set; }
        public double Alowance { get; set; }
        public double Calculate()
        {
            return Salary + Salary * Alowance;
        }
    }
}
