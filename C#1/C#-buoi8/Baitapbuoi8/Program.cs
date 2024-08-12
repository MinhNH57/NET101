using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitapbuoi8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhap vao ban phim n phong hoc , sau do in ra 
            int n;
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            int soPhong;
            List<int> lstsoPhong = new List<int>();
            for(int i  = 0; i < n; i ++)
            {
                Console.WriteLine("Mời nhâpj vào số phòng : ");
                soPhong = int.Parse(Console.ReadLine());
                lstsoPhong.Add(soPhong);
            }
            foreach(int x in lstsoPhong)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
