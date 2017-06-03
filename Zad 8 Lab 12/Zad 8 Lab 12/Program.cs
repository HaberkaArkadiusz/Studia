using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Czasopismo A = new Czasopismo("Nazwa","Wydawnictwo",1992,1994,12,765,30.99);
            A.wyswietl();

            Kwartalnik B = new Kwartalnik("Nazwa", "Wydawnictwo", 2010, 1112, 4, 50, 50.2,"1234567890123","luty", "Adam Ostrowski");
            B.wyswietl();
            B.typ();

            Console.ReadLine();

        }
    }
}
