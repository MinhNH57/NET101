using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH45057_Minhnh
{
    internal class SinhVienPoly:SinhVien
    {
        float diemTB;


        public SinhVienPoly()
        {
            
        }

        public SinhVienPoly(int iD, string name, int namSinh , float diemTB) : base(iD, name, namSinh)
        {
            this.DiemTB = diemTB;
        }

        public float DiemTB { get => diemTB; set => diemTB = value; }

        public override void inThongTin()
        {
            Console.WriteLine($"{Name} || {ID1} || {NamSinh} || {DiemTB} ");
        }
    }
}
