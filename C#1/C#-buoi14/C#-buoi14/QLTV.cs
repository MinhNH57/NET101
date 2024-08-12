using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi14
{
    internal class QLTV
    {
        List<ThucVat> _lstthucVat = new List<ThucVat>();
        public void Add()
        {
            int inPut;
            do
            {
                int n;
                Console.WriteLine("So luong thuc vat : ");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    ThucVat thucVat = new ThucVat();
                    Console.WriteLine("Name : ");
                    thucVat.Name = Console.ReadLine();
                    Console.WriteLine("Weight :");
                    thucVat.Weight = double.Parse(Console.ReadLine());
                    Console.WriteLine("Color :");
                    thucVat.Color = Console.ReadLine();
                    _lstthucVat.Add(thucVat);
                }
                Console.WriteLine("Ban co muon tipe tuc khong ?");
                inPut = int.Parse(Console.ReadLine());

            } while(inPut != 0);
            }

        public void outPut()
        {
            foreach(var a in _lstthucVat)
            {
                a.inThongTin();
            }
        }

        public void sapXep()
        {
            // Xuat ra hai so nho nhat 
           var result = _lstthucVat.OrderBy(a => a.Weight).ToList();
            for(int i = 0; i < result.Count && i < 2; i++)
            {
                result[i].inThongTin();
            }
        }

        public void sapXepTangDan()
        {
            var result = _lstthucVat.OrderByDescending(a => a.Weight).ToList();
            for (int i = 0; i < result.Count && i < 2; i++)
            {
                result[i].inThongTin();
            }
        }
    }
}
