using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_2_chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Mang_2_Chieu();
        }

        public static void Mang_2_Chieu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] M1 = { { 1, 2, 9 }, { 3, 4, 9 }, { 5, 6, 9 }, { 7, 8, 9 } };

            Console.WriteLine("Xuat mang m1 theo kiểu For");
            for (int i = 0; i < M1.GetLength(0); ++i)
            {
                for (int j = 0; j < M1.GetLength(1); ++j)
                {
                    Console.Write(M1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Xuất mảng M1 theo kiểu Foreach");
            foreach (int phantu in M1)
                Console.Write(phantu + " ");
            Console.ReadLine();
        }
        public static void Mang_Jaggeg()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[][] A = new int[3][];
            A[0] = new int[] { 3, 6, 7, 6, 9 };
            A[1] = new int[] { 2, 4, 6, 5, 8, 7 };
            A[2] = new int[] { 1, 5 };

            for (int i = 0; i < A.GetLength(0); ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                    Console.Write(A[i][j] + " ");
                Console.WriteLine("");
            }
            Console.WriteLine("In mảng Jaggeg theo Foreach");
            foreach (int[] Dong in A)
                foreach (int So in Dong)
                    Console.Write(So + "\t");
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void tinh_ngay_cua_thang()
        {
            int month;
            Console.WriteLine("Nhập tháng: ");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Tháng {0} có 31 ngày", month); break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Tháng {0} có 30 ngày", month); break;
                case 2:
                    Console.WriteLine("Nhập năm: ");
                    int year = int.Parse(Console.ReadLine());
                    if (year % 100 != 0 && year % 4 == 0 || year % 400 == 0)
                    {
                        Console.WriteLine("\nNăm {0} là năm nhuần", year);
                        Console.WriteLine("\nTháng {0} có 29 ngày", month);
                    }
                    else
                        Console.WriteLine("Tháng {0} có 28 ngày", month);
                    break;
                default:
                    Console.WriteLine("Không có tháng {0}", month);
                    break;
            }
            Console.ReadLine();
        }
    }
}
