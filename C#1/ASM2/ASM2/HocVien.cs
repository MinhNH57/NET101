using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class HocVien
    {
        private string name;
        float diem;
        string maSo;
        string email;

        public HocVien()
        {
            
        }


        public HocVien(string name, float diem, string maSo , string email)
        {
            this.Name = name;
            this.Diem = diem;
            this.MaSo = maSo;
            this.Email = email;
        }

        public string Name { get => name; set => name = value; }
        public float Diem { get => diem; set => diem = value; }
        public string MaSo { get => maSo; set => maSo = value; }
        public string Email { get => email; set => email = value; }

        public void outPut()
        {
            Console.WriteLine($"Ten {name} || Ma sinh vien {maSo} || Diem {diem} || Email {email}");
        }
    }
}
