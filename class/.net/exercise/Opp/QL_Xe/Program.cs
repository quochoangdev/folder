using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("\n-----Nhập 0 thoát menu----- \n " +
                    "1: Nhập \t 2: Xuất \t 3: Tìm " +
                    "\t 4: Xoá \t 5: Xoá 30");
                String menu = Console.ReadLine();
                if (menu == "0") break;
                else if (menu == "1") ds.Nhap();
                else if (menu == "2") ds.Xuat();
                else if (menu == "3") ds.Tim();
                else if (menu == "4") ds.Xoa();
                else if (menu == "5") ds.Xoa30();
            }
            Console.WriteLine("The End");
            Console.ReadLine();
        }
    }
}
