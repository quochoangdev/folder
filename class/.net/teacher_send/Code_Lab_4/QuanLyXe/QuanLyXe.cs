﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXe
{
    class QuanLyXe
    {
        Dictionary<string, Xe> listXe;

        internal Dictionary<string, Xe> ListXe
        {
            get { return listXe; }
            set { listXe = value; }
        }
                
        public QuanLyXe()
        {
            listXe = new Dictionary<string, Xe>();
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
           while(true)
           {
               Console.WriteLine("Nhập 0 để thoát, nhập C cho xe chở hàng, D cho xe du lịch");
               string option = Console.ReadLine().ToUpper();
               if (option == "0") break;
               if(option == "C")
               {
                   Xe xe = new XeChoHang();                                                           
                   while (true)
                   {
                       try
                       {
                           xe.Nhap(); ListXe.Add(xe.BienSo, xe);
                           break;
                       }                      
                       catch (Exception)
                       {
                           Console.WriteLine("Nhập bị lỗi trùng biển số hoặc lỗi ngày tháng"); 
                       }                      
                   }
               }
               if (option == "D")
               {
                   Xe xe = new XeDuLich();   
                   while (true)
                   {
                       try
                       {
                           xe.Nhap(); ListXe.Add(xe.BienSo, xe);
                           break;
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("Nhập bị lỗi trùng biển số hoặc lỗi ngày tháng");
                       }
                   }
               }
           }
        }
        public void Xuat()
        {
            foreach(Xe item in ListXe.Values)
            {
                item.Xuat();
            }
        }
        int p = 0;
        public void Tim()
        {
            Console.WriteLine("------------------------------Nhập biển số xe cần tìm--------------- ");
            string bienSoTim = Console.ReadLine();
            //Console.ReadLine();
            Xe xeTim = null;
            foreach (Xe item in ListXe.Values)
            {
                if (item.BienSo == bienSoTim)
                {
                    Console.WriteLine("----------có biển số cần tìm, nhấn Enter để tiếp tục------------------");
                    Console.ReadLine();
                    xeTim = item;
                    p = 1;          // Nếu ko có p = 1 thì p luôn là 0 và sẽ xuất ra dòng cảnh báo ở lệnh if(p == 0) 
                    break;
                }
                else
                {
                    p = 0;
                }
            }
            if (p == 1)
            {
                Console.WriteLine("------thông tin xe cần tìm là: -------");
                xeTim.Xuat();  // Xuất ra chỉ một chiếc xe đã tìm thấy
            }
            else
            {
                Console.WriteLine("không có xe cho thuê cần tìm........");
            }
        }                                                                                       // Hết câu 4
        int thue = 0;   // dùng tim cho phương thức TimXeThue( ) và phương thức KiemTra( )
        public Xe TimXeThue()                                 ////////// Cách 1
        {
            Console.WriteLine("------------------------------Nhập biển số xe cần tìm để cho thuê---------------");
            string bienSo = Console.ReadLine();
            //Console.ReadLine();
            Xe xe = null;
            foreach (Xe item in ListXe.Values)
            {
                if (item.BienSo == bienSo)
                {
                    Console.WriteLine("----------Có biển số cần tìm, nhấn Enter để tiếp tục------------------");
                    Console.ReadLine();
                    xe = item;
                    thue = 1;          // Nếu ko có tim = 1 thì tim luôn là 0 và sẽ xuất ra dòng cảnh báo ở lệnh if(tim == 0) 
                    break;
                }
                else
                {
                    thue = 0;
                }
            }
            if (thue == 1)
            {
                Console.WriteLine("------thông tin xe cho thuê cần tìm là: -------");
                xe.Xuat();   /////// Mục đích là xuất nhân viên này ngay trong phương thức Tim() này  // và bên hàm main ko gọi lại
                             // Nếu gọi lại thì khi ko tìm thấy sẽ bị lỗi vì ko có xe nào trong hàm foreach
                return xe;
            }
            else
            {
                Console.WriteLine("không có xe cho thuê cần tìm........");
                return null;
            }
        }
        public bool KiemTraTim()          // dùng cho lớp HopDongChothue
        {
            if (thue == 1) return true;
            else return false;
        }
       
        public void Xoa()                                 ////////// Cách 1
        {
            Console.WriteLine("------------------Nhập biển số xe cần xóa--------------------");
            string bienSoXoa = Console.ReadLine();
            int p = 0;
            foreach (Xe item in ListXe.Values)
            {
                if (item.BienSo == bienSoXoa)
                {
                    Console.WriteLine("-----------có biển số cần xóa-------------nhấn Enter để tiếp tục--");
                    this.ListXe.Remove(bienSoXoa);
                    Console.ReadLine();                
                    p = 1;
                    break;
                }
                else  p = 0; 
            }
            if(p == 1)
            {
                Console.WriteLine("------------------Danh sách sau khi xóa xe có biển số {0} ", bienSoXoa);
                Xuat();
            }
            if (p == 0)
            {
                Console.WriteLine("---Không có xe mang biển số {0} cần xóa, danh sách sau khi xóa vẫn giữ nguyên-- \nNhấn Enter để tiếp tục", bienSoXoa);
                Console.ReadLine();
            }
        }
    }
}
