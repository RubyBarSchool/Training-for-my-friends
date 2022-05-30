using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Library
{
    public class Validation
    {
        //check int
        public bool checkInputInt()
        {
            string notifyInput = "";
            while (true)
            {
                try
                {
                    foreach (Char c in notifyInput)
                    {
                        if (!Char.IsDigit(c))
                            return false;
                    }
                    return true;
                }
                catch (Exception e) //cứ nhập sai yêu cầu ở hàm try là báo lỗi luôn
                {
                    Console.WriteLine("Có lỗi rồi");
                    Console.WriteLine(e.Message);
                }
            }
        }

        //check double
        public bool checkInputDouble()
        {
            string notifyInput = "";
            while (true)
            {
                try
                {
                    Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
                    return regex.IsMatch(notifyInput);
                }
                catch (Exception e) //cứ nhập sai yêu cầu ở hàm try là báo lỗi luôn
                {
                    Console.WriteLine("Có lỗi rồi");
                    Console.WriteLine(e.Message);
                }
            }
        }

        //check Salary Manager
        public bool checkInputSalaryManager(int salary)
        {
            while (true)
            {
                if (salary >= 1390000 && salary <= 10000000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        //check Salary Employee
        public bool checkInputSalaryEmployee(int salary)
        {
            while (true)
            {
                if (salary >= 500000 && salary <= 5000000)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
