using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocVien
{
    internal class HocGuitar : HocVien, ITienHocPhi
    {
        private float heSo=1.5f;
        private float donGia;

        public HocGuitar()
        {
        }

        public HocGuitar(string maHocVien, string hoTen, string soCMND, DateTime ngayNhapHoc, float heSo, float donGia) : base(maHocVien, hoTen, soCMND, ngayNhapHoc)
        {
            this.heSo = heSo;
            this.donGia = donGia;
        }

        public float HeSo { 
            get => heSo;
            set => heSo = value; 
        }
        public float DonGia { get => donGia; set => donGia = value; }

        public override void nhap()
        {
            Console.WriteLine("Nhập học viên Guitar: ");
            base.nhap();
            Console.WriteLine("Nhập đơn giá: ");
            DonGia = float.Parse(Console.ReadLine());
        }

        public override int thoiGianHoc()
        {
            int soThang = (DateTime.Today.Year - NgayNhapHoc.Year) * 12 + (DateTime.Today.Month - NgayNhapHoc.Month) + 1;
            return soThang;
        }

        public double tinhHocPhi()
        {
            //(Đơn giá – (Đơn giá / 10)) * Hệ số.
            return (DonGia - (DonGia / 10)) * HeSo;
        }

        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}\t{1}\n", HeSo, DonGia);
        }
    }
}
