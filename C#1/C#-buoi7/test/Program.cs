using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GiaoVien gv1 = new GiaoVien();
            gv1.Name = "Ngan";
            gv1.Tuoi = 26;
            gv1.ID1 = "PH45057";
            gv1.inra();
            Console.ReadKey();
        }
    }
}
