using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliotekarz Dawid = new Bibliotekarz("Dawid", "Damianski");

            Ksiazka k = Dawid.DodajKsiazke();
            Dawid.ModyfikujKsiazke(k);
            Wypozyczajacy w = Dawid.DodajWypozyczajacego();


            w.WyswietlInformacje();
            w.WyswietlKsiazke(k);



            Console.ReadLine();

        }
    }
}
