using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi_cuoi
{
    internal class SinhVien
    {
        string name;
        string ID;
        string gender;
        int namSinh;


        public SinhVien()
        {
            
        }

        public SinhVien(string name, string iD, string gender, int namSinh)
        {
            this.Name = name;
            ID1 = iD;
            this.Gender = gender;
            this.NamSinh = namSinh;
        }

        public string Name { get => name; set => name = value; }
        public string ID1 { get => ID; set => ID = value; }
        public string Gender { get => gender; set => gender = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"{Name} || {ID1} || {Gender}|| {namSinh}");
        }
    }
}
