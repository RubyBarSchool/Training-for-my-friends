using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HocDeLamNguoi_Buoi2
{
    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public People(){ }
        public People(int id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.Write("|\t" + this.ID + " \t|\t " + this.Name + " \t|\t " + this.Age);

        }
    }
}
