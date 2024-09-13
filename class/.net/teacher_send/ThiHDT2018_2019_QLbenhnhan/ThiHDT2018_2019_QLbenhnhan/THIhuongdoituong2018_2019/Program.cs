using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIhuongdoituong2018_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DSBENHNHAN danhsach = new DSBENHNHAN();
            int option;
            do
            {
                Console.WriteLine("Nhập 1 để Nhập, 2 để Xuất, 3 để Tìm, 4 để Xóa, 5 để Sửa, 6 để thêm, 7 để tính tổng tiền, 0 để Thoát");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 0: break;
                    case 1: danhsach.Nhap(); break;
                    case 2: danhsach.Xuat(); break;
                    //danhsach.ToString();
                    case 3: Console.WriteLine("Nhập mã bệnh nhân cần tìm");
                            string bnT = Console.ReadLine();
                            danhsach.Tim(bnT); break;
                    case 4: Console.WriteLine("Nhập mã bệnh nhân cần xóa");
                            string bnX = Console.ReadLine();
                            danhsach.Xoa(bnX); break;
                        //danhsach.Xuat();
                    case 5: Console.WriteLine("Nhập mã bệnh nhân cần sửa");
                            string bnS = Console.ReadLine();
                            danhsach.Capnhat(bnS); break;
                        //danhsach.Xuat();
                    case 6: Console.WriteLine("\n Nhập mã bệnh nhân cần thêm");
                            string bnTh = Console.ReadLine();
                            danhsach.Them(bnTh); break;
                    case 7: Console.WriteLine("\n Tổng số tiền là " + danhsach.TinhTien()); break;
                    default: Console.WriteLine("Bạn chỉ nhập từ 0 đến 7"); break;
                }
            } while (option != 0);
      
            //danhsach.Xuat();
            Console.WriteLine("\n -----------------Chương trình kết thúc-------------------");
            Console.ReadLine();
        }
    }
}
