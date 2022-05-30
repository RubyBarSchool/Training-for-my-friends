using HocDeLamNguoi_Buoi2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Validation
    {
        public static int CheckInputInt()
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.Write("Enter again:");
                }
            }

        }
        public static int checkInputIntLimit(int min, int max)
        {
            //loop until user input correct
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < min || result > max)
                    {
                        throw new Exception();

                    }
                    return result;
                }
                catch (Exception e)
                {
                    Console.Write("Choose number again ("+min +"<= number <=" +max +")");
                }
            }
        }

        public static double CheckInputDouble()
        {
            while (true)
            {
                try
                {
                    double result = Convert.ToInt32(Console.ReadLine());
                    return result;
                }
                catch (Exception)
                {
                    Console.Write("Enter again:");
                }
            }

        }

        public static string CheckInputString()
        {
            while (true)
            {
                string result = Console.ReadLine();
                if (result.Length == 0)
                {
                    Console.Write("Not empty.Enter again: ");
                }
                else
                {
                    return result;
                }
            }    
        }


        public static bool checkStudentExist(List<Manager> lm, int id,string name, int age)
        {
            foreach (Manager ma in lm)
            {
                if (id.Equals(ma.ID)&& name.Equals(ma.Name)&& age.Equals(ma.Age))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool checkIdExist(List<Manager> lm, int id)
        {
            foreach(Manager ma in lm)
            {
                if (id.Equals(ma.ID))
                {
                    return false;
                }
            }
            return true;
        }

        
    }
}
