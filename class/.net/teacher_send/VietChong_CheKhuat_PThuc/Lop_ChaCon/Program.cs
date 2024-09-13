using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lop_ChaCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //CON1 con = new CON1();
            //con.Xuat();
            CHA con = new CON1();
            con.Xuat();
            Console.ReadLine();
        }
    }
}
