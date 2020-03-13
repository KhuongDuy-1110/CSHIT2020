using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n = int.Parse(Console.ReadLine());
                int org = n;
                string msg = "1 x";
                for (int i = 2; n!=0&&i<=n; i++)
                    while(n!=0&&n%i==0)
                    {
                        msg += i + "x";
                        n /= i;
                    }
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }
    }
}
