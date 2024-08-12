using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xoasinhvien
{
    internal class Do
    {
        List<Student> list=new List<Student>();

        public void Add()
        {
            Student student = new Student();
            Console.WriteLine("Name ");
            student.Name = Console.ReadLine();
            Console.WriteLine("ID ");
            student.ID1 = int.Parse(Console.ReadLine());
            list.Add(student);
        }

        public void xuat()
        {
            foreach(var student in list)
            {
                student.outPut();
            }
        }

        public void xoa()
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].ID1 % 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
