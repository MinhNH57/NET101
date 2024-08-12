using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Xuly
    {
        List<Xuly> _list = new List<Xuly>();
        public void them()
        {
            int n;
            Console.WriteLine(" Nhap so luong san pham :");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                SamPhan sp = new SamPhan();
                Console.WriteLine("Ten sp :");
                sp.TenSanPham=Console.ReadLine();

                Console.WriteLine("Gia sp :");
                sp.GiaSanPham = float.Parse(Console.ReadLine());

                Console.WriteLine("Giam gia ");
                sp.GiamGia = float.Parse(Console.ReadLine());

                _list.Add(sp);
            }
            
        }

    }
}
