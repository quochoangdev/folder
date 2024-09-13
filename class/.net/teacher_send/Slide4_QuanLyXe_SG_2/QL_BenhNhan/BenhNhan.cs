using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_BenhNhan
{
    abstract class BenhNhan
    {
        String maBN;
        String hoTen;

        public string MaBN { get => maBN; set => maBN = value; }
        public BenhNhan(){}
        public BenhNhan(string maBN, string hoTen)
        {
            this.maBN = maBN;
            this.hoTen = hoTen;
        }
        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã NV: "); MaBN = Console.ReadLine();
            Console.WriteLine("Nhập họ tên: "); hoTen = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập mã NV: {0}", MaBN);
            Console.WriteLine("Nhập họ tên: {0}", hoTen);
        }
        public abstract double TinhVienPhi();
    }
}
