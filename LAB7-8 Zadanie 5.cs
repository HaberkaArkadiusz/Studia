using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        class punkt
        {
            private double x;
            private double y;

            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }

            public punkt(double a, double b)
            {
                x = a;
                y = b;
            }

            public void dodajwektor(punkt b)
            {
                x += b.x;
                y += b.y;
            }

            public void wspolrzedne()
            {
                Console.WriteLine("{0} , {1}", x, y);
            }

            static public bool jednoliniowe(punkt[] a)
            {
                double r;
                r = (a[0].Y - a[1].Y) / (a[0].X - a[1].X);
                double b;
                b = a[1].Y - r * a[1].X;

                if (a[2].Y == r * a[2].X + b)
                    return true;
                else
                    return false;
            }
        }

        class Odcinek
        {
            private punkt a;
            private punkt b;
            
            public punkt A
            {
                get { return a; }
            }

            public punkt B
            {
                get { return b; }
            }

            public Odcinek(punkt x, punkt y)
            {
                a = x;
                b = y;
            }

            public double dlugosc()
            {
                double d;
                d = Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2);
                return Math.Sqrt(d);
            }
            

        }


        static void Main(string[] args)
        {
            punkt A = new punkt(5.3, 2.0);
            punkt B = new punkt(2.3, 33.2); 

            Odcinek C = new Odcinek(A, B);

            Console.WriteLine("Punkty:");
            Console.WriteLine("A:  {0} , {1}", A.X, A.Y);
            Console.WriteLine("B:  {0} , {1}", B.X, B.Y);

            Console.WriteLine("Odleglosc miedzy punktami: {0}", C.dlugosc());
            Console.ReadKey();


        }
    }
}
