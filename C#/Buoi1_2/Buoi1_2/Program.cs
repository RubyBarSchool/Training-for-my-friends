using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_2
{
     abstract class Program : Interface1
    {
        static void pt(int input,ref int du,ref int thuong )
        {
            du = input % 3;
           thuong =  input/3;
        }
        
        static void Main(string[] args)
        {
            //int a = 10 ;
            //int du = 0;
            //int thuong = 0;
            //Console.WriteLine("Truoc:" + a);
            //pt(10, ref du,ref thuong);
            //Console.WriteLine("thuong:" + thuong + "Du: " + du);
            //Console.ReadKey();
            // collection 
            ArrayList arrCol = new ArrayList();
            List<object> arrGen = new List<object>();

            arrCol.Add("Aagdshas");
            arrCol.Add(1);

            arrGen.Add("Aagdshas");
            arrGen.Add(1);

           

            

            

        }

        public void Display1()
        {
            throw new NotImplementedException();
        }
    }
}
