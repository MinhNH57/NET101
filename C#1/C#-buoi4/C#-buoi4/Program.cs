using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
             * 1. Toán tử ba ngôi 
             * 
             * 2. Câu lệnh điều kiện
             * 
             
            int trangThai;
            Console.WriteLine("Moi nhap ");
            trangThai = int.Parse(Console.ReadLine());
            if(trangThai == 0 )
            {
                Console.WriteLine("Con yeu");
            }else if (trangThai == 1)
            {
                Console.WriteLine("Het yeu");
            }
            // Viet nam sinh , gioi tinh ; dua ra thong tin cua mot nguoi bat ky xem do la anh trai hay chi gai , em trai ...
            int myYear = 2004;
            //int gender = 1; 
            int Year;
            int gender1;
            Console.Write("Year:");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Gioi tinh :");
            gender1 = int.Parse(Console.ReadLine());
            string turn = (myYear > Year && gender1 == 1) ? "Anh trai" :
                (myYear < Year && gender1 == 1) ? "Em trai" :
                (myYear > Year && gender1 == 0) ? "Chi gai" :
                (myYear < Year && gender1 == 0) ? "Em gai" : "Ban";
            Console.WriteLine(turn);
            float diemC;
            Console.WriteLine();
            Console.WriteLine("Nhap");
            diemC = float.Parse(Console.ReadLine());
            if (diemC >= 0 && diemC <= 10)
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine();
            }
            
            // Xep loai hoc luc 
            float diem;
            Console.Write("Diem : ");
            diem=float.Parse(Console.ReadLine());
            if(diem >= 8 )
            {
                Console.WriteLine("Gioi");
            }else if (diem > 6.5)
            {
                Console.WriteLine("Kha");
            }else if (diem >= 5)
            {
                Console.WriteLine("TB");
            }else
            {
                Console.WriteLine("Truot");
            }
            
            // kn ra cac so le 
            int n;
            int tong = 0;
            Console.WriteLine("Nhap n : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0 && i != 9 )
                {
                    Console.WriteLine(i);
                    tong += i;
                }
            }
            Console.WriteLine(tong);
            //for(int a = 1 ; a <= 10; a+=2)
            // {
            //     Console.WriteLine(a);
            //}
            */
            int i;
            int j; 
            for( i = 1; i <= 8;i++) 
            {
                for( j = 1 ; j <= i;j++)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
