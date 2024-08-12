using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class XuLyMang
    {
        public void xuLymang() 
        {
           ArrayList arrLst = new ArrayList();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nhap so nguyen thu {0}",i+1);
                int st = int.Parse(Console.ReadLine());
                arrLst.Add(st);
            }

            Console.WriteLine("Day :");

            foreach (int i in arrLst)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            arrLst.Sort();
            Console.WriteLine("Day sau khi sap xep la :");
            foreach (int i in arrLst)
            {
                Console.Write(i + " ");
            }
        }

    }
}
