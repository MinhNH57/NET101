using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Arraylist : arrlst + Ten = New ArrayList();
             */
            Console.OutputEncoding = Encoding.UTF8;
            ArrayList arrayLst = new ArrayList();
            arrayLst.Add("Math");
            arrayLst.Add("English");
            arrayLst.Add("Csharp");
            arrayLst.Add("PHP");
            foreach (var x in arrayLst)
            {
                Console.Write(x + ",");
            }
            Console.WriteLine();
            /*
             * List : 
             */
            List<string> lstname = new List<string>();
            lstname.Add("Minh");
            lstname.Add("Dung");
            lstname.Add("Yen");
            foreach(var x in lstname)
            {
                Console.WriteLine(x);
            }

            // Truy vấn thông tin của bạn sv "Nga" . LINQ
            var result = lstname.Where(c => c == "Dung");
            Console.WriteLine(string.Join(",",result));

            // c2
            var result1 = from name 
                          in lstname
                          where name =="Dung"
                          select name;
            Console.WriteLine("linq2 " + string.Join(",",result1));

            // inssert : them vao vij tri bat ky 
            lstname.Insert(2, "Quyet");
            foreach (var item in lstname)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
