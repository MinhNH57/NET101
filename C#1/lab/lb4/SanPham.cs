using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb4
{
    internal class SanPham
    {
        public string tenSanPham;
        public float giaSanPham;
        public float giamGia;

        public void nhap()
        {
            Console.WriteLine("Ten Sp :");
            tenSanPham = Console.ReadLine();

            Console.WriteLine("Gia :");
            string st = Console.ReadLine();
            giaSanPham=float.Parse(st);

            Console.WriteLine("Giam gia ");
            st = Console.ReadLine();
            giamGia=float.Parse(st);

        }

        public void xuat()
        {
            Console.WriteLine("San Pham {0} co gia la {1} va thue nhap khau la {2}",tenSanPham,giaSanPham,thueNhapKhau());
        }

        private float thueNhapKhau()
        {
            return (float)(giaSanPham * 0.1);
        }
    }
}
