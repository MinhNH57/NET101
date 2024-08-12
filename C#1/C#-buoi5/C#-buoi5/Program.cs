using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. While va Do - while
             * 2. Cach xay dung menu
             */
            //int a = 2; 
            //while (a <= 9)
            //{
            //    for(int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine($"{a} x {i} = {a*i}");
            //    }
            //    Console.WriteLine();
            //    a++; 
            //}

            int b = 100; 
            while (b >= 1)
            {
                Console.Write(b + " ");
                b--;
            }
            Console.ReadKey();
        }
    }
}
