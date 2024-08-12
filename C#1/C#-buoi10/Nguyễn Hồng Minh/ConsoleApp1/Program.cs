using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLNV qLNV = new QLNV();
            int n;
            do
            {
                Console.WriteLine("Chon chuong trinh :");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Them nhan vien");
                Console.WriteLine("2.Xuat danh sach nhan vien");
                Console.WriteLine("3.Xuat danh sach nhan vien tren 50 tuoi");
                Console.WriteLine("4.Xoa nhan vien ");
                Console.WriteLine("5.Tim kiem nhan vien theo khoang");
                Console.WriteLine("0.Thoat");
                switch (n)
                {
                    case 1 :
                        qLNV.Add();
                            break;
                    case 2 :
                        qLNV.xuat();
                            break;
                    case 3 :
                        qLNV.xuat1();
                            break;
                    case 4 :
                        qLNV.delete();
                            break;
                    case 5 :
                        qLNV.timKiemTheoKhoang();
                            break;
                    case 0 :
                        Console.WriteLine();
                            break;
                }
            } while (n != 0);
        }
    }
}
