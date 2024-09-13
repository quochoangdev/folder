using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIhuongdoituong2018_2019
{
    class BNBHXH : BENHNHAN, IVIENPHI
    {
        public double donGiaPhong { get; set; }
        private string maBaoHiemXaHoi;

        public string MaBaoHiemXaHoi
        {
            get { return maBaoHiemXaHoi; }
            set { maBaoHiemXaHoi = value; }
        }

        public BNBHXH() : base()
        { }
        public BNBHXH(string maBenhNhan, string hoTen, DateTime ngayNhapVien, string maBaoHiemXaHoi)
            : base(maBenhNhan, hoTen, ngayNhapVien)
        {
            this.MaBaoHiemXaHoi = maBaoHiemXaHoi;
        }
        
        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin BN bảo hiểm xã hội:");
            base.Nhap();
            Console.WriteLine("Nhập mã bảo hiểm xã hội: "); 
            MaBaoHiemXaHoi = Console.ReadLine();
            //Console.WriteLine("Bạn có yêu cầu phòng cho BNBHXH không?");
            //Console.WriteLine("Nếu có yêu cầu phòng thì nhấn phím 1, không thì nhấn Enter hoặc phím bất kỳ");
            //yeuCau = Console.ReadLine();
            //if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
            //else Console.WriteLine("Không có yêu cầu về phòng"); 
        }
       // string yeuCau;
        //public bool Phongtheoyeucau()
        //{                      
        //    if (yeuCau == "1") return true;
        //     return false; 
        //}
        public double TinhHoaDonVienPhi()
        {
            donGiaPhong = 150;
            if (base.Phongtheoyeucau() == true)
                return base.TinhSoNgayNhapVien() * donGiaPhong * 200000;
            return base.TinhSoNgayNhapVien() * donGiaPhong;
        }
        public override void Xuat()
        {
            Console.WriteLine("---------------Thông tin bệnh nhân BHXH");
            base.Xuat();
            Console.WriteLine("Mã bảo hiểm xã hội là: " + MaBaoHiemXaHoi);
            //if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
        }
        public override string ToString()
        {
            return "Đây là ToString BNBHXH___XH có mã bệnh nhân là: " + MaBenhNhan;
        }
      
    }
}
