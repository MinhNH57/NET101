
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV qLSV = new QLSV();
            int choice;
            do
            {
                Console.WriteLine("Xin moi nhap chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Them danh sach sinh vien");
                Console.WriteLine("2.Xuat danh sach sinh vien");
                Console.WriteLine("3.Tim kiem theo ten cau sinh vien");
                Console.WriteLine("4.Tim kiem theo hoc hoc luc");
                Console.WriteLine("5.Xoa sinh vien theo ma so sinh vien");
                Console.WriteLine("6.Xuat ra top 3 sinh vien co diem cao nhat");
                Console.WriteLine("7.Xuat ra sinh vien co diem thap nhat");
                Console.WriteLine("8.Tinh trung binh diem cua tat ca cac sinh vien");
                Console.WriteLine("9.Xuat ra sinh vien co diem cao hown diem trung binh cua lop");
                Console.WriteLine("0.Thoat");
                switch (choice)
                {
                    case 1 :
                        qLSV.Add();
                        break;
                    case 2 :
                        qLSV.outPut();
                        break;
                    case 3 :
                        qLSV.lookingForName();
                        break;
                    case 4 :
                        qLSV.lookingForTitle();
                        break;
                    case 5 :
                        qLSV.delete();
                        break;
                    case 6 :
                        qLSV.top3();
                        break;
                    case 7 :
                        qLSV.minMark();
                        break;
                    case 8 :
                        qLSV.averageMark();
                        break;
                    case 9 :
                        qLSV.higherThanaverage();
                        break;
                    case 0 :
                        Console.WriteLine();
                        break;
                }
            } while(choice != 0);
        }
    }
}
