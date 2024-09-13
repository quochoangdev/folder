using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    abstract class NhanVien
    {
        String maNV;
        String hoTen;
        DateTime namSinh;
        String gioiTinh;
        String soCCCD;
        double luongCoBan;

        public string MaNV { get => maNV; set => maNV = value; }
        public double LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        protected NhanVien(){}

        protected NhanVien(string maNV, string hoTen, DateTime namSinh, string gioiTinh, string soCCCD, double luongCoBan)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.soCCCD = soCCCD;
            this.luongCoBan = luongCoBan;
        }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã NV: "); MaNV = Console.ReadLine();
            Console.Write("Nhập họ tên: "); hoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: "); namSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: "); gioiTinh = Console.ReadLine();
            Console.Write("Nhập số CCCD: "); soCCCD = Console.ReadLine();
            Console.Write("Nhập lương cơ bản: "); LuongCoBan = double.Parse(Console.ReadLine());
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Xuất mã NV: {0}", MaNV);
            Console.Write("Xuất họ tên: {0}", hoTen);
            Console.Write("Xuất năm sinh: {0}", namSinh);
            Console.Write("Xuất giới tính: {0}", gioiTinh);
            Console.Write("Xuất số CCCD: {0}", soCCCD);
            Console.Write("Xuất lương cơ bản: {0}", LuongCoBan);
        }
        public abstract double ThucLinh();
    }
}
