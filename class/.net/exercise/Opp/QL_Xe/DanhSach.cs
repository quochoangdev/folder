using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_Xe
{
    internal class DanhSach
    {
        Dictionary<String, Xe> danhSach = new Dictionary<string, Xe>();

        public void Nhap_()
        {
            while (true)
            {
                Console.WriteLine("Nhập 0 để thoát, 1 để thêm xe mới");
                String nhap = Console.ReadLine();
                if (nhap == "0")
                    break;
                else if (nhap == "1")
                {
                    Xe x = new Xe();
                    x.Nhap();
                    danhSach.Add(x.BienSo, x);
                }
            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Xe x = new Xe("001", "Một", DateTime.Parse("11/11/2021"), 10); danhSach.Add("001", x);
            danhSach.Add("002", new Xe("002", "Hai", DateTime.Parse("12/12/2022"), 35));
            danhSach.Add("003", new Xe("003", "Ba", DateTime.Parse("03/03/2023"), 20));
            danhSach.Add("004", new Xe("004", "Bốn", DateTime.Parse("04/04/2024"), 25));
            Console.WriteLine("Nhập thành công");
        }
        public void Xuat()
        {
            foreach (Xe item in danhSach.Values)
            {
                item.Xuat();
            }
        }

        public void Tim()    //Có nhiều cách
        {
            Console.Write("Nhập biển số xe cần tìm: ");
            String bienSoTim = Console.ReadLine();
            /*if (danhSach.ContainsKey(bienSoTim))   // Cách 1
            {
                Console.WriteLine("Có biển số cần tìm, thông tin xe cần tìm là");
                danhSach[bienSoTim].Xuat();
            }
            else Console.WriteLine("Không có xe cần tìm");*/
            int tim = 0;
            foreach (Xe item in danhSach.Values)
            {
                if (item.BienSo == bienSoTim)
                {
                    Console.WriteLine("Có biển số cần tìm, thông tin xe cần tìm là: ");
                    item.Xuat();
                    tim = 1;
                }
            }
            if (tim == 0)
                Console.WriteLine("Không có xe cần tìm");
        }

        public void Xoa()
        {
            Console.Write("Nhập biển số xe cần xoá: ");
            String bienSoXoa = Console.ReadLine();
            if (danhSach.ContainsKey(bienSoXoa))   // Cách 1
            {
                Console.WriteLine("Có biển số cần xoá");
                danhSach.Remove(bienSoXoa);
            }
            Console.WriteLine("DS sau khi xoá");
            Xuat();
            /*
            foreach (Xe item in danhSach.Values)
            {
                if (item.BienSo == bienSoXoa)
                {
                    Console.WriteLine("Có biển số cần xoá");
                    danhSach.Remove(bienSoXoa);
                    break;
                }
            }
             Console.WriteLine("DS sau khi xoá");
             Xuat();*/
        }

        public void Xoa30()  //Xoá những xe có trọng tải < 30
        {
            for (int i = danhSach.Count - 1; i >= 0; i--)
            {
                if (danhSach.Values.ElementAt(i).trongTai < 30)
                    danhSach.Remove(danhSach.Values.ElementAt(i).BienSo);
            }
            Console.WriteLine("DS sau khi xoá các xe ... < 30");
            Xuat();
            // Cách 2
            //ArrayList AL = new ArrayList();
            //foreach(Xe item in danhSach.Values)
            //{
            //    if(item.trongTai < 30)
            //        AL.Add(item.BienSo);
            //}  // Đưa biển số của các xe < 30 tấn vào danh sách AL 
            //foreach(String item in AL)
            //{
            //    danhSach.Remove(item);
            //}  // Xoá theo biển số của các xe có trong danh sách AL
            //Console.WriteLine("DS sau khi xoá các xe ... < 30");
            //Xuat();
        }
    }
}
