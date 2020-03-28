using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    public class HangHoa
    {
        string mahang;
        string tenhang;
        float dongia;
        int soluong;

        public string Mahang { get => mahang; set => mahang = value; }
        public string Tenhang { get => tenhang; set => tenhang = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public int Soluong { get => soluong; set => soluong = value; }

        public void nhap(HangHoa hanghoa)
        {
            //HangHoa hanghoa = new HangHoa();
            Console.Write("Nhap ma hang: ");
            hanghoa.Mahang = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            hanghoa.Tenhang = Console.ReadLine();
            Console.Write("Nhap don gia: ");
            hanghoa.Dongia = float.Parse(Console.ReadLine());
            Console.Write("Nhap so luong: ");
            hanghoa.Soluong = int.Parse(Console.ReadLine());
        }
        /*public float thanhtien()
        {
            return Dongia * Soluong;
        }*/
        public void xuat(HangHoa hanghoa)
        {
            //float thanhtien = hanghoa.Dongia * hanghoa.Soluong;
            Console.WriteLine("Ma hang: " + hanghoa.Mahang + "; " + "Ten hang: " + hanghoa.Tenhang + "; " +
                "Don gia: " + hanghoa.Dongia + "; " + "So luong: " + hanghoa.Soluong + "; " + "Thanh tien: " +
                hanghoa.Dongia*hanghoa.Soluong);
        }
        public static void sapxep (List<HangHoa> hanghoa, int n)
        {
            //HangHoa a = new HangHoa();
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if(hanghoa[j].Dongia*hanghoa[j].Soluong<hanghoa[i].Dongia*hanghoa[i].Soluong)
                    {
                        HangHoa temp = hanghoa[j];
                        hanghoa[j] = hanghoa[i];
                        hanghoa[i] = temp;
                    }
                }
            }
        }
    }
}
