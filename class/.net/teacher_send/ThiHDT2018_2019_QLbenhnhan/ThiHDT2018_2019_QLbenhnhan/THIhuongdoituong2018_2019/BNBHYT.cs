using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIhuongdoituong2018_2019
{
    class BNBHYT:BENHNHAN,IVIENPHI
    {
        public double donGiaPhong { get; set; }
        private string maSoBaoHiem;

        public string MaSoBaoHiem
        {
            get { return maSoBaoHiem; }
            set { maSoBaoHiem = value; }
        }

        public BNBHYT() : base()
        { }
        public BNBHYT(string maBenhNhan, string hoTen, DateTime ngayNhapVien, string maSoBaoHiem)
            : base(maBenhNhan, hoTen, ngayNhapVien)
        {
            this.MaSoBaoHiem = maSoBaoHiem;
        }
        string yeuCau;
        public override void Nhap()
        {
            Console.WriteLine("Nhập thông tin BN bảo hiểm y tế là");
            base.Nhap();
            Console.WriteLine("Nhập mã số bảo hiểm"); 
            MaSoBaoHiem = Console.ReadLine();
            Console.WriteLine("Bạn có yêu cầu phòng cho BNBHXH không?");
            Console.WriteLine("Nếu có yêu cầu phòng thì nhấn phím 1, không thì nhấn Enter hoặc phím bất kỳ");
            yeuCau = Console.ReadLine();
            if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
            else Console.WriteLine("Không có yêu cầu về phòng"); 
        }
        public bool Phongtheoyeucau()
        {
            if (yeuCau == "1") return true;
            return false;
        }
        public override void Xuat()
        {
            Console.WriteLine("Thông tin bệnh nhân BHYT");
            base.Xuat();
            Console.WriteLine("Mã số bảo hiểm là: " + MaSoBaoHiem);
            if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
        }
        public override string ToString()
        {
            return "Đây là ToString BNBH__YTE có mã bệnh nhân là " + this.MaBenhNhan;
        }
        
        public double TinhHoaDonVienPhi()
        {
            donGiaPhong = 250;
            if (Phongtheoyeucau() == true)
                return (base.TinhSoNgayNhapVien() * donGiaPhong * 200000) - base.TinhSoNgayNhapVien() * donGiaPhong * 70 / 100;
            else
                return (base.TinhSoNgayNhapVien() * donGiaPhong) * 0.7;
                //return (base.TinhSoNgayNhapVien() * donGiaPhong) - base.TinhSoNgayNhapVien() * donGiaPhong * 70 / 100;
        }
    }
}
