using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi10
{
    internal class SinhVien
    {
        private string name;
        int age;
        string gender;
        string major;

        public SinhVien()
        {
            
        }

        public SinhVien(string name, int age, string gender, string major)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Major = major;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Major { get => major; set => major = value; }

        public void outPut()
        {
            Console.WriteLine($"Sinh Vien {Name} || Tuoi {Age} || Gioi Tinh {Gender} || Nghanh Hoc {Major}");
        }
    }
}
