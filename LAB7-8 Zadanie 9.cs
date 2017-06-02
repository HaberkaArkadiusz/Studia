using System;

namespace ConsoleApplication6
{
    class Program
    {

        public class Prostokat
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

        public static double biggest_area(Prostokat[] tab)
        {
            double max = 0;
            foreach(Prostokat item in tab)
            {
                if (item.dlugosc * item.szerokosc > max)
                    max = item.dlugosc * item.szerokosc;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Prostokat gawel = new Prostokat(20.1, 15.2);
            gawel.prezentuj();


            Prostokat[] tablica = new Prostokat[5];
            for (int i = 0; i < 5; i++)
            {
                tablica[i] = new Prostokat((i+5) * 4, -1 * i + 5);
            }

            foreach (Prostokat item in tablica)
            {
                item.prezentuj();
            }

            Console.WriteLine("Najwieksza powierzchnia: {0} ", biggest_area(tablica));

            Console.ReadKey();
        }
    }
}
