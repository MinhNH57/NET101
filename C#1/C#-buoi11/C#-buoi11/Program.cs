
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLGV qLGV = new QLGV();
            int choice;
            do
            {
                Console.WriteLine("Xin moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap danh sach sinh vien");
                Console.WriteLine("2.Xuat danh sach hoc vien");
                Console.WriteLine("3.Tim kiem hoc vien theo khoang diem");
                Console.WriteLine("4.Tim kiem theo hoc luc ");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("---------------------------------------------------------------------");
                switch (choice)
                {
                    case 0:

                        break;
                    case 1:
                        qLGV.Add();
                        break;
                    case 2:
                        qLGV.inDS();
                        break;
                    case 3:
                        qLGV.xuatdstrongkhoanggio();
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case 10:

                        break;
                }
            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
