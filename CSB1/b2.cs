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
            Console.WriteLine("Nhap vao lan luot do dai x, y, z: ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = float.Parse(Console.ReadLine());
            if ((x + y) > z && (x + z) > y && (y + z) > x)
            {
                Console.WriteLine("Do dai 3 canh tao thanh 1 tam giac !");
                if (x == y || x == z || y == z)
                {
                    if (x == y && x == z)
                        Console.WriteLine("La tam giac deu !");
                    else
                        Console.WriteLine("La tam giac can");
                }
                if ((x * x + y * y) == z * z || (x * x + z * z) == y * y || (y * y + z * z) == x * x)
                {
                    Console.Write(" La tam giac vuong ");
                    if (x == y || x == z || y == z)
                        Console.WriteLine("can !");
                }
            }
            else
                Console.WriteLine("3 do dai tren khong tao thanh 1 tam giac !");
            Console.ReadKey();
        }
    }
}
