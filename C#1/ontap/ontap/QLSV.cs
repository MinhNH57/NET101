using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ontap
{
    internal class QLSV
    {
        List<SinhVien> _sinhViens = new List<SinhVien>();
        public void Add()
        {
            int n;
            Console.WriteLine("Nhap so luong sinh vien ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                SinhVien Sv = new SinhVien();
                Console.Write("Name  :");
                Sv.Name = Console.ReadLine();
                Console.Write("ID :");
                Sv.ID1 = Console.ReadLine();
                Console.Write("Diem :");
                Sv.Mark = float.Parse(Console.ReadLine());
                _sinhViens.Add(Sv);
            }
        }

        public void outPut()
        {
            foreach(var s in _sinhViens)
            {
                s.inThongTin();
            }
        }

        public void lookingForName()
        {
            string ten;
            Console.WriteLine("Moi nhap ten sinh vie can tim kiem :");
            ten = Console.ReadLine();
            for(int i = 0; i < _sinhViens.Count; i++)
            {
                if(ten.ToLower() == _sinhViens[i].Name.ToLower())
                {
                    _sinhViens[i].inThongTin();
                }
            }
        }

        public void lookingForTitle()
        {
            string inPuttitle;
            Console.WriteLine("Moi nhap hoc luc can tim kiem :");
            inPuttitle = Console.ReadLine();
            for(int i = 0; i < _sinhViens.Count;i++)
            {
                string hocLuc = xepLoai(_sinhViens[i].Mark);
                if(inPuttitle.ToLower() == hocLuc.ToLower())
                {
                    _sinhViens[i].inThongTin();
                }
            }
        }

        private string xepLoai(float mark)
        {
            string hocLuc; 
            if(mark < 5)
            {
                hocLuc = "Yeu";
            }else if(mark <= 6.5)
            {
                hocLuc = "TB";
            }else if(mark < 8)
            {
                hocLuc = "Kha";
            }else if(mark <= 9)
            {
                hocLuc = "Gioi";
            }else
            {
                hocLuc = " Xuat sac";
            }
            return hocLuc;
        }

        public void delete()
        {
            string maSoxoa;
            Console.WriteLine("Moi nhao vao ma so can xoa :");
            maSoxoa = Console.ReadLine();
            for(int i = 0; i < _sinhViens.Count; i++)
            {
                if(maSoxoa.ToLower() == _sinhViens[i].ID1.ToLower() )
                {
                    _sinhViens.RemoveAt(i);
                    i--;
                }
            }
        }

        public void top3()
        {
            var result = _sinhViens.OrderBy(x => x.Mark).ToList();
            for( int i = 0; i < result.Count && i < 2; i++ )
            {
                result[i].inThongTin();
            }
        }

        public void minMark()
        {
            var resault = _sinhViens.OrderByDescending(x => x.Mark).ToList();
            for(int i = 0; i < resault.Count && i <1; i++)
            {
                resault[i].inThongTin();
            }
        }

        public void averageMark()
        {
            float tong = 0;
            int dem = 0;
            for (int i = 0; i < _sinhViens.Count; i++)
            {
                tong += _sinhViens[i].Mark;
                dem++;
            }
            float average = tong / dem;
        }

          

        public void higherThanaverage()
        {
            float tong = 0;
            int dem = 0;
            for (int i = 0; i < _sinhViens.Count; i++)
            {
                tong += _sinhViens[i].Mark;
                dem++;
            }
            float average = tong / dem;
            for (int i = 0; i < _sinhViens.Count; i++)
            {
                if (_sinhViens[i].Mark > average)
                {
                    _sinhViens[i].inThongTin();
                }
            }
        }
    }
}
