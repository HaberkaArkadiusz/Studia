using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4Lab13
{
    class Ksiazka
    {
        public string tytul, autor;
        public int rokwydania;

        public Ksiazka(string tytul1, string autor1, int rokwydania1)
        {
            tytul = tytul1;
            autor = autor1;
            rokwydania = rokwydania1;
        }

        public void wyswietl()
        {
            Console.WriteLine("{0},  {1},  {2}", tytul, autor, rokwydania);
        }
    }
}
