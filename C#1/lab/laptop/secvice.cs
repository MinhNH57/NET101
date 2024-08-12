using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop
{
    internal class secvice
    {
        List<LapTop> _lstLap = new List<LapTop>();
        public void add()
        {
            int n;
            Console.WriteLine("So luong laptop :");
            n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                LapTop lap = new LapTop();

                Console.WriteLine("Ten : ");
                lap.Name = Console.ReadLine();

                Console.WriteLine("Nam San Xuat :");
                lap.NamSanXuat=int.Parse(Console.ReadLine());

                Console.WriteLine("Mau Sac :");
                lap.MauSac = Console.ReadLine();

                _lstLap.Add(lap);

            }
        }

        public void xuat()
        {
            foreach(var x in _lstLap)
            {
                x.outPut();
            }
        }

      public void xapSep()
        {
            _lstLap.Sort();
            for(int i = 0; i < _lstLap.Count; i++)
            {
                _lstLap[i].outPut();
            }
        }
    }
}
