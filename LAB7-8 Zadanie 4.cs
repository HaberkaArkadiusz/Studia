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


        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wspołrzędną x punktu 1:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wspołrzędną y punktu 1:");
            double y = Convert.ToDouble(Console.ReadLine());
            punkt A = new punkt(x, y);

            Console.WriteLine("Podaj wspołrzędną x punktu 2:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wspołrzędną y punktu 2:");
            y = Convert.ToDouble(Console.ReadLine());
            punkt B = new punkt(x, y);

            Console.WriteLine("Podaj wspołrzędną x punktu 3:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wspołrzędną y punktu 3:");
            y = Convert.ToDouble(Console.ReadLine());
            punkt C = new punkt(x, y);

            A.wspolrzedne();
            B.wspolrzedne();
            C.wspolrzedne();

            punkt[] tab = new punkt[3];
            tab[0] = A;
            tab[1] = B;
            tab[2] = C;
            Console.WriteLine(Convert.ToString(punkt.jednoliniowe(tab)));

            Console.ReadKey();


        }
    }
}
