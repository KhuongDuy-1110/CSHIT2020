using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class NhanVien
    {
        string tennv;
        string chucvu;

        public NhanVien()
        {
            Tennv = "NAME";
            Chucvu = "POSITION";
        }

        public string Tennv { get => tennv; set => tennv = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public void nhap(NhanVien nhanVien)
        {
            Console.Write("Ten nhan vien: ");
            nhanVien.Tennv = Console.ReadLine();
            Console.Write("Chuc vu: ");
            nhanVien.Chucvu = Console.ReadLine();
        }
        public void xuat(NhanVien nhanVien)
        {
            Console.WriteLine("Nhan vien kiem ke: " + nhanVien.Tennv + "      " + "Chuc vu: " + nhanVien.Chucvu);
        }
    }
}
