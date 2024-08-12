using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            List<string> lstname = new List<string>();
            List<int> lstage = new List<int>();

            for(int a = 0; a <= 3 ; a++)
            {
                Console.WriteLine("Name : ");
                name = Console.ReadLine();
                lstname.Add(name);
                Console.WriteLine("Age : ");
                age = int.Parse(Console.ReadLine());
                lstage.Add(age);
            }
     
            foreach (string s in lstname)
            {
                Console.WriteLine(s);
            }

            foreach (int i in lstage)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
