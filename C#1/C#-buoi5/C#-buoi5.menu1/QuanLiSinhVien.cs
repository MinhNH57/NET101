using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi5.menu1
{
    internal class QuanLiSinhVien
    {
        List<SinhVien> _sinhVien = new List<SinhVien>();

        public void add()
        {
            int n;
            Console.WriteLine("Moi nhap so luong sinh vien :");
            n=int.Parse(Console.ReadLine());
            SinhVien sv = new SinhVien();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Ten : ");
                sv.Name = Console.ReadLine();
                Console.WriteLine("Tuoi :");
                sv.Tuoi=int.Parse(Console.ReadLine());
                Console.WriteLine("Nganh : ");
                sv.MonHoc = Console.ReadLine();
                _sinhVien.Add(sv);
            }
        }

        public void inDS()
        {
            foreach(var i in _sinhVien)
            {
                i.xuat();
            }
        }
    }
}
