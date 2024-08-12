using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi10
{
    internal class QLSV
    {
        List<SinhVien> _sinhViens = new List<SinhVien>();

        public void Add()
        {
            int n;
            Console.WriteLine("Moi nhap vao so luong sinh vien : ");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                SinhVien sinhVien = new SinhVien();
                Console.Write("Name :");
                sinhVien.Name = Console.ReadLine();
                Console.Write("Age : ");
                sinhVien.Age = int.Parse(Console.ReadLine());
                Console.Write("Gender :");
                sinhVien.Gender = Console.ReadLine();
                Console.Write("Major :");
                sinhVien.Major = Console.ReadLine();
                _sinhViens.Add(sinhVien);
            }
        }

        public void xuat()
        {
            foreach(var i in _sinhViens)
            {
                i.outPut();
            }
        }

        public void xuat1()
        {
            foreach(var i in _sinhViens)
            {
                if(i.Age >= 20)
                {
                    i.outPut();
                }
            }
        }

        public void lookUp()
        {
            string inPut;
            Console.WriteLine("Xin moi nhap vao nghanh : ");
            inPut = Console.ReadLine();
            for(int i = 0; i < _sinhViens.Count; i++)
            {
                if(inPut.ToLower() == _sinhViens[i].Major.ToLower())
                {
                    _sinhViens[i].outPut();
                }
            }
        }

        public void Delete()
        {
            string inut;
            Console.WriteLine("Xin moi nhap vao nghanh : ");
            inut = Console.ReadLine();
            for (int i = 0; i < _sinhViens.Count; i++)
            {
                if (inut.ToLower() == _sinhViens[i].Name.ToLower())
                {
                    _sinhViens.RemoveAt(i);
                    Console.WriteLine("Xoa thanh cong");
                }
            }
        }

        public void timKiemTheoKhoang()
        {
            int m;
            int n;
            Console.WriteLine("M = ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("N = ");
            n = int.Parse(Console.ReadLine());  
            for(int i = 0; i < _sinhViens.Count;i++)
            {
                if (_sinhViens[i].Age >= m && _sinhViens[i].Age <= n)
                {
                    _sinhViens[i].outPut();
                }
            }
        }
    }
}
/*Xoa duoc tat ca cac ten viet hoa va viet thuong */
/*Tim kiem theo khoang*/