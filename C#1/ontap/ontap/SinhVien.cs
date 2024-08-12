using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontap
{
    internal class SinhVien
    {
        string name;
        string ID;
        float mark;

        public SinhVien()
        {
        }

        public SinhVien(string name, string iD, float mark)
        {
            this.Name = name;
            ID1 = iD;
            this.Mark = mark;
        }

        public string Name { get => name; set => name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public float Mark { get => mark; set => mark = value; }

        public void inThongTin()
        {
            Console.WriteLine($"Ho va ten {name} || Ma sinh vien {ID}  || Diem {mark}");
        }
    }
}
