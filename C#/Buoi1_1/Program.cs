using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;

namespace Buoi1
{
    class Program
    {

        // bài tập tạo 1 hàm cộng 1 hàm trừ 1 hàm nhân 1 hàm chia sau đó trong hàm main
        // nhập 2 sso bất kì
        // dùng 4 hàm bên trên để tính kết quả rồi in ra màn hình
        int add(int a,int b)
        {
            return a + b;
        }
         static int add1(int a, int b)
        {
            return a + b;
        }

        static void addKhongReturn()
        {
            // khong duoc chua ham in ra man hinh
        }

        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            // cach nhap va cach in
            // dung namespace Console
            Console.WriteLine("");
            Console.Write("");
            // nhap 
            Console.WriteLine("Moi ban nhap so a: ");
            a = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Moi ban nhap so b: ");
            b = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Tong cua a va b :"+(new Program()).add(a,b));
            Console.WriteLine("Tong cua a va b :" + add1(a,b));
            Console.ReadKey();
        }
    }
}
