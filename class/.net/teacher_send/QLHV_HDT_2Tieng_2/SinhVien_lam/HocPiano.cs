using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocVien
{
    internal class HocPiano : HocVien, ITienHocPhi
    {
        double hocPhi;

        public HocPiano()
        {
        }

        public HocPiano(string maHocVien, string hoTen, string soCMND, DateTime ngayNhapHoc, double hocPhi) : base(maHocVien, hoTen, soCMND, ngayNhapHoc)
        {
            this.hocPhi = hocPhi;
        }

        public double HocPhi { get => hocPhi; set => hocPhi = value; }

        public override void nhap()
        {
            Console.WriteLine("Nhập học viên Piano: ");
            base.nhap();
            Console.WriteLine("Nhập học phí: ");
            HocPhi = double.Parse(Console.ReadLine());
        }

        public override int thoiGianHoc()
        {
            int soThang = (DateTime.Today.Year - NgayNhapHoc.Year) * 12 + (DateTime.Today.Month - NgayNhapHoc.Month);
            return soThang;
        }

        public double tinhHocPhi()
        {
            //Học phí – Học Phí / 20.
            return HocPhi - HocPhi / 20;
        }

        public override void xuat()
        {
            base.xuat();
            Console.Write("{0}\n",HocPhi);
        }
    }
}
