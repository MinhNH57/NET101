using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C__buoi9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLiNyc quanLi = new QuanLiNyc();
            int choice;
            do
            {
                Console.WriteLine("Moi chon chuong trinh : ");
                choice=int.Parse(Console.ReadLine());
                Console.WriteLine("1.Them nyc");
                Console.WriteLine("2.In ra danh sach nguoi yeu cu");
                switch(choice)
                {
                    case 0: Console.WriteLine("Thoat"); 
                        break;
                    case 1: Console.WriteLine("1.Them nyc");
                        quanLi.them();
                        break;
                    case 2: Console.WriteLine("2.In danh sach NYC"); 
                        quanLi.inDS();
                        break;

                }
            } while (choice != 0 );
        }
    }
}
