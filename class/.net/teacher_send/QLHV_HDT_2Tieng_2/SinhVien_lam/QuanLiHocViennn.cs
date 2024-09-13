using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiHocVien
{
    internal class QuanLiHocViennn
    {
        DanhSachHocVien quanLi = new DanhSachHocVien();
        public void inTongHP()
        {
            Console.WriteLine("Tổng học phí là: " + quanLi.tongHocPhi());
        }
        public double tinhTienThuong(string maHocVien)
        {

            HocVien timDuoc = quanLi.timHocVienMayMan(maHocVien);
            if (timDuoc == null)
                Console.WriteLine("Không có học viên này trong danh sách");
            else
            {
                Console.WriteLine("Học viên may mắn là: ");
                timDuoc.xuat();
                Console.WriteLine("Số tháng: "+timDuoc.thoiGianHoc());
                if (timDuoc is HocGuitar)
                {
                    //Học viên Guitar có ThoiGianHoc( ) > 36 tháng thì thưởng = TinhHocPhi( ) * 0.3, nếu
                    //ThoiGianHoc() > 24 tháng thưởng = TinhHocPhi() * 0.25, ngoài ra thì thưởng =
                    //TinhHocPhi() * 0.2
                    if(timDuoc.thoiGianHoc() > 36)
                        return ((HocGuitar) timDuoc).tinhHocPhi() *0.3;
                    else if(timDuoc.thoiGianHoc() > 24)
                        return ((HocGuitar)timDuoc).tinhHocPhi() * 0.25;
                    return ((HocGuitar)timDuoc).tinhHocPhi() * 0.2;
                }else if(timDuoc is HocPiano)
                {
                    //Học viên Piano có ThoiGianHoc() > 24 tháng thì thưởng = TinhHocPhi() * 0.2, nếu
                    //ThoiGianHoc() > 18 tháng thưởng = TinhHocPhi() * 0.18, ngoài ra thì thưởng =
                    //TinhHocPhi() * 0.15
                    if (timDuoc.thoiGianHoc() > 24)
                        return ((HocPiano)timDuoc).tinhHocPhi() * 0.2;
                    else if (timDuoc.thoiGianHoc() > 18)
                        return ((HocPiano)timDuoc).tinhHocPhi() * 0.18;
                    return ((HocPiano)timDuoc).tinhHocPhi() * 0.15;
                }
            }
            return 0;
        }
        public void luaChon()
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine("Nhập 0: thoát, 1: Nhập, 2: Xuất, 3: Tổng HP, 4: Thưởng HV may mắn");
                string lc = Console.ReadLine();
                if (lc == "0")
                    break;
                if (lc == "1")
                    quanLi.nhap();
                if (lc == "2")
                    quanLi.xuat();
                if (lc == "3")
                   inTongHP();
                if(lc == "4")
                {
                    Console.WriteLine("Nhập mã học viên may mắn: ");
                    string mahv = Console.ReadLine();
                    double tienThuong = tinhTienThuong(mahv);
                    if (tienThuong != 0)
                    {
                        Console.WriteLine("Tiền thưởng là: "+tienThuong);
                    }
                }
            }
        }
    }
}
