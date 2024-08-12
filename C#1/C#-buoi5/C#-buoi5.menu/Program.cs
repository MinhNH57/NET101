using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi5.menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;
            do
            {
                Console.Write("Choice: ");
                choice=int.Parse(Console.ReadLine());
                Console.WriteLine("1.Thịt Bò Mỹ");
                Console.WriteLine("2.Cua Hoàng Đế");
                Console.WriteLine("3.Nước uống lúa mạch");
                Console.WriteLine("4.Hoa quả");
                Console.WriteLine("0.Thoát");
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1.Thịt Bò Mỹ");
                        int choice1;
                        Console.WriteLine("Choice1: ");
                        choice1=int.Parse(Console.ReadLine());
                        switch (choice1)
                        {
                            case 01:
                                Console.WriteLine("My Tho");
                                break;
                            case 02:
                                Console.WriteLine("My dinh");
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("2.Cua Hoàng Đế");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("3.Nước uống lúa mạch");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("4.Hoa quả");
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("0.Thoát");
                        Console.WriteLine();
                        break;
                    default: Console.WriteLine("Xin moi nhap lai"); break;
                   
                }
            } while (choice != 0 );
        }
    }
}
