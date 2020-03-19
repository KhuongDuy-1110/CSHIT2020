using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static double exp1(float x, int k)
        {
            double gt = 1;
            double s1 = 0;
            for (int i = 1; i <= k ; i++)
                gt *= x;
            s1 = Math.Sqrt(gt);
            return s1;
        }
        static double exp2(float a, float x, int n )
        {
            double s = a;
            int gt1 = -1;
            for (int i = 0; i <= n; i++)
            {
                gt1 *= -1;
                s += gt1 * (exp1(x, i) / (n - i + 1));
            }
            return s;
        }
        static void Main(string[] args)
        {
            float a, x;
            int n;
            Console.Write("Nhap vao so thuc A: ");
            a = float.Parse(Console.ReadLine());
            do
            {
                Console.Write("Nhap vao so x (x>0): ");
                x = float.Parse(Console.ReadLine());
                Console.Write("Nhap vao so n (5<=n<=20): ");
                n = int.Parse(Console.ReadLine());
                if (x <= 0 || n < 5 || n > 20)
                    Console.WriteLine("Ktra dieu kien va nhap lai: ");
            } while (x<=0||n<5||n>20);
            Console.WriteLine("S= " + exp2(a, x, n));
            Console.ReadKey();
        }
    }
}
