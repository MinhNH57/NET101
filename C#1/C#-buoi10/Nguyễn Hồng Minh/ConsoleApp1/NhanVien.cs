using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NhanVien
    {
        private string name;
        int age;
        string room;
        string hometown;

        public NhanVien()
        {
            Name = "No";
            Age = 0;
            Room = "No";
            Hometown = "No";
        }

        public NhanVien(string name, int age, string room, string hometown)
        {
            this.Name = name;
            this.Age = age;
            this.Room = room;
            this.Hometown = hometown;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Room { get => room; set => room = value; }
        public string Hometown { get => hometown; set => hometown = value; }

        public void outPut()
        {
            Console.WriteLine($"Nhan Vien {name} || Tuoi {age} || Phong {room} || Que Quan {hometown}");
        }
    }
}
