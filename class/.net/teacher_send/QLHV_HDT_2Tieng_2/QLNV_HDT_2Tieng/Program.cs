using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyHocVien QLNV = new QuanLyHocVien();
            QLNV.ThucHien();
            QLNV.TongHocPhi();
            QLNV.TinhTienThuong();
            Console.WriteLine("Kết thúc chương trình");
            Console.ReadLine();
        }
    }
}
