using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
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
}
