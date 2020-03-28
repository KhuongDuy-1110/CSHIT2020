using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    public class Phong
    {
        string tenphong;
        string truongphong;
        string maphong;

        public Phong()
        {
            Tenphong = "ROOMNAME";
            Truongphong = "NAME";
            Maphong = "ROOMCODE";
        }

        public string Tenphong { get => tenphong; set => tenphong = value; }
        public string Truongphong { get => truongphong; set => truongphong = value; }
        public string Maphong { get => maphong; set => maphong = value; }

        public void nhap(Phong phong)
        {
            Console.Write("Ten phong: ");
            phong.Tenphong = Console.ReadLine();
            Console.Write("Truong phong: ");
            phong.Truongphong = Console.ReadLine();
            Console.Write("Ma phong: ");
            phong.Maphong = Console.ReadLine();
        }

        public void xuat(Phong phong)
        {
            Console.WriteLine("Kiem ke tai phong: " + phong.Tenphong + "      " + "Ma phong: " + phong.Maphong);
            Console.WriteLine("Truong phong: " + phong.Truongphong);
        }
    }
}
