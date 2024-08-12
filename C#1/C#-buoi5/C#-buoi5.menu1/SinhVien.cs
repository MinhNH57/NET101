using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi5.menu1
{
    internal class SinhVien
    {
        string name;
        string monHoc;
        int tuoi;

        public SinhVien()
        {
            
        }

        public SinhVien(string name, string monHoc, int tuoi)
        {
            this.Name = name;
            this.MonHoc = monHoc;
            this.Tuoi = tuoi;
        }

        public string Name { get => name; set => name = value; }
        public string MonHoc { get => monHoc; set => monHoc = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }


        public void xuat()
        {
            Console.WriteLine($"Ten : {name} || Nghanh {monHoc} || Tuoi {tuoi}");
        }
    }
}
