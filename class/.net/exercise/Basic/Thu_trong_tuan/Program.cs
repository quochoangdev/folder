using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Thu_trong_tuan
{
    class Program
    {
        static void Main(string[] args)
        {
            ex_b();
        }
        public static void ex_a()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Thứ: ");
            string str = Console.ReadLine();

            if (str.ToLower() == "thu hai")
            {
                Console.WriteLine("Thứ 2");
            }
            else if (str.ToLower() == "thu ba")
            {
                Console.WriteLine("Thứ 3");
            }
            else if (str.ToLower() == "thu tu")
            {
                Console.WriteLine("Thứ 4");
            }
            else if (str.ToLower() == "thu nam")
            {
                Console.WriteLine("Thứ 5");
            }
            else if (str.ToLower() == "thu sau")
            {
                Console.WriteLine("Thứ 6");
            }
            else if (str.ToLower() == "thu bay")
            {
                Console.WriteLine("Thứ 7");
            }
            else if (str.ToLower() == "chu nhat")
            {
                Console.WriteLine("Chủ Nhật");
            }
            Console.ReadLine();
        }
        public static void ex_b()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Thứ: ");
            string str = Console.ReadLine();
            string strKhongDau = RemoveDiacritics(str);
            string strKhongCach = strKhongDau.Replace(" ", "");

            if (strKhongCach.ToLower() == "thuhai")
            {
                Console.WriteLine("Thứ 2");
            }
            else if (strKhongCach.ToLower() == "thuba")
            {
                Console.WriteLine("Thứ 3");
            }
            else if (strKhongCach.ToLower() == "thutu")
            {
                Console.WriteLine("Thứ 4");
            }
            else if (strKhongCach.ToLower() == "thunam")
            {
                Console.WriteLine("Thứ 5");
            }
            else if (strKhongCach.ToLower() == "thusau")
            {
                Console.WriteLine("Thứ 6");
            }
            else if (strKhongCach.ToLower() == "thubay")
            {
                Console.WriteLine("Thứ 7");
            }
            else if (strKhongCach.ToLower() == "chunhat")
            {
                Console.WriteLine("Chủ Nhật");
            }
            Console.ReadLine();
        }
        public static string RemoveDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            return regex.Replace(normalizedString, string.Empty).Normalize(NormalizationForm.FormC);
        }
    }
}
