using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xoasinhvien
{
    internal class Student
    {
        string name;
        int ID;


        public Student()
        {
            
        }

        public Student(string name, int iD)
        {
            this.Name = name;
            this.ID1 = ID;
        }

        public string Name { get => name; set => name = value; }
        public int ID1 { get => ID; set => ID = value; }

        public void outPut()
        {
            Console.WriteLine($"Name {name} || ID {ID}");
        }
    }
}
