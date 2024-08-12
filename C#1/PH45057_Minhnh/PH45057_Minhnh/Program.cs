using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH45057_Minhnh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap danh sach doi tuong , khi nhap xong hoi co tiep tuc hay khong ?");
                Console.WriteLine("2.Xuat danh sach doi tuong");
                Console.WriteLine("3.Xuat danh sach doi tuong tren 30 tuoi");
                Console.WriteLine("4.Sap Xep doi tuong theo ID tang dan");
                Console.WriteLine("5.Ke thua");
                Console.WriteLine("0.Thoat");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("---Them danh sach sinh vien ----");
                        service.add();
                        break;
                    case 2:
                        Console.WriteLine("---Xuat danh sach----");
                        service.xuat();
                        break;
                    case 3:
                        Console.WriteLine("---Xuat danh sach tren 30 tuoi ----");
                        service.xuat30();
                        break;
                    case 4:
                        Console.WriteLine("-----Sap xep danh sach----");
                        service.sapxepID();
                        break;
                    case 5:
                        Console.WriteLine("----Ke thua -----");
                        service.kethua();
                        break;
                    case 0:
                        break;
                }
            } while (choice != 0);

            Console.ReadLine();
        }
    }
}
