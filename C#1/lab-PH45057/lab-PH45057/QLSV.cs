using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_PH45057
{
    internal class QLSV
    {
        List<SinhVien> _lstsinhViens = new List<SinhVien>();

        public void Add()
        {
            string inPut;
            do
            {
                int n;
                Console.WriteLine("Moi nhap so luong sinh vien :");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    SinhVien sv = new SinhVien();
                    Console.WriteLine("Ho Ten : ");
                    sv.HoTen = Console.ReadLine();
                    Console.WriteLine("Ma :");
                    sv.MaSinhVien = Console.ReadLine();
                    Console.WriteLine("Nam Sinh :");
                    sv.NamSinh = int.Parse(Console.ReadLine());
                    Console.WriteLine("Diem :");
                    sv.DiemTB = double.Parse(Console.ReadLine());
                    _lstsinhViens.Add(sv);
                }
                Console.WriteLine("BAn co muon tiep tuc khong : ");
                inPut = Console.ReadLine();
            } while (inPut != "0");
    }

        public void outPut()
        {
            foreach(var i  in _lstsinhViens)
            {
                i.inThongTin();
            }
        }

        public void timKiem()
        {
            for(int a = 0; a < _lstsinhViens.Count; a++)
            {
               
                    if (_lstsinhViens[a].HoTen == "N")
                    {
                        _lstsinhViens[a].inThongTin();
                    }
                
            }
        }

        public bool timKiemTheoTen()
        {
            string name;
            Console.WriteLine("Moi nhap vao ten :");
            name = Console.ReadLine();
            for (int i = 0; i < _lstsinhViens.Count; i++)
            {
                if (name.ToLower() == _lstsinhViens[i].HoTen.ToLower())
                {
                    _lstsinhViens[i].inThongTin();
                    return true;
                }
            }
            return false;

        }

        public void xoa()
        {
            string name1;
            Console.WriteLine("Moi nhap ma sinh vien can xoa :");
            name1 = Console.ReadLine();
            for(int i = 0; i < _lstsinhViens.Count; i++)
            {
                if (_lstsinhViens[i].MaSinhVien.ToLower() == name1.ToLower())
                {
                    _lstsinhViens.RemoveAt(i);
                    i--;
                }
            }
        }

        public void xoanamSinh()
        {

        }
        public void keThua()
        {
            MamNon mamNon = new MamNon();
            mamNon.HoTen = "";
        }
    }
}
