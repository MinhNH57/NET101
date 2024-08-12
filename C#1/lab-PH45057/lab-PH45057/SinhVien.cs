using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_PH45057
{
    internal class SinhVien
    {
        string maSinhVien;
        string hoTen;
        int namSinh;
        double diemTB;

        public SinhVien()
        {
            
        }

        public SinhVien(string maSinhVien, string hoTen, int namSinh, double diemTB)
        {
            this.MaSinhVien = maSinhVien;
            this.HoTen = hoTen;
            this.NamSinh = namSinh;
            this.DiemTB = diemTB;
        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"Sinh Vien {hoTen} || Ma Sinh Vien {maSinhVien} || Nam Sinh {namSinh} || Diem TB {diemTB}");
        }
    }
}
