using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi5.menu1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            QuanLiSinhVien qli = new QuanLiSinhVien();
            do
            {
                Console.WriteLine("Choice: ");
                choice=int.Parse(Console.ReadLine());   
                Console.WriteLine("1.Nhập danh sách học viên");
                Console.WriteLine("2.Xuất danh sách học viên");
                Console.WriteLine("3.Tìm kiếm kết quả ");
                Console.WriteLine("4.Tìm kiếm học sinh từ bàn phím");
                Console.WriteLine("5.Tìm kiếm mã sinh viên");
                Console.WriteLine("6.Sắp xếp học sinh theo điểm");
                Console.WriteLine("7.Xuất 5 điểm cao nhất ");
                Console.WriteLine("8.Tính điểm trung bình của học sinh");
                Console.WriteLine("9.Học sinh có điểm trung bình cao nhất lớp");
                Console.WriteLine("10.Tổng hợp học sinh ");
                Console.WriteLine("0.Thoát ");
                Console.WriteLine();
                Console.WriteLine();
                switch (choice)
                {
                    case 1 :
                        Console.WriteLine("1.Nhập danh sách học viên");
                        qli.add();
                        break;
                    case 2  :
                        Console.WriteLine("2.Xuất danh sách học viên");
                        qli.inDS();
                        break;
                    case 3 :
                        Console.WriteLine("3.Tìm kiếm kết quả ");
                        break;
                    case 4 :
                        Console.WriteLine("4.Tìm kiếm học sinh từ bàn phím");
                        break;
                    case 5 :
                        Console.WriteLine("5.Tìm kiếm mã sinh viên");
                        break;
                    case 6 :
                        Console.WriteLine("6.Sắp xếp học sinh theo điểm");
                        break;
                    case 7 :
                        Console.WriteLine("7.Xuất 5 điểm cao nhất ");
                        break;
                    case 8 :
                        Console.WriteLine("8.Tính điểm trung bình của học sinh");
                        break;
                    case 9 :
                        Console.WriteLine("9.Học sinh có điểm trung bình cao nhất lớp");
                        break;
                    case 10 :
                        Console.WriteLine("10.Tổng hợp học sinh ");
                        break;
                    case 0 :
                        Console.WriteLine("0.Thoát ");
                        break;
                        default: Console.WriteLine("Nhap lai"); break;

                }
            } while (choice != 0);
        }
    }
}
