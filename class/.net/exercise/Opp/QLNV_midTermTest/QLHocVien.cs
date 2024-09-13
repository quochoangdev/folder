using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_midTermTest
{
    class QLHocVien
    {
        DSHocVien DS = new DSHocVien();

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

            if(hvMM is HocGuitar)
            {

            }
        }
    }
}
