using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi11
{
    internal class GiaoVien
    {
        private string hoTen;
        int ID;
        double soGioDay;

        public GiaoVien()
        {

        }

        public GiaoVien(string hoTen, int iD, double soGioDay)
        {
            this.HoTen = hoTen;
            ID1 = iD;
            this.SoGioDay = soGioDay;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public int ID1 { get => ID; set => ID = value; }
        public double SoGioDay { get => soGioDay; set => soGioDay = value; }

        public void xuat()
        {
            Console.WriteLine($"ID {ID} || Ho ten {hoTen} || So gio day {soGioDay}");
        }
    }
}
