using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library;

namespace HocDeLamNguoi_Buoi2
{
    class Program
    {
        //menu manager
        static void MenuManager(ref int count,List<Manager> lm)
        {
            count = 0;
            while (true)
            {
                Console.WriteLine("----------Menu Manager----------");
                Console.WriteLine("1: Add Manager");
                Console.WriteLine("2: Remove Manager");
                Console.WriteLine("3: Search Manager");
                Console.WriteLine("4: View all Manager");
                Console.WriteLine("5: View Top 5 Manager have more salary");
                Console.WriteLine("6: Sort Manager");
                Console.WriteLine("7: Edit Manager By ID");
                Console.WriteLine("8: Out of Menu");

                Console.Write("Choose option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddManager(ref count,lm);
                        break;
                    case 2:
                        DeleteManager(ref count, lm);
                        break;
                    case 3:
                        SearchManager(lm);
                        break;
                    case 4:
                        DisplayManager(lm);
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        DisplayMenu(ref count, lm);
                        break;
                }
            }
        }

        static void DisplayMenu(ref int count, List<Manager> lm)
        {
            Console.WriteLine("1: Manager ({0})", count);
            Console.WriteLine("2: Employee");
            Console.Write("Enter choice number you want:");
            int choice = Convert.ToInt32(Console.ReadLine());
            lm = new List<Manager>();
            switch (choice)
            {
                case 1:
                    MenuManager(ref count, lm);
                    break;
                case 2:
                    break;
            }
        }
        static void Main(string[] args)
        {
            int count = 0;
            List<Manager> lm = new List<Manager>();
            DisplayMenu(ref count,lm);
        }
        static void AddManager(ref int count , List<Manager> listManager )
        {
                Console.Write("Enter ID: ");
                int Id = Validation.CheckInputInt();
                Console.Write("Enter Name: ");
                string Name = Validation.CheckInputString();
                Console.Write("Enter Age: ");
                int Age = Validation.CheckInputInt();
                Console.Write("Enter Salary: ");
                double Salary = Validation.checkInputIntLimit(1390000,10000000);
                Console.Write("Enter Allowance: ");
                double Allowance = Validation.CheckInputDouble();
                if (Validation.checkStudentExist(listManager, Id, Name, Age))
                {
                    listManager.Add(new Manager(Id, Name, Age, Salary, Allowance));
                    count++;
                    Console.WriteLine("Add manager successfully");
                }
                else
                {
                    Console.WriteLine("Manager is exit");
                }
        }       
        static void DeleteManager(ref int count , List<Manager> listManager)
        {
            while (true)
            {
                Console.Write("Enter ID Manager:");
                int id = Validation.CheckInputInt();
                if (Validation.checkIdExist(listManager,id))
                {
                    Console.WriteLine("Don't have Manager have id is"+id);
                }
                else
                {
                    for(int i = 0; i < listManager.Count; i++)
                    {
                        if (listManager[i].ID == id)
                        {
                            listManager.RemoveAt(i);
                            count--;
                            Console.WriteLine("Remove Successfull");
                            return;
                        }                            
                    }                   
                }
            }
        }
        static void SearchManager(List<Manager> listManager)
        {
            Console.Write("Nhap ma cua sinh vien can tim: ");
            int id = Validation.CheckInputInt();

            Console.Write("\n_________________________________________________________________");
            Console.Write("\n|\tID\t|\tName\t|\tAge\t|\tSalary\t\t|\n");
            Console.Write("-----------------------------------------------------------------\n");

            for (int i = 0; i < listManager.Count; i++)
            {
                if (listManager[i].ID == id)
                {
                    listManager[i].DisplayInfo();
                    Console.Write("\n_________________________________________________________________\n");
                }
                return;
            }
        }
        static void DisplayManager(List<Manager> listManager)
        {
            Console.Write("\n_________________________________________________________________");
            Console.Write("\n|\tID\t|\tName\t|\tAge\t|\tSalary\t\t|\n");
            Console.Write("-----------------------------------------------------------------\n");
            for (int i = 0; i < listManager.Count; i++)
            {
                listManager[i].DisplayInfo();
                Console.Write("\n_________________________________________________________________\n");
            }
            return;
        }
    }
}
