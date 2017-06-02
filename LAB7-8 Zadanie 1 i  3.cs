using System;

namespace ConsoleApp2
{
    class Program
    {
        class punkt
        {
            private double x;
            private double y;

            public double X
            {
                get { return x;  }
                set { x = value;  }
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
            


        }

        

        public void viewboard()
        {
            Console.WriteLine(" {0} | {1} | {2} | {3} | {5} |")
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Punkt");
            punkt A = new punkt(5.3, 4.22);
            A.wspolrzedne();

            // Użycie akcesora set
            A.X = 4.22;
            A.Y = 5.3;

            // Użycie akcesora get
            Console.WriteLine("{0} , {1}", A.X, A.Y);

            // Modyfikowanie wektorem
            A.dodajwektor(B);

            // Wyświetlanie
            A.wspolrzedne();

            Console.ReadKey();

            // Klasę wykorzystać napisania prostej gry w statki

        }
    }
}