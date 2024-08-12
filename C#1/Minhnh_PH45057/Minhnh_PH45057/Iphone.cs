using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minhnh_PH45057
{
    internal class Iphone:DienThoai
    {
        int boNho;
        string mauSac;

        public Iphone()
        {
            
        }


        public Iphone(string ma, string ten, double gia, int boNho = 0, string mauSac = null) : base(ma, ten, gia)
        {
            this.BoNho = boNho;
            this.MauSac = mauSac;
        }

        public int BoNho { get => boNho; set => boNho = value; }
        public string MauSac { get => mauSac; set => mauSac = value; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"Ten {Ten} || Ma {Ma} || Gia {Gia} || Mau {MauSac} || Bo nho {BoNho}");
        }
    }
}
