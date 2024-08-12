using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_PH45057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV qLSV = new QLSV();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap doi tuong hoac them danh sach doi tuong ");
                Console.WriteLine("2.Xuat danh sach doi tuong ");
                Console.WriteLine("3.Hien thi danh sach sinh vien co ten bat dau bang chu N ");
                Console.WriteLine("4.Tim kiem sinh vien theo ten  ");
                Console.WriteLine("5.Xoa sinh vien theo ma tim tu bana phim ");
                Console.WriteLine("0.Thoat");
                switch (choice)
                {
                    case 0 :
                        
                        break;
                    case 1 :
                        qLSV.Add();
                        break;
                    case 2 :
                        qLSV.outPut();
                        break;
                    case 3 :
                        qLSV.timKiem();
                        break;
                    case 4 :
                        qLSV.timKiemTheoTen();
                        break;
                    case 5 :
                        qLSV.xoa();
                        break;
                }
            } while (choice != 0);

            Console.ReadLine();
        }
    }
}
