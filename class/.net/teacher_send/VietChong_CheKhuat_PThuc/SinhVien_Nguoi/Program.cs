using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien_Nguoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //SinhVien SV = new SinhVien();
            Nguoi SV = new SinhVien();
            SV.Xuat();
            Console.ReadLine();
        }
    }
}
