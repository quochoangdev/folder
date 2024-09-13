using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChong_CheKhuat_PThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nguoi N = new Nguoi();
            //N.Xuat();
            SinhVien SV = new SinhVien();
            SV.Xuat();

            //Nguoi N = new SinhVien();
            //N.Xuat();
            ////////// Tính đa hình, Upcasting, tạo ra đối tượng Người, dùng hàm khởi tạo SinhVien tạo ra
                             // Lúc này nếu như ở lớp SV, ta thực hiện che khuất chứ không viết chồng thì chỉ gọi lớp Cha
            Console.ReadLine();
        }
    }
}
