using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_Lab_12
{
    class Kwartalnik : Czasopismo
    {
        public string isbn;
        public string miesiac;
        public string redaktor;


        public Kwartalnik(string nazwa1, string wydawnictwo1, int rokzalozenia1, int rokostatni1, int wydania1, int strony1, double cena1, string isbn1, string miesiac1, string redaktor1) : base(nazwa1, wydawnictwo1, rokzalozenia1, rokostatni1, wydania1, strony1, cena1)
        {
            isbn = isbn1;
            while (miesiac == "styczeń" || miesiac == "luty" || miesiac == "marzec" || miesiac == "kwiecień")
            {
                Console.WriteLine("Pole miesiąć może przyjąć wartość: styczeń, luty, marzec, kwiecień");
                Console.WriteLine("Podaj poprawny miesiac 1 wydania w roku:");
                miesiac = Console.ReadLine();
            }
            miesiac = miesiac1;
            redaktor = redaktor1;
        }

        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("{0} , {1} , {2}", isbn, miesiac, redaktor);
        }

        public void typ()
        {
            if (isbn == null && redaktor == null)
                Console.WriteLine("Kwartalnik nierecenzowany");
            if (isbn == null)
                Console.WriteLine("Kwartalnik nierecenzowany");
            if (isbn != null && redaktor != null)
                Console.WriteLine("Kwartalnik recenzowany");
            if (miesiac == "styczeń" || miesiac == "luty")
                Console.WriteLine("Kwartalnik wydawany z początkiem roku");
            if (miesiac == "marzec" || miesiac == "kwiecień")
                Console.WriteLine("Kwartalnik wydawany z początkiem II kwartału");
            if(Rokzalozenia < 2000 && isbn != null)
                Console.WriteLine("Kwartalnik naukowy z długoletnią tradycją");
            if (Rokzalozenia > 2009)
                Console.WriteLine("Nowość!");
        }
    }
}
