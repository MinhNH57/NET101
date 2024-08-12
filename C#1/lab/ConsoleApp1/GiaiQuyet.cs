using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GiaiQuyet
    {
        public void giaiQuyet()
        {
            string[] arrName = new string[5] ;
            float[] arrDiem = new float[5] ;

            for(int i = 0;  i < arrName.Length; i++)
            {
                Console.WriteLine("Ho ten cua sinh vien thu {0} : ",i);
                arrName[i] = Console.ReadLine();
                Console.WriteLine("Diem cua sinh vien {0} la :", arrName[i]);
                arrDiem[i] = float.Parse(Console.ReadLine()) ;
            }
            for(int i = 0;i < arrDiem.Length; i++)
            {
                string hocLuc = XepLoai(arrDiem[i]);
                Console.WriteLine($"Sinh Vien {arrName[i]} co so diem la {arrDiem[i]} xep loai {hocLuc}");
            }

            for(int i = 0; i < arrName.Length - 1 ; i++)
            {
                for(int j = i +1; j < arrDiem.Length; j++)
                {
                    if (arrDiem[i] < arrDiem[j])
                    {
                        float temp = arrDiem[i];
                        arrDiem[i] = arrDiem[j];
                        arrDiem[j] = temp; 

                        string st = arrName[i];
                        arrName[i] = arrName[j];
                        arrName[j] = arrName[i];
                    }
                    
                }
            }
            for (int i = 0; i < arrDiem.Length; i++)
            {
                string hocLuc = XepLoai(arrDiem[i]);
                Console.WriteLine($"Sinh Vien {arrName[i]} co so diem la {arrDiem[i]} xep loai {hocLuc}");
            }

        }
        private string XepLoai(float diem)
        {
            string hocLuc;
            if(diem < 5)
            {
                hocLuc = "Fail";
            }else
            {
                hocLuc = "Pass";
            }
            return hocLuc;
        }
        
    }
}
