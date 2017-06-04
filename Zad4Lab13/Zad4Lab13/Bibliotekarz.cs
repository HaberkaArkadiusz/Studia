using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Lab13
{
    class Bibliotekarz : IBibliotekarz
    {
        string imie, nazwisko;

        public Bibliotekarz(string imie1, string nazwisko1)
        {
            imie = imie1;
            nazwisko = nazwisko1;
        }

        public Ksiazka DodajKsiazke()
        {
            Console.WriteLine("Dodawanie ksiażki:");
            Console.WriteLine("Podaj tytuł ksiązki:");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj autora ksiązki:");
            string autor = Console.ReadLine();
            Console.WriteLine("Podaj rok wydania ksiązki:");
            int rok = Convert.ToInt32(Console.ReadLine());

            return new Ksiazka(nazwa, autor, rok);
        }

        public Wypozyczajacy DodajWypozyczajacego()
        {
            Console.WriteLine("Dodawanie Wypozyczajacego:");
            Console.WriteLine("Podaj imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj adres:");
            string adres = Console.ReadLine();

            return new Wypozyczajacy(imie, nazwisko, adres);
        }

        public void ModyfikujKsiazke(Ksiazka K)
        {
            Console.WriteLine("Modyfikacja Ksiazki:");
            K.wyswietl();
            int response = 0;
            while(!(response == 1 || response == 2 || response == 3 || response == 4))
            {
                Console.WriteLine("Co chcesz zmienić?");
                Console.WriteLine("1. Tytuł  2. Autor  3. Rok wydania 4. Anuluj");
                response = Convert.ToInt32(Console.ReadLine());
            }

            switch(response)
            {
                case 1:
                    Console.WriteLine("Podaj nowy tytuł:");
                    K.tytul = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Podaj nowego autora:");
                    K.autor = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Podaj nowy rok wydania:");
                    K.rokwydania = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }

        public void WyswietlKsiazke(Ksiazka K)
        {
            K.wyswietl();
        }
    }
}
