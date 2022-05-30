using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_HocDeLamNguoi
{
    class MenuEmployee
    {
        public void menuEmployee()
        {
            List<Employee> listEmployee = new List<Employee>();
            int ID = 0;
            while (true)
            {
                Console.WriteLine("------ Menu Employee ------");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Search Employee(By ID or Name)");
                Console.WriteLine("4. View All Employee");
                Console.WriteLine("5. View Top 5 Employee have more Salary");
                Console.WriteLine("6. Sort Employee(Ascending of by Salary)");
                Console.WriteLine("7. Edit Employee By ID");
                Console.WriteLine("8. Out to Menu");
                Console.WriteLine("Please choose option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;

                }
            }

        }
    }
}
