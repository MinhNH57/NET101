using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            secvice sc = new secvice();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh");
                choice=int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Nhap danh sach Laptop");
                Console.WriteLine("2.Xuat danh sach Laptop");
                Console.WriteLine("3.Sap xep danh sach Laptop");
                Console.WriteLine("4.Thoat");
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thoat");
                        break;
                    case 1:
                        sc.add();
                        break;
                    case 2:
                        sc.xuat();
                        break;
                    case 3:
                        Console.WriteLine("Danh sach sau khi sap xep la :");
                        
                        break;
                }
            } while (choice != 0);
        }
    }
}
