using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    internal class NV_BienChe : NhanVien, IPhuCap
    {
        double heSoLuong;
        double luongCoBan;
        public NV_BienChe(){ }
        public NV_BienChe(string maNV, string hoTen, DateTime namSinh,
            string gioiTinh, string soCCCD, double heSoLuong, double luongCoBan) : base(maNV,
                hoTen, namSinh, gioiTinh, soCCCD)
        {
           this.HeSoLuong = heSoLuong;
           this.LuongCoBan = luongCoBan;
        }
        public double HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public override void Nhap(){
            Console.WriteLine("Nhập thông tin NV Biên Chế");
            base.Nhap();
            Console.WriteLine("Nhập hệ số lương"); HeSoLuong = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập lương cơ bản"); LuongCoBan = double.Parse(Console.ReadLine());
        }
        public override void Xuat(){
            Console.WriteLine("--------------- Xuất thông tin NV Biên Chế");
            base.Xuat();
            Console.WriteLine("Hệ số lương là: {0}", HeSoLuong);
            Console.WriteLine("Hệ số lương là: {0}", LuongCoBan);
        }
        public override double ThucLinh()
        {
            return HeSoLuong * LuongCoBan + PhuCap();
        }

        public double PhuCap()
        {
            return LuongCoBan / 10;
        }
    }
}
