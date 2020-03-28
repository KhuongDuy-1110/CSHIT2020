using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    public class TamThucBac2
    {
        float a, b, c;

        public TamThucBac2()
        {
            A = 1;
            B = 1;
            C = 0;
        }

        public TamThucBac2(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public float A { get => a; set => a = value; }
        public float B { get => b; set => b = value; }
        public float C { get => c; set => c = value; }

        public void xuat(TamThucBac2 x)
        {
            Console.WriteLine(x.A + "X2" +" + "+ x.B + "X" +" + "+ x.C);
        }

        public static TamThucBac2 operator -(TamThucBac2 x)
        {
            TamThucBac2 d = new TamThucBac2();
            d.A = -x.A;
            d.B = -x.B;
            d.C = -x.C;
            return d;
        }

        public static TamThucBac2 operator +(TamThucBac2 x, TamThucBac2 y)
        {
            TamThucBac2 z = new TamThucBac2();
            z.A = x.A + y.A;
            z.B = x.B + y.B;
            z.C = x.C + y.C;
            return z;
        }

        public static TamThucBac2 operator -(TamThucBac2 x, TamThucBac2 y)
        {
            TamThucBac2 q = new TamThucBac2();
            q.A = x.A - y.A;
            q.B = x.B - y.B;
            q.C = x.C - y.C;
            return q;
        }
    }
}
