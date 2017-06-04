using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Lab13
{
    interface IBibliotekarz
    {
        Ksiazka DodajKsiazke();
        Wypozyczajacy DodajWypozyczajacego();
        void ModyfikujKsiazke(Ksiazka K);
        void WyswietlKsiazke(Ksiazka K);
    }
}
