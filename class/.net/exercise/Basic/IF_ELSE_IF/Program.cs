using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_ELSE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập điểm xếp loại. Nếu đ >= 9 "Giỏi", >=8 "Khá", >=7 "TB", <7 "BT"
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.Write("Nhập điểm xếp loại: ");
            //int diem = int.Parse(Console.ReadLine());
            //if (diem >= 9) Console.WriteLine("Giỏi");
            //else if (diem >= 8) Console.WriteLine("Khá");
            //else if (diem >= 7) Console.WriteLine("TB");
            //if (diem < 7) Console.WriteLine("BT");
            //Console.WriteLine("Kết thúc");
            //Console.ReadLine();

            // Tìm số lớn nhất trong 4 số
            //Console.OutputEncoding = Encoding.UTF8;
            //int i = 1;
            //int a = Nhap(i); ++i;
            //int b = Nhap(i); ++i;
            //int c = Nhap(i); ++i;
            //int d = Nhap(i); ++i;
            //int max = 0;
            //if (a > max)
            //{
            //    max = a;
            //}
            //if (b > max)
            //{
            //    max = b;
            //}
            //if (c > max)
            //{
            //    max = c;
            //}
            //if (d > max)
            //{
            //    max = d;
            //}
            //Console.WriteLine("Số max = " + max);
            //Console.ReadLine();

            //
            Object[] nhom = { "Lan", 9, 'H', 9.5, "Xuan" };
            foreach (var ten in nhom)
            {
                Console.Write("{0}", ten);
                Console.ReadLine();
            }
        }
        static public int Nhap(int i)
        {
            int x;
            while (true)
            {
                Console.WriteLine("Nhập số thứ {0}: ", i);
                String so = Console.ReadLine();
                if (int.TryParse(so, out x))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nhập sai số thứ: ");
                }
            }
            return x;
            //int x;
            //while (true)
            //{
            //    Console.WriteLine("Nhập số thứ {0}: ",i);
            //    try
            //    {
            //        x = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Giá trị nhập vào không hợp lệ. Vui lòng nhập lại số nguyên.");
            //    }
            //}
            //return x;
        }
    }
}
