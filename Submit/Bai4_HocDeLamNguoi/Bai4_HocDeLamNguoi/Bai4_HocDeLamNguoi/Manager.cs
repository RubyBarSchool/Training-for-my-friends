using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_HocDeLamNguoi
{
    class Manager : People
    {
        public double Salary { get; set; }
        public double Allowance { get; set; }
        public double Calculator()
        {
            return Salary + Salary * Allowance;
        }
        public void ShowInfor()
        {
            Console.WriteLine("ID: " + ID + " Name: "+ Name + " Age: "+ Age + " Salary: "+Calculator());
        }
    }
}
