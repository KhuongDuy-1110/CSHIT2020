using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Phieu
    {
        string maphieu;
        string ngay;

        public Phieu()
        {
            Maphieu = "CARDCODE";
            Ngay = "00/00/0000";
        }

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Ngay { get => ngay; set => ngay = value; }

        public void nhap(Phieu phieu)
        {
            Console.Write("Ma phieu: ");
            phieu.Maphieu = Console.ReadLine();
            Console.Write("Ngay kiem ke: ");
            phieu.Ngay = Console.ReadLine();
        }

        public void xuat(Phieu phieu)
        {
            Console.WriteLine("Ma phieu: " + phieu.Maphieu + "      " + "Ngay kiem ke: " + phieu.Ngay);
        }
    }
}
