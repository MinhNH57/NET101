using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi11
{
    internal class QLGV
    {
        List<GiaoVien> _lstgiaoViens = new List<GiaoVien>();
        public void Add()
        {
            string inPut;
            do
            {
                int n;
                Console.WriteLine("So luong giao vien :");
                n = Convert.ToInt32(Console.ReadLine());
                for(int i = 0; i < n; i++)
                {
                    GiaoVien giaoVien = new GiaoVien();
                    Console.WriteLine("ID :");
                    giaoVien.ID1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ten :");
                    giaoVien.HoTen = Console.ReadLine();
                    Console.WriteLine("So gio day :");
                    giaoVien.SoGioDay=double.Parse(Console.ReadLine());
                    _lstgiaoViens.Add(giaoVien);

                }
                Console.WriteLine("Co tiep tuc hay khong ? 1. Co | 0 . Khong");
                inPut = Console.ReadLine();
            } while (inPut != "0");

        }

        public void inDS()
        {
            foreach(var i  in _lstgiaoViens)
            {
                i.xuat();
            }
        }

        public void xuatdstrongkhoanggio()
        {
            int a; Console.WriteLine("a = "); a = Convert.ToInt32(Console.ReadLine());
            int b; Console.WriteLine("b = "); b = Convert.ToInt32(Console.ReadLine());
            for( int i = 0; i < _lstgiaoViens.Count; i++)
            {
                if (_lstgiaoViens[i].SoGioDay >= a && _lstgiaoViens[i].SoGioDay <= b)
                {
                    _lstgiaoViens[i].xuat();
                }
            }


        }
    }
}
