using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnh_PH45057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service dT = new Service();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap doi tuong");
                Console.WriteLine("2.Xuat doi tuong");
                Console.WriteLine("3.Hien thi danh sach dien thoai co ma nhap tu ban phim");
                Console.WriteLine("4.Top 3 san pham co gia cao nhat");
                Console.WriteLine("5.Xoa thong tin theo ma ");
                Console.WriteLine("6.Ke thua");
                switch (choice)
                {
                    case 1 :
                        dT.Add();
                        break;
                    case 2 :
                        dT.outPut();
                        break;
                    case 3 :
                        dT.timKiemma();
                        break;
                    case 4 :
                        dT.top3();
                        break;
                    case 5 :
                        dT.xoa();
                        break;
                    case 6:
                        Iphone iphone = new Iphone();
                        iphone.inThongTin();
                        break;
                    case 0 :
                        
                        break;
                }
            } while (choice != 0);

            Console.ReadLine();
        }
    }
}
