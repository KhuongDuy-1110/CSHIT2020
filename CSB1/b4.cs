using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = 0, s2 = 1, s3 = 0;
            Console.Write("Nhap vao 1 so tu nhien: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                s1 += i;
                s2 *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                s3 += (i - 1) * i;
            }
            Console.WriteLine("S1= {0}", s1);
            Console.WriteLine("S2= {0}", s2);
            Console.WriteLine("S3= {0}", s3);
            Console.ReadKey();
        }
    }
}
