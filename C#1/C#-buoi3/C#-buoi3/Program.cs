
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*.
             * Kiểu toán tử C#
             * Toán tử số học 
             * + , - , * , % , / , ++ , --
             * Toán tử so sánh 
             * > , < , >= , <=  , == , !=
             * Toán tử gán 
             * += , -= , *= , /= , %=
             * Toán tử logic
             * && , || , ! 
             * Các phương thức ép kiểu
             * Parse
             * Convert
             */
            /*
            Console.OutputEncoding = Encoding.UTF8; 
            Console.WriteLine("Chào mừng bạn đế với C#1");
            int nam_sinh;
            nam_sinh = int.Parse(Console.ReadLine());
            int tuoi = 2023 - nam_sinh;
            Console.WriteLine("Tuổi sinh viên là :{0}",tuoi);
            //
            string name;
            string diaChi;
            int ngaySinh, thangSinh, namSinh;
            Console.Write("Ten:");
            name = Console.ReadLine();
            Console.Write("Dia chi :");
            diaChi = Console.ReadLine();
            Console.Write("Ngay sinh:");
            ngaySinh = int.Parse(Console.ReadLine());
            Console.Write("Thang sinh:");
            thangSinh = int.Parse(Console.ReadLine());
            Console.Write("Nam sinh:");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Ten {0} dia chi {1} ngay thang nam sinh {2}-{3}-{4}",name,diaChi,ngaySinh,thangSinh,namSinh);
            */
            /*
            float a;
            float b;
            //float thuong;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            //thuong = (a/b);
            Console.WriteLine($"Tong = {a + b} || Hieu = {a - b} || Nhan = {a*b} || Chia = {a/b}");
            */
            // Viết chương trình tính tổng các số chia hết cho ba và năm 
             
            for(int i = 1; i <= 15; i++)
            {
                if( i % 3 == 0 || i % 5 == 0 )
                {
                   // tong += i;
                    Console.Write(i + " ");
                    
                }
            }
            Console.WriteLine();    
           // Console.WriteLine(tong);
            int tong = 0; 
            for(int a = 1 ; a <= 10; a++)
            {
                if(a % 2 == 0)
                {
                    tong += a; 
                }
            }
            Console.WriteLine(tong);
            Console.ReadLine();
            //
        }
    }
}
