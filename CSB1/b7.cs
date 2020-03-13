using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            int tu = 1, mau = 1;
            float s = 0, tg = 1;
            Console.WriteLine("Nhap so nguyn x, so thuc c: ");
            int x = int.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            for (int i = 1; tg<c; i++)
            {
                tg =Math.Abs((float)tu / mau);
                s += tg;
                tu *= x;
                mau *= i;
            }
            Console.WriteLine("e^x= {0}", s);
            Console.ReadKey();
        }
    }
}
