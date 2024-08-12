using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HocSinh
    {
        string ten;
        int tuoi;

        public HocSinh()
        {
            
        }

        public HocSinh(string ten, int tuoi)
        {
            this.Ten = ten;
            this.Tuoi = tuoi;
        }

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public void xuat()
        {
            Console.WriteLine($"Ho va ten : {ten} || Tuoi {tuoi}");
        }
    }
}
