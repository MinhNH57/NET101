using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class SamPhan
    {
        private string tenSanPham;
        float giaSanPham;
        float giamGia;

        public SamPhan()
        {
            
        }

        public SamPhan(string tenSanPham, float giaSanPham, float giamGia)
        {
            this.TenSanPham = tenSanPham;
            this.GiaSanPham = giaSanPham;
            this.GiamGia = giamGia;
        }

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public float GiaSanPham { get => giaSanPham; set => giaSanPham = value; }
        public float GiamGia { get => giamGia; set => giamGia = value; }


        public void output()
        {
            Console.WriteLine("San pham {0} || Gia : {1} || Giam Gia : {2}",tenSanPham , GiaSanPham , GiamGia);
        }
    }
}
