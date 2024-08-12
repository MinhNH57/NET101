using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class QLHV
    {
        List<HocVien> _hocViens = new List<HocVien>();
        public void Add()
        {
            int inPut;
            do {
                int n; Console.WriteLine("So hoc vien :"); n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    HocVien hocVien = new HocVien();
                    Console.Write("Ten :");
                    hocVien.Name = Console.ReadLine();
                    Console.Write("Ma so :");
                    hocVien.MaSo = Console.ReadLine();
                    Console.Write("Diem :");
                    hocVien.Diem = float.Parse(Console.ReadLine());
                    Console.WriteLine("Email :");
                    hocVien.Email = Console.ReadLine();
                    _hocViens.Add(hocVien);
                }
                Console.WriteLine("Ban co muon tipe tuc khong ?");
                inPut = int.Parse(Console.ReadLine());
            } while(inPut != 0);
            }

        public void xuat()
        {
            foreach(var i in _hocViens)
            {
                i.outPut();
            }
        }

        public void timkiemtheodiem()
        {
            float m;
            float n;
            Console.WriteLine("M = ");
            m = float.Parse(Console.ReadLine());
            Console.WriteLine("N = ");
            n = float.Parse(Console.ReadLine());
            for (int i = 0; i < _hocViens.Count; i++)
            {
                if (_hocViens[i].Diem >= m && _hocViens[i].Diem <= n)
                {
                    _hocViens[i].outPut();
                }
            }
        }

        public void timkiemtheohocluc()
        {
            string inputHL;
            Console.WriteLine("Moi nhap vao hoc luc van tim :");
            inputHL = Console.ReadLine();
            for (int i = 0; i < _hocViens.Count; i++)
            {
                string hocLuc = xepLoai(_hocViens[i].Diem);
               // Console.WriteLine($"{_hocViens[i].Name} || Ma sinh Vien {_hocViens[i].MaSo} || Email {_hocViens[i].Email} || Diem {_hocViens[i].Diem} || Hoc Luc {hocLuc}");
               if(inputHL.Normalize()== hocLuc.Normalize())
                {
                    _hocViens[i].outPut();
                }
            }

            
        }

        private string xepLoai(float diem)
        {
            string hocLuc;
            if (diem < 5)
            {
                hocLuc = "Yeu";
            }else if(diem <= 6.5)
            {
                hocLuc = "TB";
            }else if(diem < 8)
            {
                hocLuc = "Kha";
            }
            else if(diem <= 9.5)
            {
                hocLuc = "Gioi";
            }
            else
            {
                hocLuc = "Xuat sac";
            }
            
            return hocLuc;
        }

        public void timkiemtheomaso()
        {
            string Mso; Console.WriteLine("Xin moi nhapo vao ma so :"); Mso = Console.ReadLine();
            for ( int i = 0; i < _hocViens.Count; i++)
            {
                if (_hocViens[i].MaSo.ToLower() == Mso.ToLower())
                {
                    Console.WriteLine("Hoc vien co ma so {0} la   ",Mso);
                    _hocViens[i].outPut();
                }
            }
        }

        public void sapxeptheodiem()
        {
            for(int i = 0  ; i < _hocViens.Count - 1;i++)
            {
                for(int j = i + 1;  j < _hocViens.Count; j++)
                {
                    if (_hocViens[i].Diem < _hocViens[j].Diem)
                    {
                        float temp = _hocViens[i].Diem;
                        _hocViens[i].Diem = _hocViens[j].Diem;
                        _hocViens[j].Diem = temp;

                        string st = _hocViens[i].Name;
                        _hocViens[i].Name = _hocViens[j].Name;
                        _hocViens[j].Name = st;
                    }
                }
            }
           
                foreach (var i in _hocViens)
                {
                    i.outPut();
                }
            
        }

        public void top5()
        {
            for (int i = 0; i < _hocViens.Count - 1; i++)
            {
                for (int j = i + 1; j < _hocViens.Count; j++)
                {
                    if (_hocViens[i].Diem < _hocViens[j].Diem)
                    {
                        float temp = _hocViens[i].Diem;
                        _hocViens[i].Diem = _hocViens[j].Diem;
                        _hocViens[j].Diem = temp;

                        string st = _hocViens[i].Name;
                        _hocViens[i].Name = _hocViens[j].Name;
                        _hocViens[j].Name = st;
                    }
                }
            }
            Console.WriteLine("Top 5 Sinh Vien Co Diem Cao Nhat :");
            for (int a = 0; a < _hocViens.Count && a < 5; a++)
            {
                _hocViens[a].outPut();
            }

        }

        public void diemTB()
        {

            double tong = 0 ;
            int dem = 0 ; 
            for(int i = 0; i < _hocViens.Count; i++)
            {
                tong += _hocViens[i].Diem;
                dem++;
            }

            double tb = tong / (double)dem;
            Console.WriteLine($"Diem trung binh la : {tb}");
        }

        public void sinhviencodiemtbcaonhatlop()
        {
            double tong = 0;
            int dem = 0;
            for (int i = 0; i < _hocViens.Count; i++)
            {
                tong += _hocViens[i].Diem;
                dem++;
            }

            double tb = tong / (double)dem;
            for (int i = 0; i < _hocViens.Count;i++)
            {
                if (_hocViens[i].Diem > tb )
                {
                    _hocViens[i].outPut();
                }
            }
        }

        public void tonghop()
        {
            for(int i = 0; i < _hocViens.Count; i++)
            {
                if (_hocViens[i].Diem < 5 )
                {
                    Console.WriteLine("Sinh Vien Hoc Luc Yeu La :");
                    _hocViens[i].outPut();
                }else if (_hocViens[i].Diem <= 8) {
                    Console.WriteLine("Sinh Vien Hoc Luc Kha La :");
                    _hocViens[i].outPut();
                }
                else if (_hocViens[i].Diem <= 10) {
                    Console.WriteLine("Sinh Vien Co Hoc Luc Gioi La :");
                    _hocViens[i].outPut();
                }
            }
        }
      
    }
}
