using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_HocDeLamNguoi
{
    class MenuManager
    {
        public void menuManager(List<Manager> listManager)
        {
            while (true)
            {
                Console.WriteLine("------ Menu Manager ------");
                Console.WriteLine("1. Add Manager");
                Console.WriteLine("2. Remove Manager");
                Console.WriteLine("3. Search Manager(By ID or Name)");
                Console.WriteLine("4. View All Manager");
                Console.WriteLine("5. View Top 5 Manager have more Salary");
                Console.WriteLine("6. Sort Manager(Ascending of by Salary)");
                Console.WriteLine("7. Edit Manager By ID");
                Console.WriteLine("8. Out to Menu");
                Console.WriteLine("Please choose option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addManager(listManager);
                        break;
                    case 2:
                        removeManager(listManager);
                        break;
                    case 3:
                        searchManager(listManager);
                        break;
                    case 4:
                        viewManager(listManager);
                        break;
                    case 5:
                        viewTop5Manager(listManager);
                        break;
                    case 6:
                        sortManager(listManager);
                        break;
                    case 7:
                        editManager(listManager);
                        break;
                    case 8:
                        backMenuManager(listManager);
                        break;

                }
            }

        }

        //ham Add Manager
        public void addManager(List<Manager> listManager)
        {
            Manager ma = new Manager();
            Console.WriteLine("Input ID: ");
            ma.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Name: ");
            ma.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input Age: ");
            ma.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            ma.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Allowance: ");
            ma.Allowance = Convert.ToDouble(Console.ReadLine());
            listManager.Add(ma);
            Console.WriteLine("Da Them Thanh Cong");
            menuManager(listManager);
        }

        //ham Remove Manager
        public void removeManager(List<Manager> listManager)
        {
            int id;
            Console.Write("Chon ID ma ban muon xoa: ");
            id = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < listManager.Count; i++)
            {
                if (listManager[i].ID == id)
                {
                    listManager.RemoveAt(i);
                    Console.WriteLine("Remove successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Dont have Manager have ID is " + id);
                    break;
                }
            }
            menuManager(listManager);
        }


        //ham Search Manager
        public void searchManager(List<Manager> listManager)
        {
            int id;
            string name = "";
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Chon ID or Name");
            Console.WriteLine("1.ID: ");
            Console.WriteLine("2.Name: ");
            switch (choice)
            {
                case 1:
                    Console.Write("Chon ID ma ban muon search: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < listManager.Count; i++)
                    {
                        if (listManager[i].ID == id)
                        {
                            listManager[i].ShowInfor();
                        }
                    }
                    break;
                case 2:
                    Console.Write("Chon Name ma ban muon search: ");
                    name = Convert.ToString(Console.ReadLine());
                    for (int i = 0; i < listManager.Count; i++)
                    {
                        if (listManager[i].Name == name)
                        {
                            listManager[i].ShowInfor();
                        }
                    }
                    break;
            }
            menuManager(listManager);
        }

        //ham View Manager
        public void viewManager(List<Manager> listManager)
        {
            foreach (Manager man in listManager)
            {
                Console.WriteLine(" Manager " + man.ID + " : ");
                man.ShowInfor();
            }
            menuManager(listManager);
        }

        //ham View Top 5 Manager
        public void viewTop5Manager(List<Manager> listManager)
        {
            menuManager(listManager);
        }

        //ham Sort Manager
        public void sortManager(List<Manager> listManager)
        {
            //check theo salary
            foreach (Manager man in listManager)
            {
                
                listManager.Sort();
                man.ShowInfor();
            }
            menuManager(listManager);
        }

        //ham Edit Manager
        public void editManager(List<Manager> listManager)
        {
            menuManager(listManager);
        }

        //ham Quay Ve Menu
        public static void backMenuManager(List<Manager> listManager)
        {
            new Program().menu();
        }
    }
}
