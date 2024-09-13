using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    abstract class HocVien
    {
        string maHocVien;

        public string MaHocVien
        {
            get { return maHocVien; }
            set { maHocVien = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        string soChungMinh;

        public string SoChungMinh
        {
            get { return soChungMinh; }
            set { soChungMinh = value; }
        }
        DateTime ngayNhapHoc;

        public DateTime NgayNhapHoc
        {
            get { return ngayNhapHoc; }
            set { ngayNhapHoc = value; }
        }
        public HocVien()
        { }
        public HocVien(string maHocVien, string hoTen, string soChungMinh, DateTime ngayNhapHoc)
        { }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã học viên: "); this.MaHocVien = Console.ReadLine();
            Console.Write("Nhập họ tên học viên: "); this.HoTen = Console.ReadLine();
            Console.Write("Nhập số chứng minh: "); this.SoChungMinh = Console.ReadLine();
            Console.Write("Nhập ngày nhập học: "); this.NgayNhapHoc = DateTime.Parse(Console.ReadLine());
        }
        public virtual void Xuat()  
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mã học viên là: {0}", this.MaHocVien);
            Console.WriteLine("Tên học viên là: {0}", this.HoTen);
            Console.WriteLine("Số chứng minh là: {0}", this.SoChungMinh);
            Console.WriteLine("Ngày nhập học là: {0}", this.NgayNhapHoc);
        }
        public abstract int ThoiGianHoc();
    }
}
