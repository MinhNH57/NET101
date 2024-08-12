using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QLHV qLHV = new QLHV();
            int choice;
            do
            {
                Console.WriteLine("Xin moi chon chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap danh sach sinh vien");
                Console.WriteLine("2.Xuat danh sach hoc vien");
                Console.WriteLine("3.Tim kiem hoc vien theo khoang diem");
                Console.WriteLine("4.Tim kiem theo hoc luc ");
                Console.WriteLine("5.Tim kiem theo ma so");
                Console.WriteLine("6.Sap xep hoc vien theo diem");
                Console.WriteLine("7.Xuat ra 5 hoc vien co diem cao nhat");
                Console.WriteLine("8.Tinh diem trung binh cua lop");
                Console.WriteLine("9.Xuat danh sach sinh vien co diem lon hon diem trung binh cua lop");
                Console.WriteLine("10.Tong hop so hoc vien theo hoc luc ");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("---------------------------------------------------------------------");
                switch (choice)
                {
                    case 0 :
                        
                        break;
                    case 1 :
                        qLHV.Add();
                        break;
                    case 2 :
                        qLHV.xuat();
                        break;
                    case 3 :
                        qLHV.timkiemtheodiem();
                        break;
                    case 4 :
                        qLHV.timkiemtheohocluc();
                        break;
                    case 5 :
                        qLHV.timkiemtheomaso();
                        break;
                    case 6 :
                        qLHV.sapxeptheodiem();
                        break;
                    case 7 :
                        qLHV.top5();
                        break;
                    case 8 :
                        qLHV.diemTB();
                        break;
                    case 9 :
                        qLHV.sinhviencodiemtbcaonhatlop();
                        break;
                    case 10 :
                        qLHV.tonghop();
                        break;
                }
            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
