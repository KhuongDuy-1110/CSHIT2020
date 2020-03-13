using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao 5 so a,b,c,d,e ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int fmax, smax;
            fmax = a;
            if (b > fmax)
                fmax = b;
            if (c > fmax)
                fmax = c;
            if (d > fmax)
                fmax = d;
            if (e > fmax)
                fmax = e;
            smax = a;
            if (b < fmax && b > smax)
                smax = b;
            if (c < fmax && c > smax)
                smax = c;
            if (d < fmax && d > smax)
                smax = d;
            if (e < fmax && e > smax)
                smax = e;
            Console.WriteLine();
            Console.WriteLine("So lon thu 2 la: ");
            Console.WriteLine(smax);
            Console.ReadKey();
        }
    }
}
