using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    public class Hang
    {
        string tenhang;
        int soluong;
        string tinhtrang;

        public Hang()
        {
            Tenhang = "NAME";
            Soluong = 0;
            Tinhtrang = "STATUS";
        }

        public string Tenhang { get => tenhang; set => tenhang = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public void nhap(Hang hang)
        {
            Console.Write("Ten hang: ");
            hang.Tenhang = Console.ReadLine();
            Console.Write("So luong: ");
            hang.Soluong = int.Parse(Console.ReadLine());
            Console.Write("Tinh trang: ");
            hang.Tinhtrang = Console.ReadLine();
        }

        public void xuat(Hang hang)
        {
            //Console.WriteLine("Ten hang  " + "  So luong  " + "  Tinh trang");
            Console.WriteLine(Tenhang + "    " + Soluong + "        " + Tinhtrang);
        }
    }
}
