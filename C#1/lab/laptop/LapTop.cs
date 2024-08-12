using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    internal class LapTop
    {
        private string name;
        int namSanXuat;
        string mauSac;

        public LapTop()
        {
            
        }

        public LapTop(string name, int namSanXuat, string mauSac)
        {
            this.Name = name;
            this.NamSanXuat = namSanXuat;
            this.MauSac = mauSac;
        }

        public string Name { get => name; set => name = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }

        public void outPut()
        {
            Console.WriteLine($"Hang san xuat : {Name} | Nam san xuat : {NamSanXuat} | Mau sac cua san pham : {MauSac}");
        }
    }
}
