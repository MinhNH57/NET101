using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace buoi_cuoi
{
    internal class SinhVienPoly:SinhVien
    {
        double diemC;


        public SinhVienPoly()
        {
            
        }

        public SinhVienPoly(string name, string iD, string gender, int namSinh , double diemC) : base(name, iD, gender, namSinh)
        {
            this.DiemC = diemC;
        }

        public double DiemC { get => diemC; set => diemC = value; }

        public override void inThongTin()
        {
            Console.WriteLine($"{Name} || {Gender} || {ID1} || {NamSinh} || {DiemC}");
        }
    }
}
