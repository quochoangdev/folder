using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_midTermTest
{
    abstract class HocVien
    {
        string maHocVien;
        public string MaHocVien { get => maHocVien; set => maHocVien = value; }

        string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value; }

        string soChungMinh;
        public string SoChungMinh{get => soChungMinh;set => soChungMinh = value;}

        DateTime ngayNhapHoc;
        public DateTime NgayNhapHoc{get => ngayNhapHoc;set => ngayNhapHoc = value;}

        public HocVien() { }
        public HocVien(string maHocVien, string hoTen, string soChungMinh, DateTime ngayNhapHoc)
        {
            this.MaHocVien = maHocVien;
            this.HoTen = hoTen;
            this.SoChungMinh = soChungMinh;
            this.NgayNhapHoc = ngayNhapHoc;
        }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã học viên: "); this.MaHocVien = Console.ReadLine();
            Console.Write("Nhập họ và tên: "); this.HoTen = Console.ReadLine();
            Console.Write("Nhập số chứng minh: "); this.SoChungMinh= Console.ReadLine();
            Console.Write("Nhập ngày nhập học: "); this.NgayNhapHoc= DateTime.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mã học viên là: {0}",this.MaHocVien); 
            Console.Write("Họ và tên là: {0}",this.HoTen);
            Console.Write("Số chứng minh là: {0}",this.SoChungMinh);
            Console.Write("Ngày nhập học là: {0}",this.NgayNhapHoc);
        }

        public abstract int ThoiGianHoc();
    }
}
