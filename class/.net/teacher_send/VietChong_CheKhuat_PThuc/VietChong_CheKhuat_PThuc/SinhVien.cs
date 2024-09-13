using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VietChong_CheKhuat_PThuc
{
    class SinhVien : Nguoi
    {
        public SinhVien() { }
        // Che khuất phương thức       
        // Nếu không có new thì sẽ có cảnh báo ~~~ màu xanh dưới chữ Xuat  (sau khi click vào BUILD)
        //public new void Xuat()      // Dùng new để chắc chắn rằng chúng ta đang thực hiện che khuất phương thức lớp người, chỉ chạy phương thức lớp SV        
        //{
        //    base.Xuat(); // gọi lại phương thức xuất của lớp người
        //    //Console.WriteLine("lop SinhVien");
        //}
        // Viết chồng phương thức, Dùng từ khóa Override để thực hiện viết chồng phương thức
        //public override void Xuat()
        //{
        //    base.Xuat();
        //    Console.WriteLine("lop SinhVien");
        //}
        ///// Khác nhau cách khai lớp ở hàm Main, tính đa hình
    }
}
