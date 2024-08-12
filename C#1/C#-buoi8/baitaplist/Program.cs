using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace baitaplist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //// Viết chương trình tạo ra một list có n phần tử , n nhập từ bàn phím 
            ////Các phần tử là số ngẫu nghiên từ 1 - 100 
            //int n;
            //Console.WriteLine(" n = ");
            //n = int.Parse(Console.ReadLine());
            //Random r = new Random();
            //List<int> list = new List<int>();
            //for(int i = 0; i < n; i++)
            //{
            //    list.Add(r.Next( 1 ,49 ));
            //}
            //Console.WriteLine("Danh sach moi tao duoc la : ");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //// Tìm sao so a co trong danh sach khong 
            //var kq = from i in list
            //         where i == 44
            //         select i;
            //foreach (int i in kq)
            //{
            //    if(i == 44)
            //    {
            //        Console.WriteLine("Tim thay so {0} trong mang ",i);
            //    }
            //}
            //list.IndexOf(21);
            //Console.WriteLine(list.IndexOf(21));

            //// Bai tap ve mang list 
            //ArrayList arrLst = new ArrayList();
            //string monHoc;
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Mon hoc :");
            //    monHoc = Console.ReadLine();
            //    arrLst.Add(monHoc);
            //}
            //foreach(string x in arrLst)
            //{
            //    Console.WriteLine(x);
            //}

            // Viet chuong trinh tra loi ket qua cac phep tinh
            //List<string> ques = new List<string>() {"5+1+6=" , "3*6=" , "12%2=" ,"30/6= "};
            //List<int> ans = new List<int>() {12 , 18 , 0 , 5};
            //for (int i = 0; i < ques.Count; i++)
            //{
            //    Console.WriteLine(ques[i]);
            //    int a = int.Parse(Console.ReadLine());
            //    if(a == ans[i])
            //    {
            //        Console.WriteLine("Correct");
            //    }else
            //    {
            //        Console.WriteLine("F");
            //    }
            //}

            // Viet chuong trinh kiem tra cau hoi 
            //List<string> list = new List<string>() {"Ai là vị vua cuối cùng của Việt Nam : " , "Việt Nam có bao nhiêu tỉnh thành :" , "Ai là huyền thoại sống của bóng đá thế giới : "};
            //List<string> list2 = new List<string>() { "Bao Dai", "63", "L.Messi" };
            //for(int i  = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //    string trL = Console.ReadLine();
            //    if(trL == list2[i])
            //    {
            //        Console.WriteLine("T");
            //    }else
            //    {
            //        Console.WriteLine("F");
            //    }
            //}

            // Viet chuong trinh nhap vao phong va so phong 
            int n; 
            n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Phong {0} la :" ,i);
                int a = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
