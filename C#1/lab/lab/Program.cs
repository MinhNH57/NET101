using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1.Giai PT bac nhat ");
                Console.WriteLine("2.Giai PT bac hai ");
                Console.WriteLine("3.Kiem tra ngay thang ");
                Console.WriteLine("4.Kiem tra so nguyen to  ");
                Console.WriteLine("5.Xuat ra bang cuu chuong ");
                Console.WriteLine("0.Thoat");
                Console.WriteLine("Chon chuong trinh: ");
                choice=int.Parse(Console.ReadLine());  

                switch (choice)
                {
                    case 1 :
                        float a;
                        Console.Write("a = "); a = float.Parse(Console.ReadLine());
                        float b;
                        Console.Write("b = "); b = float.Parse(Console.ReadLine());
                        float x;
                        x = -b / a;
                        Console.WriteLine(x);
                        break;
                    case 2 :
                        float a1, b1, c;
                        Console.Write("a1 = "); a1 = float.Parse(Console.ReadLine());
                        Console.Write("b1 = "); b1 = float.Parse(Console.ReadLine());
                        Console.Write("c = "); c = float.Parse(Console.ReadLine());
                        float denta;
                        denta = (b1 * b1) - (4 * a1 * c);
                        Console.WriteLine($"Deta = {denta}");
                        if(denta < 0)
                        {
                            Console.WriteLine("PT Vo Nghiem");
                        }else if (denta > 0)
                        {
                            float x1 = (float)(-b1 + Math.Sqrt(denta)) / 2 * a1;
                            float x2 = (float)(-b1 - Math.Sqrt(denta)) / 2 * a1;
                            Console.WriteLine("x1 ={0} va x2 = {1}" , x1 , x2);
                        }
                        break;
                    case 3 :
                        int day; Console.WriteLine("Day = "); day = int.Parse(Console.ReadLine());
                        int month; Console.WriteLine("Month = "); month = int.Parse(Console.ReadLine());
                        int year; Console.WriteLine("Year = "); year = int.Parse(Console.ReadLine());
                        List<int> lstDay = new List<int>() {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31 };
                        List<int> lstMonth = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
                        foreach(int i  in lstDay)
                        {
                            if(i == day)
                            {
                                Console.WriteLine("Ngay nay hop le");
                                break;
                            }
                        }
                        foreach(int i in lstMonth)
                        {
                            if(i == month)
                            {
                                Console.WriteLine("Thang hop le");
                            }
                        }

                        if(month == 1 || month == 3 || month == 5 || month==7||month==8||month==10||month==12){
                            Console.WriteLine("Thang nhap vao co 31 ngay");
                        }else if(month==2 && year % 4==0 && year % 100 == 0) 
                        {
                            Console.WriteLine("Thang nhao vao co 29 ngay");
                        }else
                        {
                            Console.WriteLine("Thang nhap vao co 30 ngay");
                        }
                        break;
                    case 4 :
                        int n;
                        Console.WriteLine("n= ");
                        n = int.Parse(Console.ReadLine());
                        int dem = 0;
                        for(int i = 1 ; i <= n; i++)
                        {
                            if(n % i == 0)
                            {
                                dem++;
                            }

                        }
                        if (dem > 0)
                        {
                            Console.WriteLine("n la so nguyen to");
                        }
                        break;
                    case 5 :
                        for(int i = 1 ; i <= 9; i++)
                        {
                            for(int j = 1; j <= 10; j++)
                            {
                                Console.WriteLine($"{i}*{j}={i*j}");
                            }
                        }
                        break;
                    case 0 :
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Moi nhap lai");
                        break; 
                }

            } while (choice != 0);
            Console.ReadLine();
        }
    }
}
