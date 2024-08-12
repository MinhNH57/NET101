using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Cat
    {
        private string petName;
        int petAge;
        string petColor;

        public string PetName { get => petName; set => petName = value; }
        public int PetAge { get => petAge; set => petAge = value; }
        public string PetColor { get => petColor; set => petColor = value; }

        public Cat(string petName, int petAge, string petColor)
        {
            this.PetName = petName;
            this.PetAge = petAge;
            this.PetColor = petColor;
        }

        public Cat()
        {
            
        }

        public void outPut()
        {
            Console.WriteLine($"Name : {petName} - Age : {PetAge} - Color : {petColor}");
        }
    }


}
