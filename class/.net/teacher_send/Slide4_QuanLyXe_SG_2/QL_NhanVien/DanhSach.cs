using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien
{
    internal class DanhSach
    {
        Dictionary<String, NhanVien> ds;// = new Dictionary<string, NhanVien>();
        internal Dictionary<string, NhanVien> Ds { get => ds; set => ds = value; }
        public DanhSach()
        {
            Ds = new Dictionary<string, NhanVien>();
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Cách 1
            //while (true)
            //{
            //    Console.WriteLine("Nhập 0: thoát \t B : Biên Chế \t H: Hợp Đồng");
            //    String nhap = Console.ReadLine().ToUpper();
            //    NhanVien n = null;
            //    if (nhap == "0") break;
            //    if (nhap == "B")
            //        n = new NV_BienChe();
            //    else if (nhap == "H")
            //        n = new NV_HopDong();
            //    n.Nhap();
            //    try
            //    {
            //        Ds.Add(n.MaNV, n);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Nhập bị trùng mã, nhập lại");
            //    }
            //}
            // Cách 2
            Ds.Add("B1", new NV_BienChe("B1", "Biên Chế 1", DateTime.Parse("11/11/2021"), "Nam",
                "11111", 1.5, 1000));
            Ds.Add("H2", new NV_HopDong("H2", "Hợp Đồng 2", DateTime.Parse("12/12/2022"), "Nữ",
               "22222", 1200));
            Ds.Add("B4", new NV_BienChe("B3", "Biên Chế 3", DateTime.Parse("03/03/2023"), "Nữ",
                "33333", 2.5, 1300));
            Ds.Add("H3", new NV_HopDong("H3", "Hợp Đồng 3", DateTime.Parse("03/03/2023"), "Nam",
              "44444", 1400));
            Ds.Add("B5", new NV_BienChe("B5", "Biên Chế 5", DateTime.Parse("05/05/2025"), "Nữ",
               "55555", 2.34, 1300));
            Console.WriteLine("Nhập thành công");
        }
        public void Xuat()
        {
            foreach (NhanVien n in Ds.Values)
                n.Xuat();
        }
        public double TinhTong(){
            double tong = 0;
            foreach (NhanVien item in Ds.Values)
                if (item is NV_BienChe)
                { // new NV_BienChe
                    if (((NV_BienChe)item).HeSoLuong < 2) // dowcasting
                        tong = tong + item.ThucLinh() + 200;
                    else tong = tong + item.ThucLinh();
                }
                else if (item is NV_HopDong && ((NV_HopDong)item).MucLuong < 3000)
                    tong = tong + item.ThucLinh() + 300;
                else tong = tong + item.ThucLinh();
            //Console.WriteLine("Tổng lương là: {0}", tong);
            return tong;
        }
        public double TongPhuCap()
        {
            double tongPC = 0;
            foreach (NhanVien item in Ds.Values)
            {
                //if (item is NV_BienChe)
                //    tongPC = tongPC + ((NV_BienChe)item).PhuCap();
                //else if (item is NV_HopDong)
                //    tongPC = tongPC + ((NV_HopDong)item).PhuCap();
                IPhuCap iPC = item as IPhuCap;
                tongPC = tongPC + iPC.PhuCap();
            }
            return tongPC;
        }
        public void Loc1(){   // DS những NV Bien Che có HS Luong > 2
            Dictionary<String, NhanVien> dsLoc1 = new Dictionary<string, NhanVien> ();
            foreach(NhanVien b in Ds.Values){
                if (b is NV_BienChe && ((NV_BienChe)b).HeSoLuong > 2)
                    dsLoc1.Add(b.MaNV, b);
            }
            Console.WriteLine("--------Xuất danh sách Lọc 1");
            foreach (NV_BienChe b in dsLoc1.Values)
                b.Xuat();
        }
        public Dictionary<String, NhanVien> Loc2(){   //.. y như Lọc 1
            Dictionary<String, NhanVien> dsLoc1 = new Dictionary<string, NhanVien>();
            foreach (NhanVien b in Ds.Values)
            {
                if (b is NV_BienChe && ((NV_BienChe)b).HeSoLuong > 2)
                    dsLoc1.Add(b.MaNV, b);
            }
            Console.WriteLine("Xuất danh sách lọc 2");
            return dsLoc1;
        }
    }
}
