using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe_ke_thua
{
    class Xe
    {
        String bienSo;
        public String tenXe;
        public String trongTai;
        public DateTime ngayDangKiem;
        public int tieuChuanBang;

        public string BienSo { get => bienSo; set => bienSo = value; }

        public Xe()
        {
        }

        public Xe(string bienSo, string tenXe, string trongTai, DateTime ngayDangKiem, int tieuChuanBang)
        {
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.trongTai = trongTai;
            this.ngayDangKiem = ngayDangKiem;
            this.tieuChuanBang = tieuChuanBang;
        }

        public void Nhap()
        {
            Console.Write("Nhập biển số xe: ");
            BienSo = Console.ReadLine();
            Console.Write("Nhập tên xe: ");
            tenXe = Console.ReadLine();
            Console.Write("Nhập trọng tải: ");
            trongTai = Console.ReadLine();
            Console.Write("Nhập ngày đăng kiểm: ");
            ngayDangKiem = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập tiêu chuẩn bằng: ");
            tieuChuanBang = int.Parse(Console.ReadLine());
        }
    }
}
