using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    internal class Xe
    {
        String bienSo;
        public String tenXe;
        public DateTime ngayDangKy;
        public int trongTai;
        public string BienSo { get => bienSo; set => bienSo = value; }

        public Xe(){}
        public Xe(string bienSo, string tenXe, DateTime ngayDangKy, int trongTai)
        {
            this.bienSo = bienSo;
            this.tenXe = tenXe;
            this.ngayDangKy = ngayDangKy;
            this.trongTai = trongTai;
        }

        public void Nhap()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Biển Số Xe: "); BienSo = Console.ReadLine();
            Console.Write("Nhập Tên Xe: "); tenXe = Console.ReadLine();
            Console.Write("Nhập Ngày Đăng Ký: "); ngayDangKy = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập Trọng Tải: "); trongTai = int.Parse(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Biển Số Xe Là: {0}\t", this.BienSo);
            Console.Write("Tên Xe Là: {0}\t", this.tenXe);
            Console.Write("Ngày Đăng Ký Là: {0: dd/MM/yyyy}\t", this.ngayDangKy);
            Console.Write("Trọng Tải Xe Là: {0}", this.trongTai);
            Console.WriteLine("");
        }
    }
}
