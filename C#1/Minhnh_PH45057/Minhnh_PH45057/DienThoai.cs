using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnh_PH45057
{
    internal class DienThoai
    {
        string ma;
        string ten;
        double gia;


        public DienThoai()
        {
            
        }

        public DienThoai(string ma, string ten, double gia)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Gia = gia;
        }

        public string Ma { get => ma; set => ma = value; }
        public string Ten { get => ten; set => ten = value; }
        public double Gia { get => gia; set => gia = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"Dien Thoai {ten} || Ma {ma} || Gia {gia}");
        }
    }
}
