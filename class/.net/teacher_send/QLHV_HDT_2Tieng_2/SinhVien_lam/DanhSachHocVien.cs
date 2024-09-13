using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocVien
{
    internal class DanhSachHocVien
    {
        Dictionary<String, HocVien> danhSach = new Dictionary<string, HocVien>();

        public DanhSachHocVien()
        {
            danhSach.Add("G001", new HocGuitar("G001", "Nguyễn Văn A", "001", DateTime.Parse("2/2/2022"), 1.5f, 2300f));
            danhSach.Add("P001", new HocPiano("P001", " Trần Thị B", "002", DateTime.Parse("2/3/2022"), 30000));
            danhSach.Add("G002", new HocGuitar("G002", "Học Guitar 02", "003", DateTime.Parse("2/2/2018"), 1.5f, 6300f));
            danhSach.Add("P002", new HocPiano("P002", "Học Piano 02", "004", DateTime.Parse("2/3/2019"), 60000));
        }

        public void nhap()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("NHập G: HocGuitar, P: HocPiano");
            string tmp = Console.ReadLine();
            if (tmp == "0") return;
            if (tmp == "G")
            {
                HocGuitar hocGuitar = new HocGuitar();
                hocGuitar.nhap();
                danhSach.Add(hocGuitar.MaHocVien, hocGuitar);
            }
            else if( tmp == "P")
            {
                HocPiano hocPiano = new HocPiano();
                hocPiano.nhap();
                danhSach.Add(hocPiano.MaHocVien, hocPiano);
            }
        }
        public void xuat()
        {
            foreach (HocVien hoc in danhSach.Values)
                hoc.xuat();
        }
        public double tongHocPhi()
        {
            double tong = 0;
            foreach(HocVien hocVien in danhSach.Values)
            {
                if (hocVien is HocGuitar)
                    tong += ((HocGuitar)hocVien).tinhHocPhi();
                if (hocVien is HocPiano)
                    tong += ((HocPiano)hocVien).tinhHocPhi();
            }
            return tong;
        }
        public HocVien timHocVienMayMan(String maHocVien)
        {
            if(danhSach.ContainsKey(maHocVien))
                return danhSach[maHocVien];
            return null;
        }
    }
}
