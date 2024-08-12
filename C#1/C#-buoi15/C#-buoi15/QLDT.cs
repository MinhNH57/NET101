using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi15
{
    internal class QLDT
    {
        List<DienThoai> _lstPhone = new List<DienThoai>();

        public void Add()
        {
            int inPut;
            do

            {
                int n;
                Console.WriteLine("Moi nhap vao so luong :");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    DienThoai phone = new DienThoai();
                    Console.WriteLine("Ten :");
                    phone.Ten = Console.ReadLine();
                    Console.WriteLine("Ma :");
                    phone.Ma = Console.ReadLine();
                    Console.WriteLine("Gia :");
                    phone.Gia = double.Parse(Console.ReadLine());
                    _lstPhone.Add(phone);
                }
                Console.WriteLine("Ban co muon tiep tuc khong ?");
                inPut = int.Parse(Console.ReadLine());
            } while (inPut != 0);
        }

        public void outPut()
        {
            foreach (var i in _lstPhone)
            {
                i.inThongTin();
            }
        }

        public void timKiemma()
        {
            string maDienThoai;
            Console.WriteLine("Nhap ma :");
            maDienThoai = Console.ReadLine();
            for (int i = 0; i < _lstPhone.Count; i++)
            {
                if (_lstPhone[i].Ma.ToLower() == maDienThoai.ToLower())
                {
                    _lstPhone[i].inThongTin();
                }
            }
        }

        public void top3()
        {
            var result = _lstPhone.OrderBy(a => a.Gia).ToList();
            for (int i = 0; i < result.Count && i < 3; i++)
            {
                result[i].inThongTin();

            }

        }

        public void xoa()
        {
            string maDienThoai;
            Console.WriteLine("Moi nhap :");
            maDienThoai = Console.ReadLine();
            for (int i = 0; i < _lstPhone.Count; i++)
            {
                if (_lstPhone[i].Ma.ToLower() == maDienThoai.ToLower())
                {
                    _lstPhone.RemoveAt(i);
                    i--;
                }
            }
           foreach(var items in _lstPhone)
            {
                items.inThongTin();
            }
        }

        public void keThua()
        {
            Iphone iphone = new Iphone();

        }
        
    }
}
