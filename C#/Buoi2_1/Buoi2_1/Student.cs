using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Buoi2_1
{
    class Student
    {
        private int id;
        private string mssv;
        public string Name { get; set; }
        public string MSSV {
            get { return "HE" + this.mssv ; }
            set { this.mssv = value; } 
        }

        public Student()
        {

        }

        public int MyProperty { get; set; }





        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

    }
}
