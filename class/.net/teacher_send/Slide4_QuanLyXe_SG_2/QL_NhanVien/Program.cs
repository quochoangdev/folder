using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSach ds = new DanhSach();
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.WriteLine("Nhập 0 thoát menu \n " +
                    "1: Nhập \t 2: Xuất \t 3: Tìm" +
                    "\t 4: Xoá  \t 5: Tính Tổng \n 6: Lọc 1 \t 7: Lọc 2 " +
                    "\n 8: Tính Phụ Cấp");
                String menu = Console.ReadLine();
                if (menu == "0") break;
                else if (menu == "1") ds.Nhap();
                else if (menu == "2") ds.Xuat();
                else if (menu == "5") // ds.TinhTong();//void
                    Console.WriteLine("Tổng = {0}", ds.TinhTong());
                else if (menu == "6") ds.Loc1();
                else if (menu == "7")
                {
                    foreach (NhanVien n in ds.Loc2().Values)
                        n.Xuat();
                }
                else if (menu == "8")
                    Console.WriteLine("Phụ cấp = {0}", ds.TongPhuCap());
            }
            Console.WriteLine("The End");
            Console.ReadLine();
        }
    }
}
