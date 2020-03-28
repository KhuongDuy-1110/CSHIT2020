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
            int n;
            Console.Write("Nhap so luong hang hoa: ");
            n = int.Parse(Console.ReadLine());
            List<HangHoa> hanghoas = new List<HangHoa>();
            
            for (int i = 0; i < n; i++)
            {
                HangHoa hanghoa = new HangHoa();
                hanghoa.nhap(hanghoa);
                hanghoas.Add(hanghoa);
                Console.WriteLine();
            }
            Console.WriteLine("==========");
            HangHoa.sapxep(hanghoas, n);
            foreach(HangHoa x in hanghoas )
            {
                HangHoa t = new HangHoa();
                t.xuat(x);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
