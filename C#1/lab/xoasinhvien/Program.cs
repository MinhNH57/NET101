using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xoasinhvien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Do s = new Do();
            s.Add();
            s.xuat();
            s.xoa();
            s.xuat();
            Console.ReadLine();
        }
    }
}
