using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_8_Lab_12
{
    /*
      - nazwa
- wydawnictwo
- rok założenia
- rok ostatniego numeru
- ilość wydań w roku
- liczba stron
- cena*/
    class Czasopismo
    {
        public string nazwa, wydawnictwo;
        private int rokzalozenia;
        public int Rokzalozenia
        {
            get
            {
                return rokzalozenia;
            }

            set
            {
                rokzalozenia = value;
            }
        }
        private int rokostatni;
        public int Rokostatni
        {
            get
            {
                return rokostatni;
            }

            set
            {
                rokostatni = value;
            }
        }
        private int wydania;
        public int Wydania
        {
            get
            {
                return ((Rokostatni - Rokzalozenia)/wydania);
            }

            set
            {
                wydania = value;
            }
        }
        public int strony;
        private double cena;
        public double Cena
        {
            get
            {
                return cena;
            }

            set
            {
                if(value > 0)
                {
                    cena = value;
                }
                else
                {
                    Console.WriteLine("Cena musi być dodatnia!");
                }
            }
        }

        public Czasopismo(string nazwa1, string wydawnictwo1, int rokzalozenia1, int rokostatni1, int wydania1, int strony1, double cena1)
        {
            nazwa = nazwa1;
            wydawnictwo = wydawnictwo1;
            Rokzalozenia = rokzalozenia1;
            Rokostatni = rokostatni1;
            Wydania = wydania1;
            strony = strony1;
            Cena = cena1;
        }

        public virtual void wyswietl()
        {
            Console.WriteLine("{0}  ,  {1}  ,  {2}  ,  {3}", nazwa, wydawnictwo, Rokzalozenia, Rokostatni);
            Console.WriteLine("{0}  ,  {1}  ", strony, Cena);
        }
    }
}
