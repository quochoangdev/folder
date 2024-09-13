using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_chuong_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhập tên của bạn: ");
            String ten = Console.ReadLine();
            Console.WriteLine("Tên của bạn là: {0}{1}", ten, "hi");
            Console.ReadLine();
        }
    }
}
