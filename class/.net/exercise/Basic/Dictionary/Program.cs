using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Dictionary<string, string> danhsach = new Dictionary<string, string>();
            danhsach.Add("CS403", "Cong nghe phan mem");
            danhsach.Add("CS420", "He phan tan");
            danhsach.Add("SE445", "Tich hop he thong");
            if (danhsach.ContainsValue("Ky thuat TMDT"))
                Console.WriteLine("Co mon KT TMDT trong danh sach");
            else danhsach.Add("IS385", "Ky Thuat TMDT");
            Console.WriteLine("---------Xuat danh sach---------");
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Danh sach co {0} mon hoc", danhsach.Count);

            if (danhsach.ContainsValue("Ky Thuat TMDT"))
                danhsach.Remove("IS385");
            Console.WriteLine("-------Xuat danh sach sau khi xoa---------");
            foreach (KeyValuePair<string, string> item in danhsach)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
