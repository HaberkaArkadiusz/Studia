using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD_2_LAB_12
{
    class Pracownik
    {
        private string imie;
        private string nazwisko;
        private string nip;
        private DateTime dataurodzenia;
        private DateTime datazatrudnienia;
        private double pensja;
        private string dzial;

        public Pracownik()
        {
            Console.WriteLine("Podaj imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj NIP:");
            nip = Console.ReadLine();
            Console.WriteLine("Podaj date urodzenia:");
            dataurodzenia = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj date zatrudnienia:");
            datazatrudnienia = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pensję:");
            pensja = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj dzial:");
            dzial = Console.ReadLine();
        }

        public virtual void wyswietl()
        {
            Console.WriteLine("Imie: {0}, Nazwisko: {1}", imie, nazwisko);
            Console.WriteLine("NIP: {0} ", nip);
            Console.WriteLine("Data urodzenia: {0}, Data zatrudnienia: {1}", dataurodzenia, datazatrudnienia);
            Console.WriteLine("Pensja: {0}, Dział: {1}", pensja, dzial);
        }
    }
}
