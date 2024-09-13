using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_midTermTest
{
    class HocGuitar : HocVien, ITienHocPhi
    {
        float heSo;
        public float HeSo { get => heSo; set => heSo = value; }

        float donGia;
        public float DonGia { get => donGia; set => donGia = value; }

        public HocGuitar() : base() { }

        public HocGuitar(string maHocVien, string hoTen, string soChungMinh, DateTime ngayNhapHoc, float heSo, float donGia) : base(maHocVien, hoTen, soChungMinh, ngayNhapHoc)
        {
            this.HeSo = heSo;
            this.DonGia = donGia;
        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập thông tin học viên Guitar;");
            base.Nhap();
            this.HeSo = 1.5F;
            Console.Write("Nhập đơn giá: "); this.DonGia = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Thông tin học viên Guitar;");
            base.Xuat();
            Console.Write("Hệ số là: {0}", this.HeSo);
            Console.Write("Đơn giá là: {0}", this.DonGia);
        }

        public override int ThoiGianHoc()
        {
            int nam = DateTime.Today.Year - NgayNhapHoc.Year;
            return DateTime.Today.Month - NgayNhapHoc.Month + (nam * 12);
        }

        public double TinhHocPhi()
        {
            return (DonGia - (DonGia / 10)) * HeSo;
        }
    }
}
