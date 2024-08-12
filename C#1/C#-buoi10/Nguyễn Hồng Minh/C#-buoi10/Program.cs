
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV qLSV = new QLSV();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh : ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("1.Nhap danh sach doi tuong");
                Console.WriteLine("2.Xuat danh sach doi tuong");
                Console.WriteLine("3.Xuat danh sach sinh vien tren 20 tuoi");
                Console.WriteLine("4.Tim kiem nghanh hoc ");
                Console.WriteLine("5.Xoa thong tin ");
                Console.WriteLine("0.Thoat");
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thoat");
                        
                        break;
                    case 1:
                        Console.WriteLine("1.Nhap danh sach doi tuong");
                        qLSV.Add();
                        
                        int n;
                        Console.WriteLine("Ban co muon thoat khong ?");
                        n = int.Parse(Console.ReadLine());
                        if (n == 0)
                        {
                            qLSV.Add();
                        }
                        else
                        {
                            break;
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("2.Xuat danh sach doi tuong");
                        qLSV.xuat();
                        break;
                    case 3:
                        Console.WriteLine("3.Xuat danh sach sinh vien tren 20 tuoi");
                        qLSV.xuat1();
                        break;
                    case 4:
                        Console.WriteLine("4.Tim kiem nghanh hoc ");
                        qLSV.lookUp();
                        break;
                    case 5:
                        Console.WriteLine("5.Xoa thong tin ");
                        qLSV.Delete();
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }
    }
}
