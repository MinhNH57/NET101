using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QLNV
    {
        List<NhanVien> _lstNv = new List<NhanVien>();
        public void Add()
        {
            int n; Console.WriteLine("Nhap so luong nhan vien : "); n = int .Parse(Console.ReadLine()); 
            for(int i = 0; i < n; i++)
            {
                NhanVien nV = new NhanVien();
                Console.Write("Ho va Ten :");
                nV.Name = Console.ReadLine();
                Console.Write("Tuoi :");
                nV.Age = int.Parse( Console.ReadLine());
                Console.Write("Phong ban :");
                nV.Room = Console.ReadLine();
                Console.Write("Hometown :");
                nV.Hometown = Console.ReadLine();
                _lstNv.Add(nV);
            }
        }

        public void xuat()
        {
            foreach(var i in _lstNv)
            {
                i.outPut();
            }
        }

        public void xuat1()
        {
            foreach(var i in _lstNv)
            {
                if (i.Age >= 50)
                {
                    i.outPut();
                }
            }
        }

        public void delete()
        {
            string inPut;
            Console.WriteLine("Xin moi nhap vao phong - ban :");
            inPut = Console.ReadLine();
            for(int a = 0;  a < _lstNv.Count; a++)
            {
                if(inPut.ToLower() == _lstNv[a].Room.ToLower())
                {
                    _lstNv.RemoveAt(a);
                    Console.WriteLine("Xoa thanh cong");
                }
            }
        }

        public void timKiemTheoKhoang()
        {
            int a; Console.WriteLine("a = "); a = int.Parse( Console.ReadLine());
            int b; Console.WriteLine("b ="); b = int.Parse( Console.ReadLine());
            for(int i = 0 ; i < _lstNv.Count; i++)
            {
                if(_lstNv[i].Age < b && _lstNv[i].Age > a)
                {
                    _lstNv[i].outPut();
                }
            }
        }
    }
}
