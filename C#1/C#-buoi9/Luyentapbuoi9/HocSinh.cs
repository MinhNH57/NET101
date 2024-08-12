using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luyentapbuoi9
{
    internal class HocSinh
    {
        string hoTen;
        int tuoi;
        float diemTb;

        public HocSinh()
        {
            
        }

        public HocSinh(string hoTen, int tuoi, float diemTb)
        {
            this.HoTen = hoTen;
            this.Tuoi = tuoi;
            this.DiemTb = diemTb;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public float DiemTb { get => diemTb; set => diemTb = value; }

        public void outPut()
        {
            Console.WriteLine($"Hoc sinh {hoTen} || Tuoi {tuoi} || Diem Trung Binh {diemTb}");
        }
    }
}
