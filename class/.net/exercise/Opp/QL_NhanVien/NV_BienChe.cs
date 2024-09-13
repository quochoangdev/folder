using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    class NV_BienChe : NhanVien
    {
        double heSoLuong;

        public NV_BienChe()
        {
        }

        public NV_BienChe(string maNV, string hoTen, DateTime namSinh, string gioiTinh, string soCCCD, double luongCoBan) : base(maNV, hoTen, namSinh, gioiTinh, soCCCD, luongCoBan)
        {
            this.HeSoLuong = heSoLuong;
        }

        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }

        public override void Nhap()
        {
            Console.Write("Nhập thông tin NV Biên Chế: ");
            base.Nhap();
            Console.Write("Nhập hệ số lương: "); HeSoLuong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.Write("Xuất thông tin NV Biên Chế: ");
            base.Nhap();
            Console.Write("Hệ số lương là: {0}", HeSoLuong);
        }

        public override double ThucLinh()
        {
            return HeSoLuong * LuongCoBan;
        }
    }
}
