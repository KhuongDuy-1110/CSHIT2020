using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Cac uoc cua {0} la: 1", n);
            for (int i = 2; i <=n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(", ");
                    Console.Write(i);
                }
            }
            Console.ReadKey();
        }
    }
}
