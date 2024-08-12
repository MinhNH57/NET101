using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi14
{
    internal class ThucVat
    {
        string name;
        double weight;
        string color;

        public ThucVat()
        {
            
        }

        public ThucVat(string name, double weight, string color)
        {
            this.Name = name;
            this.Weight = weight;
            this.Color = color;
        }

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }

        public void inThongTin()
        {
            Console.WriteLine($"Name : {name} || Color : {color} || Weight : {weight}");
        }
    }
}
