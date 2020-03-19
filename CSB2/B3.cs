using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static string[] full(string a)
        {
            string[] arr;
            return arr = a.Split(' ');
        }
        static void disp(string a)
        {
            Console.WriteLine("Ho: " + full(a)[0]);
            Console.WriteLine("Ten dem: " + full(a)[full(a).Length - 3]);
            Console.WriteLine("Ten: " + full(a)[full(a).Length - 2]);
            Console.WriteLine("Nam sinh: " + full(a)[full(a).Length - 1]);
        }
        static int age(string a)
        {
            return 2020-int.Parse(full(a)[full(a).Length - 1]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ho + Dem + Ten + NamSinh: ");
            string a = Console.ReadLine();
            //Console.WriteLine(a);
            Console.WriteLine("==========");
            full(a);
            disp(a);
            Console.WriteLine("Tuoi: " + age(a));          
            Console.ReadKey();
        }
    }
}
