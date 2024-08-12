using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Lập trình hướng đối tượng . 
             * Đối tượng(Danh Từ ) : SinhVien , GiaoVien , ....
             * Cách đặt tên : PasscalCase  Vd : SinhVien , BoMe , GiaoVien ;
             * Thuộc tính : tên , giới tính , tuổi , nghành học ,...
             * Hành động : ăn , ngủ , chơi game , 
             * Bốn tính chất của OOP 
             * 1) Tính đóng gói : Riêng tư , công khai , bảo vệ .... 
             * 2) Tính kế thừa : 
             * 3) Tính đa hình : 
             * 4) Tính trừu tượng : 
             */
            // Muốn sử dụng đối tượng phải tạo đối tượng 
            // Tao doi tuong khong tham so 
            SinhVien sv1 = new SinhVien();
            sv1.Ten = "Minh";
            sv1.GioiTinh1 = 1;
            sv1.NghanhHoc1 = "PTPM";
            sv1.inRaManHinh();
            // Tao doi tuong co tham so 
            SinhVien sv2 = new SinhVien("Dung" , 0 , "Noi tro");
            sv2.inRaManHinh();

            SinhVien sv3 = new SinhVien("Hai Yen", 0, "Kinh Ke");
            sv3.inRaManHinh();

            SinhVien sv4 = new SinhVien();
            sv4.Ten = "Ly";
            sv4.NghanhHoc1 = "Ke Toan";
            sv4.inRaManHinh();

            Console.ReadKey();
        }
    }
}
