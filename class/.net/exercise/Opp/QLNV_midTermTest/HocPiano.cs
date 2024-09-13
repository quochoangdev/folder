using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_midTermTest
{
    class HocPiano : HocVien, ITienHocPhi
    {
        double hocPhi;
        public double HocPhi { get => hocPhi; set => hocPhi = value; }

        public HocPiano() : base() { }
        public HocPiano(string maHocVien, string hoTen, string soChungMinh, DateTime ngayNhapHoc, double hocPhi) : base(maHocVien, hoTen, soChungMinh, ngayNhapHoc)
        {
            this.HocPhi = hocPhi;
        }

        public override void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập thông tin học viên Guitar;");
            base.Nhap();
            Console.Write("Nhập học phí: "); this.HocPhi = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Thông tin học viên Guitar;");
            base.Xuat();
            Console.Write("Học Phí là: {0}", this.HocPhi);
        }

        public override int ThoiGianHoc()
        {
            int nam = DateTime.Today.Year - NgayNhapHoc.Year;
            return DateTime.Today.Month - NgayNhapHoc.Month + (nam * 12) + 1;
        }

        public double TinhHocPhi()
        {
            return HocPhi - HocPhi / 20;
        }
    }
}
