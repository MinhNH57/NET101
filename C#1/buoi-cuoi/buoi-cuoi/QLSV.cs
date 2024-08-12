using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_cuoi
{
    internal class QLSV
    {
       List<SinhVien> _lstSV = new List<SinhVien>();
        public void Add()
        {
            int kon;
            do
            {
                int n;
                Console.WriteLine("Moi nhap so luong sinh vien :");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    SinhVien sinhVien = new SinhVien();
                    Console.WriteLine("Ten :");
                    sinhVien.Name = Console.ReadLine();
                    Console.WriteLine("ID :");
                    sinhVien.ID1 = Console.ReadLine();
                    Console.WriteLine("Gioi tinh :");
                    sinhVien.Gender = Console.ReadLine();
                    Console.WriteLine("Nam sinh:");
                    sinhVien.NamSinh = int.Parse(Console.ReadLine());
                    _lstSV.Add(sinhVien);
                }
                Console.WriteLine("Ban co muon tiep tuc khong :");
                kon = int.Parse(Console.ReadLine());
            } while (kon != 0);
        }

        public void xuat()
        {
            foreach(var i in _lstSV)
            {
                i.inThongTin();
            }
        }

        private int Tuoi(int namHienTai, int namSinh)
        {
            Console.WriteLine("Moi nhap vao nam hien tai :");
            namHienTai = int.Parse(Console.ReadLine());
            int tuoi = namHienTai - namSinh;
            return tuoi;
        }
        public void xuat18()
        {
            for(int i = 0; i <  _lstSV.Count; i++)
            {
                int age = Tuoi(2023 , _lstSV[i].NamSinh);
                if(age > 18)
                {
                    _lstSV[i].inThongTin();
                }
            }
        }
        //public void xuattren18()
        //{
        //    int tuoi; 
        //    int namHienTai;
        //    Console.WriteLine("Moi nhao nam hien tai :");
        //    namHienTai = int.Parse(Console.ReadLine());
        //    for (int i = 0; i <  _lstSV.Count; i++)
        //    {
        //        tuoi = namHienTai - _lstSV[i].NamSinh;
        //        if( tuoi > 18)
        //        {
        //            _lstSV[i].inThongTin();
        //        }
        //    }
        //}

        public void sapxep()
        {
            var kq = _lstSV.OrderByDescending(x => x.Name).ToList();
            for(int i = 0; i < kq.Count; i++)
            {
                kq[i].inThongTin();
            }
           
        }

        public void timKiem()
        {
            for(int i = 0; i < _lstSV.Count; i++)
            {
                if (_lstSV[i].Name.Contains('a')|| _lstSV[i].Name.Contains('A'))
                {
                    _lstSV[i].inThongTin();
                }
            }
        }

        public void keThua()
        {
            SinhVienPoly sinhVienPoly = new SinhVienPoly("Minh" , "Nam" , "PH45057" , 2004 , 9.9);
            sinhVienPoly.inThongTin();
        }
    }
}
