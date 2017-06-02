using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        class Prostokat
        {
            public double dlugosc;
            public double szerokosc;

            public Prostokat(double a, double b)
            {
                dlugosc = a;
                szerokosc = b;
            }

            private double powierzchnia()
            {
                return dlugosc * szerokosc;
            }
            
            private double obwod()
            {
                return 2 * dlugosc + 2 * szerokosc;
            }

            public void prezentuj()
            {
                Console.WriteLine("Powierzchnia: {0} ", powierzchnia());
                Console.WriteLine("Obwod: {0} ", obwod());

            }

        }
        static void Main(string[] args)
        {
            Prostokat gawel = new Prostokat(20.1, 15.2);
            gawel.prezentuj();
            Console.ReadKey();
        }
    }
}
