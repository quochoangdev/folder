using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan
{
    class BN_BHYT:BenhNhan,ITienAn
    {
        String maSoBHYT;
        double soNgayNamVienBHYT;

        public string MaSoBHYT { get => maSoBHYT; set => maSoBHYT = value; }
        public double SoNgayNamVienBHYT { get => soNgayNamVienBHYT; set => soNgayNamVienBHYT = value; }

        public BN_BHYT() { }

        public BN_BHYT(string maBN, string hoTen,string maSoBHYT, double soNgayNamVienBHYT) : base(maBN, hoTen)
        {
            this.MaSoBHYT = maSoBHYT;
            this.SoNgayNamVienBHYT = soNgayNamVienBHYT;
        }

        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin BN BHYT");
            base.Nhap();
            Console.WriteLine("Nhập MaSoBHYT"); MaSoBHYT = Console.ReadLine();
            Console.WriteLine("Nhập SoNgayNamVienBHYT"); SoNgayNamVienBHYT = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.WriteLine("--------------- Xuất thông tin BN BHYT");
            base.Xuat();
            Console.WriteLine("MaSoBHXH là: {0}", MaSoBHYT);
            Console.WriteLine("SoNgayNamVienBHXH là: {0}", SoNgayNamVienBHYT);
        }

        public override double TinhVienPhi()
        {
            return (SoNgayNamVienBHYT * 50000) + TinhTienAn();
        }

        public double TinhTienAn()
        {
            return SoNgayNamVienBHYT * 25000;
        }
    }
}
