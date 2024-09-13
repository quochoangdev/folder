using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan
{
    class BN_BHXH : BenhNhan, ITienAn
    {
        String maSoBHXH;
        double soNgayNamVienBHXH;

        public string MaSoBHXH { get => maSoBHXH; set => maSoBHXH = value; }
        public double SoNgayNamVienBHXH { get => soNgayNamVienBHXH; set => soNgayNamVienBHXH = value; }

        public BN_BHXH() { }

        public BN_BHXH(string maBN, string hoTen, string maSoBHXH, double soNgayNamVienBHXH) : base(maBN, hoTen)
        {
            this.MaSoBHXH = maSoBHXH;
            this.SoNgayNamVienBHXH = soNgayNamVienBHXH;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin BN BHXH");
            base.Nhap();
            Console.WriteLine("Nhập MaSoBHXH"); MaSoBHXH = Console.ReadLine();
            Console.WriteLine("Nhập SoNgayNamVienBHXH"); SoNgayNamVienBHXH = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("--------------- Xuất thông tin BN BHXH");
            base.Xuat();
            Console.WriteLine("MaSoBHXH là: {0}", MaSoBHXH);
            Console.WriteLine("SoNgayNamVienBHXH là: {0}", SoNgayNamVienBHXH);
        }

        public override double TinhVienPhi()
        {
            return (SoNgayNamVienBHXH * 70000) * TinhTienAn();
        }

        public double TinhTienAn()
        {
            return SoNgayNamVienBHXH * 30000;
        }
    }
}
