using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Lab13
{
    class Wypozyczajacy : IWypozyczajacy
    {
        string imie, nazwisko, adres;

        public Wypozyczajacy(string imie1, string nazwisko1, string adres1)
        {
            imie = imie1;
            nazwisko = nazwisko1;
            adres = adres1;
        }

        public void wyswietl()
        {
            Console.WriteLine("{0},  {1},  {2}", imie, nazwisko, adres);
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine("Informacje o Wypozyczajacym:");
            Console.WriteLine("{0}, {1}, {2}", imie, nazwisko, adres);
        }

        public void WyswietlKsiazke(Ksiazka K)
        {
            Console.WriteLine("Informacje o Ksiażce:");
            K.wyswietl();
        }
    }
}
