using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__luyentapvemenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Xây dựng menu chương trình gồm các chức năng sau 
            // 1. Chương trình tính điểm trug bình 
            // 2. Chương trình xét hạnh kiểm 
            // 3. Chương trình tính tổg các số lẻ từ 1 - n 
            // 4. Chương trình xuất các cố từ 100 đến 1 
            // 5. Thoát 
            int choice;
            do
            {
                Console.WriteLine("1.Chương trình tính điểm trung bình ");
                Console.WriteLine("2.Chương trình xét hạnh kiểm ");
                Console.WriteLine("3.Chương trình tính tổng các số lẻ từ 1 đến n");
                Console.WriteLine("4.Chương trình xuất các số từ 100 đến 1 ");
                Console.WriteLine("0.Thoát chương trình ");
                Console.Write("Mời nhập chương trình : ");
                choice = int.Parse(Console.ReadLine());
                Console.Write("Chương trình bạn đã chọn là : ");

                switch (choice)
                {
                    case 1 : 
                        Console.WriteLine("1.Chương trình tính điểm trung bình ");
                        float diemToan; Console.Write("Math : ");           diemToan = float.Parse(Console.ReadLine());
                        float diemVan;  Console.Write("Literature :");      diemVan = float.Parse(Console.ReadLine());
                        float diemAnh;  Console.Write("English : ");        diemAnh = float.Parse(Console.ReadLine());
                        float mark = (diemToan + diemVan + diemAnh) / 3;
                        Console.WriteLine("Điểm = {0}",mark);
                        break;
                    case 2 : 
                        Console.WriteLine("2.Chương trình xét hạnh kiểm ");
                        float diemHd;
                        Console.Write("Vui lòng nhập điểm hoạt động : ");
                        diemHd = float.Parse(Console.ReadLine());
                        if(diemHd <= 5) {
                            Console.WriteLine("HK : YEU");
                        }else if (diemHd <= 6.5) 
                        {
                            Console.WriteLine("HK : TB");
                        }else if(diemHd <= 7)
                        {
                            Console.WriteLine("HK : KHA");
                        }else if(diemHd <= 8.5)
                        {
                            Console.WriteLine("HK : T");
                        }else
                        {
                            Console.WriteLine("HK : XS");
                        }
                        break;
                    case 3 : 
                        Console.WriteLine("3.Chương trình tính tổng các số lẻ từ 1 đến n");
                        int tong = 0;
                        int n; Console.WriteLine("n = "); n = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            if(i % 2 != 0 )
                            {
                                Console.Write(i + " ");
                                tong += i; 
                            }
                        }
                        Console.WriteLine(tong);
                        break;
                    case 4 : 
                        Console.WriteLine("4.Chương trình xuất các số từ 100 đến 1" );
                        int j = 100; 
                        while (j >= 1)
                        {
                            Console.Write(j + " ");

                            j--;
                        }
                        Console.WriteLine();
                        break;
                    case 0 : 
                        Console.WriteLine("Cảm ơn bạn đã dùng chương trình "); 
                        break;
                    default : 
                        Console.WriteLine("Mời bạn nhập lại chương trình : "); 
                        break;
                }
            } while (choice != 0);
        }
    }
}
