using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2buoi2
{
    internal class Program
    {
        // Bien toan cuc 
        string _input;
        static void Main(string[] args)
        {
            
            /*
             * Bien , khai bao bien ,nhap xuat 
             * Bien : la noi luu giu gia tri 
             * Cach khai bao bien : 
             * C1 : <kieu du lieu > ten bien  = <gia tri>
             * C2 : <kieu du lieu>  ten bien1 , tenbien2 ; 
             * Quy tac dat ten bien : 
             * C1 : normal -  Vd : sinhvien , diemtrungbinh ,.....
             * C2 : camelCase - Vd : diemTrungbinh , diaChi , ...
             * C3 : snake_case - Vd : sinh_vien , chieu_dai , .. 
             * Bien khai bao trong ham main la bien cuc bo 
             * Luu y : 
             * Ten bien khong doc chua tu khoa 
             * Khong bat dau boi so 
             * Ten bien phai co nghia 
             * Cac kieu du lieu 
             * So nguyen int , long , short , byte , sbyte ,...
             * So thuc : Float , double , decimal ,...
             * Logic : bool 
             * var : dai dien cho tat ca cac kieu du lieu 
             * Kieu chuoi : char , string 
             */

            float diem_Csharp;
            Console.Write("Diem C# la :");
            diem_Csharp = float.Parse(Console.ReadLine());
            if (diem_Csharp < 5 ) 
            {
                Console.WriteLine("Fail");
            }else
            {
                Console.WriteLine("Pass");
            }
            // Vd 
            // 1 . In ra ky tu $
            // 2 . In ra chu FPT polytechnic 
            // 3 . Nhap vao tu ban phim ho va ten , ngay thang nam sinh , nganh 
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("$");
            string school = "FPT Polytechnic Hà Nội"; 
            Console.WriteLine("FPT Polytechnic");
            string name;
            Console.Write("Họ và Tên : ");
            name = Console.ReadLine();
            int year;
            Console.Write("Năm Sinh: ");
            year = int.Parse(Console.ReadLine());
            string major;
            Console.Write("Nghành Học  :");
            major = Console.ReadLine();
            Console.WriteLine($"Sinh Viên {name} sinh năm {year} và đang học nghành {major} tại Cao Đẳng {school}");
            Console.ReadKey();
        } 
    }
}
