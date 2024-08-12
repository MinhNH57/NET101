using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH45057_Minhnh
{
    internal class SinhVien
    {
        int ID;
        string name;
        int namSinh;

        public SinhVien()
        {
            
        }

        public SinhVien(int iD, string name, int namSinh)
        {
            ID1 = iD;
            this.Name = name;
            this.NamSinh = namSinh;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"{Name} || {ID1} || {namSinh} ");
        }
    }
}
