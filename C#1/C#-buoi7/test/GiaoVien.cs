using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class GiaoVien
    {
        private string ID;
        string name;
        int tuoi;

        public string ID1 { get => ID; set => ID = value; }
        public string Name { get => name; set => name = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }

        public GiaoVien(string iD, string name, int tuoi)
        {
            this.ID1 = iD;
            this.Name = name;
            this.Tuoi = tuoi;
        }
        public GiaoVien()
        {
            
        }


        public void inra()
        {
            Console.WriteLine($"Giang Vien {name} ma so {ID} tuoi {tuoi}");
        }
            

    }
}
