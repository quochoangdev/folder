using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    class QuanLyHocVien
    {
        DanhSachHocVien DS = new DanhSachHocVien();
        public void ThucHien()
        {
            DS.Nhap();
            DS.Xuat();
        }
        public void TongHocPhi()
        {
            Console.WriteLine("Tổng học phí là: {0}", DS.TongHocPhi());
        }
        public void TinhTienThuong()
        {
            double tienThuong = 0;
            HocVien hvMM = DS.TimHVMayMan();
                                          //  ITienHocPhi IT = hvMM as ITienHocPhi;  //  cách 2
                                          
            if (hvMM is HocVienGuitar)
            {                           //  if(hvMM is HocVienGuitar GT)// cách 3?
                                        //double t = GT.TinhHocPhi();  //cách 3?
                Console.WriteLine("Số tháng đã học của học"
                    +"viên Guitar may mắn: {0} tháng", hvMM.ThoiGianHoc());
                if (hvMM.ThoiGianHoc() > 36)
                    tienThuong = ((HocVienGuitar)hvMM).TinhHocPhi() * 0.3;
                     //{tienThuong = IT.TinhHocPhi() * 0.3;}  //cách 2
                else if (hvMM.ThoiGianHoc() > 24)
                    tienThuong = ((HocVienGuitar)hvMM).TinhHocPhi() * 0.25;
                else tienThuong = ((HocVienGuitar)hvMM).TinhHocPhi() * 0.2;
            }
            else if (hvMM is HocVienPiano)
            {
                //HocVien HV = new HocVienPiano();
                Console.WriteLine("Số tháng đã học của học viên Piano may mắn: {0} tháng", hvMM.ThoiGianHoc());
                if (hvMM.ThoiGianHoc() > 24)
                    tienThuong = ((HocVienPiano)hvMM).TinhHocPhi() * 0.2;
                else if (hvMM.ThoiGianHoc() > 18)
                    tienThuong = ((HocVienPiano)hvMM).TinhHocPhi() * 0.18;
                else tienThuong = ((HocVienPiano)hvMM).TinhHocPhi() * 0.15;
            }
            Console.WriteLine("Tiền thưởng là: {0}", tienThuong);
        }
    }
}
