using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    internal abstract class NhanVien
    {
        String hoTen;
        DateTime namSinh;
        String gioiTinh;
        String soCCCD;
        String maNV;
        public string MaNV { get => maNV; set => maNV = value; }
        protected NhanVien(){ }
        protected NhanVien(string maNV, string hoTen, DateTime namSinh, string gioiTinh, string soCCCD)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.soCCCD = soCCCD;
        }
        public virtual void Nhap(){
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã NV: "); MaNV = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: "); hoTen = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: "); namSinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhập giới tính: "); gioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập số CCCD: "); soCCCD = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã NV: {0}", MaNV);
            Console.WriteLine("Nhập họ tên: {0}", hoTen);
            Console.WriteLine("Nhập năm sinh: {0}", namSinh); 
            Console.WriteLine("Nhập giới tính: {0}", gioiTinh); 
            Console.WriteLine("Nhập số CCCD: {0}", soCCCD);
        }
        public abstract double ThucLinh();
    }
}
