using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so nguyen: ");
            int n = int.Parse(Console.ReadLine());
            bool check=true;
            if (n < 2)
                check = false;
            else
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        check = false;
                        break;
                    }
                }
            }
            if (check)
                Console.WriteLine("So da nhap la so nguyen to !");
            else
                Console.WriteLine("So da nhap khong la so nguyen to !");
            Console.ReadKey();
        }
    }
}
