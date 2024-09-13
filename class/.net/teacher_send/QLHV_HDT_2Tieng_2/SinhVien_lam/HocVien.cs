using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocVien
{
    internal abstract class HocVien
    {
        //Mã học viên (string), họ tên (string), số chứng minh (string), ngày nhập học (DateTime).
        private string maHocVien;
        private string hoTen;
        private string soCMND;
        private DateTime ngayNhapHoc;

        public HocVien()
        {
        }

        public HocVien(string maHocVien, string hoTen, string soCMND, DateTime ngayNhapHoc)
        {
            this.maHocVien = maHocVien;
            this.hoTen = hoTen;
            this.soCMND = soCMND;
            this.ngayNhapHoc = ngayNhapHoc;
        }

        public string MaHocVien { get => maHocVien; set => maHocVien = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoCMND { get => soCMND; set => soCMND = value; }
        public DateTime NgayNhapHoc { get => ngayNhapHoc; set => ngayNhapHoc = value; }
        public virtual void nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập mã học viên: ");
            MaHocVien = Console.ReadLine();
            Console.WriteLine("Nhập họ tên học viên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập số CMND: ");
            SoCMND = Console.ReadLine();
            Console.WriteLine("Nhập ngày nhập học: ");
            NgayNhapHoc = DateTime.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.Write("{0}\t{1}\t{2}\t{3}\t",MaHocVien,HoTen,SoCMND,NgayNhapHoc.ToString("d/m/yyyy"));
        }
        public abstract int thoiGianHoc();
    }
}
