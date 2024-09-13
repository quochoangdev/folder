using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_midTermTest
{
    class DSHocVien
    {
        Dictionary<string, HocVien> danhSach;
        public DSHocVien()
        {
            DanhSach = new Dictionary<string, HocVien>();
        }
        internal Dictionary<string, HocVien> DanhSach { get => danhSach; set => danhSach = value; }

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Write("Nhập G cho học viên Guitar, P cho học viên Piano, Nhập 0 để thoát");
                string K = Console.ReadLine().ToUpper();
                if (K == "0") break;
                if (K == "G")
                {
                    HocVien NV = new HocGuitar();
                    NV.Nhap();
                    DanhSach.Add(NV.MaHocVien, NV);
                }
                if (K == "P")
                {
                    HocVien NV = new HocPiano();
                    NV.Nhap();
                    DanhSach.Add(NV.MaHocVien, NV);
                }
            }
        }

        public void Xuat()
        {
            foreach(HocVien item in DanhSach.Values)
            {
                item.Xuat();
            }
        }

        public double TongHocPhi()
        {
            double tongHocPhi = 0;
            foreach(HocVien item in DanhSach.Values)
            {
                // Cach 1
                ITienHocPhi hocPhiCalculator = (ITienHocPhi)item;
                tongHocPhi += hocPhiCalculator.TinhHocPhi();
                // Cach 2
                //if (item is HocGuitar)
                //    tongHocPhi = tongHocPhi + ((HocGuitar)item).TinhHocPhi();
                //else if(item is HocPiano)
                //    tongHocPhi = tongHocPhi + ((HocPiano)item).TinhHocPhi();
            }
            return tongHocPhi;
        }

        public HocVien TimHVMayMan()
        {
            Console.Write("Nhập vào mã học viên may mắn: ");
            string hvMayMan = Console.ReadLine();
            bool tim = false; HocVien hocVienMM = null;
            foreach (HocVien item in DanhSach.Values)
            {
                if(item.MaHocVien == hvMayMan)
                {
                    tim = true;
                    hocVienMM = item;
                    Console.Write("Có học viên may mắn cần tìm");
                    item.Xuat();
                    break;
                }
            }
            if(tim == false) Console.Write("Không có học viên may mắn cần tìm");
            return hocVienMM;
        }
    }
}
