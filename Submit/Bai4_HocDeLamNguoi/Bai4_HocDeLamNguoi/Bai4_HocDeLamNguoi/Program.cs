using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library;
using static System.Net.Mime.MediaTypeNames;

namespace Bai4_HocDeLamNguoi
{
    class Program
    {
        public static void Main(string[] args)
        {
            new Program().menu();
        }
        
        public void menu()
        {
            List<Manager> listManager = new List<Manager>();
            List<Employee> listEmployee = new List<Employee>();
            MenuManager mm = new MenuManager();
            MenuEmployee me = new MenuEmployee();
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Manager {0}" + "(" + listManager.Count + ")");
                Console.WriteLine("2.Employee {0}" + "(" + listEmployee.Count + ")");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Please choose option: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        mm.menuManager(listManager);
                        break;
                    case 2:
                        me.menuEmployee();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;                      
                }
            } while (choice >= 1 && choice <= 3);
        }
    }
}
