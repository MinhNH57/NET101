
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLDT qLDT = new QLDT();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap doi tuong");
                Console.WriteLine("2.Xuat doi tuong");
                Console.WriteLine("3.Xoa ma so duoc nhap tu ban phim");
                Console.WriteLine("4.Top 3 san pham co gia cao nhat");
                Console.WriteLine("5.Tim kiem theo ma");
                Console.WriteLine("6.Ke thua");
                switch (choice)
                {
                    case 1:
                        qLDT.Add();
                        break;
                    case 2:
                        qLDT.outPut();
                        break;
                    case 3:
                        qLDT.xoa();
                        break;
                    case 4:
                        qLDT.top3();
                        break;
                    case 5:
                        qLDT.timKiemma();
                        break;
                    case 6:
                        
                        break;
                    case 0:

                        break;
                }
            } while (choice != 0);

            Console.ReadLine();
        }
    }
}
