using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi7
{
    // 1.Xác định đối tượng 
    internal class SinhVien
    {
        /*
         * 2.Liệt kê các thuộc tính cuả SinhVien 
         * Ten , GioiTinh , NghanhHoc 
         */
        private string ten;
        int GioiTinh;
        string NghanhHoc;
        // 3. Contructor : khong co tham so va co tham so 
        // Contructor khong tham so : ctor + tab tab 
        public SinhVien()
        {

        }

        public SinhVien(string ten, int gioiTinh, string nghanhHoc)
        {
            this.Ten = ten;
            this.GioiTinh1 = gioiTinh;
            this.NghanhHoc1 = nghanhHoc;
        }
        // Contructor co tham so 
        /*
         * 1. Click vao doi tuong roi kich chuot phai chon quickActions 
         * 2 . Tich chon Gennerate Contructor 
         * This tham chieu den doi tuong hien tai 
         */
        // 4. Property : có hai phương thức : get và set 
        /*
         * b1 : boi den cac thuoc tinh 
         * b2 : chon quickActions 
         * Chon and use property 
         */
        public string Ten { get => ten; set => ten = value; }
        public int GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string NghanhHoc1 { get => NghanhHoc; set => NghanhHoc = value; }
        //5. In ra thông tin 
        public void inRaManHinh()
        {
            Console.WriteLine($"Chào {ten} | {(GioiTinh == 1 ? "Nam" : "Nu")} | {NghanhHoc1}" );
        }
      

    }
}
