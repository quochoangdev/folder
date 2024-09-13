using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    class HocVienGuitar : HocVien, ITienHocPhi
    {
        float heSo;

        public float HeSo
        {
            get { return heSo; }
            set { heSo = value; }
        }
        float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public HocVienGuitar() : base()
        { }
        public HocVienGuitar(string maHocVien, string hoTen, string soChungMinh, DateTime ngayNhapHoc, float heSo, float donGia)
            : base(maHocVien, hoTen, soChungMinh, ngayNhapHoc)
        {
            this.HeSo = heSo;
            this.DonGia = donGia;
        }
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập thông tin học viên Guitar:");
            base.Nhap();
            this.HeSo = 1.5F;
            Console.Write("Nhập đơn giá: "); this.DonGia = float.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin học viên Guitar:");
            base.Xuat();
            Console.WriteLine("Hệ số là: {0}", this.HeSo);
            Console.WriteLine("Đơn giá là: {0}", this.DonGia);
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
