using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_lab_12
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Komputer jeden = new Komputer("Sony", "Vaio", "1111", "2222", "3333");
            Komputer dwa = new Komputer();
            jeden.wyswietl();
            dwa.wyswietl();

            KomputerPrzenosny trzy = new KomputerPrzenosny();
            trzy.wyswietl();
            Console.ReadKey();
        }
    }
}
