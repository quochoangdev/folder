using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    class HocVienPiano : HocVien, ITienHocPhi
    {
        double hocPhi;

        public double HocPhi
        {
            get { return hocPhi; }
            set { hocPhi = value; }
        }
      
        public HocVienPiano()
            : base()
        { }
        public HocVienPiano(string maNhanVien, string hoTen, string soChungMinh, DateTime ngayVaoLam, double hocPhi)
            : base(maNhanVien, hoTen, soChungMinh, ngayVaoLam)
        {
            this.HocPhi = hocPhi;
        }
        public override void Nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập thông tin học viên Piano:");
            base.Nhap();
            Console.Write("Nhập học phí: "); this.HocPhi = double.Parse(Console.ReadLine());
        }
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Thông tin học viên Piano:");
            base.Xuat();
            Console.WriteLine("Học phí là: {0}", this.HocPhi);
        }
        public override int ThoiGianHoc()
        {
            int nam = DateTime.Today.Year - NgayNhapHoc.Year;
            return DateTime.Today.Month - NgayNhapHoc.Month + (nam * 12) + 1;
        }
        public double TinhHocPhi()
        {
            return HocPhi - HocPhi / 20;    //01/2023 - 12/2022
        }
    }
}
