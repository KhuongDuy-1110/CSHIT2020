using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            TamThucBac2 a = new TamThucBac2(4, 3, 1);
            TamThucBac2 b = new TamThucBac2(2, 5, 1);
            TamThucBac2 re1 = new TamThucBac2();
            TamThucBac2 re2 = new TamThucBac2();
            TamThucBac2 intv1 = new TamThucBac2();
            TamThucBac2 intv2 = new TamThucBac2();
            intv1 = -a;
            intv2 = -b;
            intv1.xuat(intv1);
            intv2.xuat(intv2);
            re1 = intv1 + intv2;
            Console.WriteLine("a+b : ");
            re1.xuat(re1);
            re2 = intv1 - intv2;
            Console.WriteLine("a-b : ");
            re2.xuat(re2);
            Console.ReadKey();
        }
    }
}
