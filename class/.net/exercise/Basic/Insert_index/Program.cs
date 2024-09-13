using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Dictionary<string, string> danhsach = new Dictionary<string, string>();

            danhsach.Add("CS403", "Công nghệ phần mềm");
            danhsach.Add("CS420", "Hệ phân tán");
            danhsach.Add("SE445", "Tích hợp hệ thống");

            if (danhsach.ContainsValue("Kỹ thuật TMDT"))
                Console.WriteLine("Có môn KT TMDT trong ds");
            else danhsach.Add("IS385", "Kỹ thuật TMDT");

            Console.WriteLine("-------Xuat danh sach---------");
            foreach (KeyValuePair<string, string> item in danhsach)
                Console.WriteLine(item);
            Console.WriteLine("Danh sách có {0} môn học", danhsach.Count);

            //XÓA
            if (danhsach.ContainsValue("Kỹ thuật TMDT"))
                danhsach.Remove("IS385");

            Console.WriteLine("-------Xuat danh sach sau khi xoa---------");
            foreach (KeyValuePair<string, string> item in danhsach)
                Console.WriteLine(item);

            //CHÈN
            Console.Write("Nhập vào vị trí chèn: ");
            int vitri = int.Parse(Console.ReadLine());
            if (vitri == danhsach.Count)
                danhsach.Add("IS385", "Kỹ thuật TMDT");
            else if (vitri < danhsach.Count && vitri >= 0)
            {
                Dictionary<string, string> danhsachNew = new Dictionary<string, string>();
                foreach (var item in danhsach)
                {
                    if (vitri == 0)
                    {
                        danhsachNew.Add("IS385", "Kỹ thuật TMDT");
                        //vitri = vitri - 1; //saii
                    }
                    danhsachNew.Add(item.Key, item.Value);
                    vitri = vitri - 1;
                }
                danhsach = danhsachNew;
            }
            if (vitri > danhsach.Count)
                Console.WriteLine("Vị trí vượt quá giới hạn cùa danh sách");
            else
            {
                Console.WriteLine("Danh sách sau khi chèn");
                foreach (KeyValuePair<string, string> item in danhsach)
                    Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
