using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
    class Class1
    {
        private int id;

        public string Name { get; set; }



        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        static void Main(string[] args)
        {
            Class1 cl = new Class1();
            cl.Name = "adslkj";
            Console.WriteLine(cl.Name);
        }
    }
}
