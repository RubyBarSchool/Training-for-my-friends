using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HocDeLamNguoi_Buoi2
{
    public class Manager : People
    {
        public double Salary { get; set; }
        public double Allowance { get; set; }

        public Manager() { }
        public Manager(int id, string name, int age, double salary, double allowance) 
            : base (id,name,age)
        {
            Salary = salary;
            Allowance = allowance;
        }
        
        public double Calculate()
        {
            return Salary + Salary * Allowance;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.Write(" \t|\t " + Calculate() + " \t");
        }
    }
}
