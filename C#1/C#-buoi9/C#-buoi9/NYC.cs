using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi9
{
    internal class NYC
    {
        // Xac dinh doi tuong 
        string name;
        int birdYear;
        int trangThai;
        string address;
        // tao contructor 
        public NYC()
        {
            
        }

        public NYC(string name, int birdYear, int trangThai, string address)
        {
            this.Name = name;
            this.BirdYear = birdYear;
            this.TrangThai = trangThai;
            this.Address = address;
        }

        public string Name { get => name; set => name = value; }
        public int BirdYear { get => birdYear; set => birdYear = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string Address { get => address; set => address = value; }

        // Ouput 
        public void outPut()
        {
            Console.WriteLine($"Ten {name} nam sinh {birdYear} trang thai {trangThai} dia chi {address}");
        }
    }
}
