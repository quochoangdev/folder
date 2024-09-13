using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaCon
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //CON1 con = new CON1();
            //con.Xuat();
            CHA chau = new CON1();
            chau.Xuat();
            Console.ReadLine();
        }
    }
}
