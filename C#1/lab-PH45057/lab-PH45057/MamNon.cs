using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_PH45057
{
    internal class MamNon:SinhVien
    {
        // Chỉ có đơn kế thừa 
        string uocMo;
        public MamNon()
        {
            
        }

        public MamNon(string maSinhVien, string hoTen, int namSinh, double diemTB, string uocMo) : base(maSinhVien, hoTen, namSinh, diemTB)
        {
            this.UocMo = uocMo;
        }

        public string UocMo { get => uocMo; set => uocMo = value; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"{MaSinhVien} || {HoTen} || {NamSinh} || {DiemTB} || {uocMo}");
        }
    }
}
