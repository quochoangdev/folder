using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_HDT_2Tieng
{
    class DanhSachHocVien
    {
        Dictionary<string, HocVien> danhsach;
        public DanhSachHocVien()
        {
            danhsach = new Dictionary<string, HocVien>();
        }
        internal Dictionary<string, HocVien> Danhsach
        {
            get { return danhsach; }
            set { danhsach = value; }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;               
            while(true)
            {
                Console.WriteLine("Nhập G cho học viên Guitar, P cho học viên Piano, nhập 0 để thoát");  
                string K = Console.ReadLine().ToUpper();
                if (K == "0") break;
                if (K == "G")
                {
                    HocVien NV = new HocVienGuitar();
                    NV.Nhap();
                    Danhsach.Add(NV.MaHocVien, NV);
                }
                if (K == "P")
                {
                    HocVien NV = new HocVienPiano();
                    NV.Nhap();
                    Danhsach.Add(NV.MaHocVien, NV);
                }
            }
        }
        public void Xuat()
        {
            foreach (HocVien item in Danhsach.Values)
                item.Xuat();
        }
        public double TongHocPhi()
        {
            double tongHocPhi = 0;
            foreach(HocVien item in danhsach.Values)
            {
                // Cách 1
                ITienHocPhi IT = item as ITienHocPhi;
                tongHocPhi = tongHocPhi + IT.TinhHocPhi();

                // Cach 2
                //if (item is HocVienGuitar)
                //    tongHocPhi = tongHocPhi + ((HocVienGuitar)item).TinhHocPhi(); 
                //else if (item is HocVienPiano)
                //    tongHocPhi = tongHocPhi + ((HocVienPiano)item).TinhHocPhi();
            }
            return tongHocPhi;
        }
        public HocVien TimHVMayMan()
        {           
            Console.Write("Nhập vào mã học viên may mắn: ");
            string hvMayMan = Console.ReadLine();
            int tim = 0; HocVien hocvienMM = null;
            foreach(HocVien item in danhsach.Values)
            {
                if (item.MaHocVien == hvMayMan)
                {
                    tim = 1;
                    hocvienMM = item;
                    Console.WriteLine("Có học viên may mắn cần tìm");
                    item.Xuat();     //hocvienMM.Xuat();
                    break;
                }// else tim = 0;
            }
            if (tim == 0) Console.WriteLine("Không có học viên may mắn cần tìm");
            return hocvienMM;
        }
    }
}
