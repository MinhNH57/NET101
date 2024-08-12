using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QLTV qLTV = new QLTV();
            int choice; 
            do
            {
                Console.Write("Choice = ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("1.Nhap danh sach");
                Console.WriteLine("2.Xuat danh sach");
                switch (choice)
                {
                    case 1 :
                        qLTV.Add();
                        break;
                    case 2 :
                        qLTV.outPut();
                        break;
                    case 3 :
                        qLTV.sapXep();
                        break;
                    case 4 :
                        qLTV.sapXepTangDan();
                        break;
                    case 5:
                       
                        break;
                    case 0 :
                        Console.WriteLine();
                        break;
                }
            } while (choice != 0);
        }
    }
}
