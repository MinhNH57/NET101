using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            cat1.PetName = "Chessse";
            cat1.PetAge = 2;
            cat1.PetColor = "Yellow";
            cat1.outPut();

            //

            Cat cat2 = new Cat();
            cat2.PetName = "Chill";
            cat2.PetAge = 1;
            cat2.PetColor = "White";
            cat2.outPut();

            //

            Cat cat3 = new Cat("Lucci" , 1 , "black");
            cat3.outPut();

            Console.ReadLine();
        }
    }
}
