using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    class NV_HopDong : NhanVien
    {
        double mucLuong;

        public NV_HopDong(){}
        public NV_HopDong(string maNV, string hoTen, DateTime namSinh, string gioiTinh, string soCCCD, double luongCoBan) : base(maNV, hoTen, namSinh, gioiTinh, soCCCD, luongCoBan)
        {
            this.MucLuong = mucLuong;
        }
        public double MucLuong { get => mucLuong; set => mucLuong = value; }
        public override void Nhap()
        {
            Console.Write("Nhập thông tin NV Hợp Hồng: ");
            base.Nhap();
            Console.Write("Nhập mức lương: "); MucLuong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.Write("Xuất thông tin NV Hợp Đồng: ");
            base.Nhap();
            Console.Write("Hệ mức là: {0}", MucLuong);
        }

        public override double ThucLinh()
        {
            return MucLuong * LuongCoBan;
        }
    }
}
