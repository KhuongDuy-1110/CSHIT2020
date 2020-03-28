using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, tong=0;
            Phong phong = new Phong();
            NhanVien nhanVien = new NhanVien();
            Phieu phieu = new Phieu();
            phieu.nhap(phieu);
            nhanVien.nhap(nhanVien);
            phong.nhap(phong);
            Console.Write("So luong tai san kiem ke: ");
            n = int.Parse(Console.ReadLine());
            List<Hang> hangs = new List<Hang>();
            for (int i = 0; i < n; i++)
            {
                Hang hang = new Hang();
                hang.nhap(hang);
                hangs.Add(hang);
                Console.WriteLine();
            }
            Console.WriteLine("=============");
            phieu.xuat(phieu);
            nhanVien.xuat(nhanVien);
            phong.xuat(phong);
            Console.WriteLine("Ten hang -" + "  So luong -" + "  Tinh trang");
            Console.WriteLine();
            foreach (Hang x in hangs)
            {
                tong += x.Soluong;
                x.xuat(x);
            }
            Console.WriteLine("So tai san da kiem ke: " + n + "      " + "Tong so luong: " + tong);
            Console.ReadKey();
        }
    }
}
