using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi9
{
    internal class QuanLiNyc
    {
        // quan li cac chuc nang : 
        List<NYC> _lstNyc = new List<NYC>();
        public void them()
        {
            // Them nhieu doi tuong , TAO DOI TUONG
            int n;
            Console.WriteLine("Moi nhap so luong nyc : ");
            n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                NYC nYC = new NYC();
                Console.WriteLine("Ten :");
                nYC.Name = Console.ReadLine();
                Console.WriteLine("Nam Sinh :");
                nYC.BirdYear = int.Parse(Console.ReadLine());
                Console.WriteLine("Trang Thai");
                nYC.TrangThai = int.Parse(Console.ReadLine());
                Console.WriteLine("Dia Chi :");
                nYC.Address = Console.ReadLine();
                _lstNyc.Add(nYC);
            }
        }
            

        public void inDS()
        {
            foreach(var nYC in _lstNyc)

            {
                nYC.outPut();
            }
        }
    }
}
