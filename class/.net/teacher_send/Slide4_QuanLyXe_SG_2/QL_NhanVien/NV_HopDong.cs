using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    internal class NV_HopDong : NhanVien, IPhuCap
    {
        double mucLuong;
        public double MucLuong { get => mucLuong; set => mucLuong = value; }
        public NV_HopDong() { }
        public NV_HopDong(string maNV, string hoTen, DateTime namSinh,
            string gioiTinh, string soCCCD, double mucLuong) : base(maNV,
                hoTen, namSinh, gioiTinh, soCCCD)
        {
            this.MucLuong = mucLuong;
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin NV Hợp Đồng");
            base.Nhap();
            Console.WriteLine("Nhập mức lương"); MucLuong = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("--------------- Xuất thông tin NV Hợp Đồng");
            base.Xuat();
            Console.WriteLine("Mức lương là: {0}", this.MucLuong);
        }
        public override double ThucLinh()
        {
            return MucLuong + PhuCap();
        }

        public double PhuCap()
        {
            return MucLuong / 10;
        }
    }
}
