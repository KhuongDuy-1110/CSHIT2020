using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void nhap(out int n)
        {
            Console.Write("Nhap vao n: ");
            n = int.Parse(Console.ReadLine());
        }
        static void nhapmang(int[] a, int n)
        {
            Console.WriteLine("Nhap vao mang co n phan tu: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int snt(int k)
        {
            if (k < 2)
                return 1;
            else
            {
                for (int i = 2; i <= k/2; i++)
                {
                    if (k % i == 0)
                        return 1;
                }
                return 0;
            }
        }
        static void duyetmang(int[] a, int n)
        {
            Console.WriteLine("Cac gia tri tmdk: ");
            for (int i = 0; i < n; i++)
            {
                if (snt(i) == 0)
                    Console.Write(" " + a[i]);
            }
        }
        static void Main(string[] args)
        {
            int n;
            //int[] a;
            nhap(out n);
            int[] a = new int[n];
            nhapmang(a, n);
            duyetmang(a, n);
            Console.ReadKey();
        }
    }
}
