using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIhuongdoituong2018_2019
{
    abstract class BENHNHAN
    {
        private string maBenhNhan;

        public string MaBenhNhan
        {
            get { return maBenhNhan; }
            set { maBenhNhan = value; }
        }

        private string hoTen;
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        private DateTime ngayNhapVien;
        public DateTime NgayNhapVien
        {
            get { return ngayNhapVien; }
            set { ngayNhapVien = value; }
        }


        //private bool phongtheoyeucau;

        //public bool Phongtheoyeucau
        //{
        //    get { return phongtheoyeucau; }
        //    set { phongtheoyeucau = value; }
        //}
        public BENHNHAN()
        { }
        public BENHNHAN(string maBenhNhan, string hoTen, DateTime ngayNhapVien)
        {
            this.MaBenhNhan = maBenhNhan;
            this.HoTen = hoTen;
            this.NgayNhapVien = ngayNhapVien;
        }
        //public bool Phongtheoyeucau()
        //{
        //    Console.WriteLine("Nếu có yêu cầu phòng thì nhấn phím 1, không thì nhấn Enter hoặc phím bất kỳ");
        //    string nhap = Console.ReadLine();
        //    if (nhap == "1")
        //    { Console.WriteLine("Có yêu cầu về phòng"); return true; }
        //    else
        //    { Console.WriteLine("Không có yêu cầu về phòng"); return false; }
        //}
        public virtual void Nhap()
        {
            Console.WriteLine("Nhập mã bệnh nhân"); this.MaBenhNhan = Console.ReadLine(); 
            Console.WriteLine("Nhập họ tên"); this.HoTen = Console.ReadLine();
            Console.WriteLine("Ngày nhập viện"); this.NgayNhapVien = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Bạn có yêu cầu phòng cho BNBHXH không?");
            Console.WriteLine("Nếu có yêu cầu phòng thì nhấn phím 1, " +
                "không thì nhấn Enter hoặc phím bất kỳ");
            yeuCau = Console.ReadLine();
            if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
            else Console.WriteLine("Không có yêu cầu về phòng"); 
        }
        string yeuCau;
        public bool Phongtheoyeucau()
        {
            if (yeuCau == "1") return true;
            return false;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Mã bệnh nhân là {0}", MaBenhNhan);
            Console.WriteLine("Họ tên là " + HoTen);
            Console.WriteLine("Ngày nhập viện {0}", NgayNhapVien);
            if (Phongtheoyeucau() == true) Console.WriteLine("Có yêu cầu về phòng");
            else Console.WriteLine("Không có yêu cầu về phòng");
        }
        public int TinhSoNgayNhapVien()
        {
          return DateTime.Today.Day - NgayNhapVien.Day;
        }
        abstract new public string ToString();
    }
}
