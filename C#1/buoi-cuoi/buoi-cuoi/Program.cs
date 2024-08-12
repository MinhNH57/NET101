
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_cuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLSV qLSV = new QLSV();
            int choice; do
            {
                Console.WriteLine("Xin moi nhap vao chuong trinh :");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                switch (choice)
                {
                    case 1 :
                        qLSV.Add();
                        break;
                    case 2 :
                        qLSV.xuat();
                        break;
                    case 3 :
                        qLSV.xuattren18();
                        break;
                    case 4 :
                        qLSV.sapxep();
                        break;
                    case 5 :
                        qLSV.timKiem();
                        break;
                    case 6 :
                        qLSV.keThua();
                        break;
                    case 0 :
                        break;

                }

            } while (choice !=  0);

            Console.ReadLine();
        }
    }
}
