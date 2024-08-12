using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__buoi6_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice; 
            do
            {
                Console.WriteLine("1.Nhập vào tên , điểm và năm sinh của  học sinh ");
                Console.WriteLine("2.Kiểm tra một số nguyên có nằm trong khoảng từ 1 đến 10 hay không ");
                Console.WriteLine("3.Tính tổng số chẵn từ 1 đến 15 bỏ qua sô 4 ");
                Console.WriteLine("0.Thoát");
                Console.Write("Choice :");
                choice= int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1.Nhập vào tên , điểm và năm sinh của  học sinh ");
                        string hoTen;
                        Console.Write("Mời nhập vào họ và tên : ");
                        hoTen = Console.ReadLine();
                        float diemC;
                        Console.Write("C# = ");
                        diemC = float.Parse(Console.ReadLine());
                        int namSinh;
                        Console.Write("Năm sinh :");
                        namSinh = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ho va ten {0} Nam sinh {1} Diem C = {2}" , hoTen , namSinh , diemC);
                        break;
                    case 2: 
                        Console.WriteLine("2.Kiểm tra một số nguyên có nằm trong khoảng từ 1 đến 10 hay không ");
                        int n;
                        Console.WriteLine("n = ");
                        n = int.Parse(Console.ReadLine());
                        string turn = "";
                        for(int i = 1;i <= 10; i++)
                        {
                            turn = (n == i) ?  "Khong co": "Co";
                        }
                        Console.WriteLine(turn);
                        break;
                    case 3: 
                        Console.WriteLine("3.Tính tổng số chẵn từ 1 đến 15 bỏ qua sô 4 ");
                        int tong = 0; 
                        for(int j = 1; j <= 6; j++)
                        {
                            if (j % 2 == 0 && j != 4)
                            {
                                tong = tong + j;  
                            }
                        }
                        Console.WriteLine("Tổng của các số từ 1 đến 15 bỏ qua số 4 là : {0}",tong);
                        break;
                    case 4: 
                        Console.WriteLine("0.Thoát"); 
                        break;
                }
            } while (choice !=0);
            Console.ReadKey();
        }
    }
}
