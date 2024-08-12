using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH45057_Minhnh
{
    internal class Service
    {
        List<SinhVien> _lstSv = new List<SinhVien>();
        public void add()
        {
            int input; do {
                int n;
                Console.WriteLine("Moi nhao vao so luong sinh vien :");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    SinhVien sinhVien = new SinhVien();
                    Console.WriteLine("Ho va Ten :");
                    sinhVien.Name = Console.ReadLine();
                    Console.WriteLine("ID :");
                    sinhVien.ID1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nam sinh :");
                    sinhVien.NamSinh = int.Parse(Console.ReadLine());
                    _lstSv.Add(sinhVien);
                }
                Console.WriteLine("Ban co muon tiep tuc khong ? 1 - co || 0 - Khong");
                input = int.Parse(Console.ReadLine());
            } while(input != 0);
        }
        public void xuat()
        {
            foreach(var i in _lstSv)
            {
                i.inThongTin();
            }
        }



        public void xuat30()
        {
            int namHienTai;
            Console.WriteLine("Moi nhap vao nam hien tai :");
            namHienTai = int.Parse(Console.ReadLine());
            int tuoi;
            for (int i = 0; i < _lstSv.Count; i++)
            {
                tuoi = namHienTai - _lstSv[i].NamSinh;
                if (tuoi > 30)
                {
                    _lstSv[i].inThongTin();
                }
            }


        }

        public void sapxepID()
        {
            var result = _lstSv.OrderBy(x => x.ID1).ToList();
            for(int i = 0; i < result.Count; i++)
            {
                result[i].inThongTin();
            }
        }

        public void kethua()
        {
            SinhVienPoly polyer1 = new SinhVienPoly(24 , "Minh", 2004 , 9.8f);
            polyer1.inThongTin();
        }
    }
}
