using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_buoi6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mang - Array
             * Mảng để lưu trữ một tập giá trị cùng tập dữ liệu
             * Mảng ở đây là mảng tĩnh và không co giãn bị giới hạn bởi kích thước 
             * Cách khai báo : Kieu_du_lieu[] ten_mang = {...}
             * index trong mảng bắt đầu từ 0 
             * Cách đặt tên arr+ten_mang
             * 
             */
            int choice;
            do
            {
                Console.WriteLine("1.Chuc nang 1");
                Console.WriteLine("2.Chuc nang 2");
                Console.WriteLine("Moi chon ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        float[] arr1 = { 3, 7.5f , 9, -5, -6 };
                        foreach (var x in arr1)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        // Cach 1 : 
                        int[] arrsoPhong = new int[5];
                        // Cach 2 :
                        float[] arrDiem;
                        arrDiem = new float[5];
                        // Nhap vao diem C#
                        int i; 
                        for (i = 0; i < arrDiem.Length; i++)
                        {
                            Console.WriteLine($" Moi Nhap Phan Tu Thu : {i}");
                            arrDiem[i]=float.Parse(Console.ReadLine());
                        }
                        // In ra mang 
                        foreach ( float item in arrDiem)
                        {
                            Console.Write(item + ",");
                        }
                        Console.WriteLine();
                        // Cach 3 : 
                        string[] arrMonHoc = new string[3] { "C#1", "C#2" , "1" };
                        Console.WriteLine(arrMonHoc[0]);
                        foreach (var y in arrMonHoc)
                        {
                            Console.WriteLine(y);
                        }
                        break;
                    default: Console.WriteLine(); break;
                }
            }
            while (choice != 0);
            Console.ReadKey();
        }
    }
}
