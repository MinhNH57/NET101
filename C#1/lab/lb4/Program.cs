using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SanPham sanPham = new SanPham();
            sanPham.nhap();
            sanPham.xuat();
            Console.ReadLine();
        }
    }
}
