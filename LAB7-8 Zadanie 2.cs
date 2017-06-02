using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        class prad
        {
            private double stanpoczatkowy;
            private DateTime datapoczatkowa;
            private double stanbiezacy;
            private DateTime databiezaca;

            public double Stanbiezacy
            {
                get { return stanbiezacy; }
            }
            public double Stanpoczatkowy
            {
                get { return stanpoczatkowy; }
            }
            public DateTime Datapoczatkowa
            {
                get { return datapoczatkowa; }
            }
            public DateTime Databiezaca
            {
                get { return databiezaca; }
            }

            public prad(double a)
            {
                stanpoczatkowy = a;
            }

            public void register()
            {
                Console.WriteLine("Podaj stan początkowy licznika:");
                stanpoczatkowy = Convert.ToDouble(Console.ReadLine());
                datapoczatkowa = takedate();
            }

            public void update()
            {
                Console.WriteLine("Podaj stan biezacy licznika:");
                stanbiezacy = Convert.ToDouble(Console.ReadLine());
                databiezaca = takedate();
            }


            public DateTime takedate()
            {
                Console.WriteLine("Podaj datę:");
                Console.WriteLine("Rok:");
                int rok = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Miesiac:");
                int miesiac = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dzien:");
                int dzien = Convert.ToInt32(Console.ReadLine());

                return new DateTime(rok, miesiac, dzien);
            }


        }



        static void Main(string[] args)
        {
            prad dane = new prad(0);
            // Zarejestrowanie poczatkowego stanu licznika
            dane.register();

            Console.WriteLine("Stan biezacy:");
            // Zmiana stanu bieżacego
            dane.update();
            
            Console.WriteLine("Zużyto {0} kWh w ciągu {1} dni", dane.Stanbiezacy - dane.Stanpoczatkowy, (dane.Databiezaca - dane.Datapoczatkowa).TotalDays);
            Console.ReadKey();
        }
    }
}
