using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD_2_LAB_12
{
    class Kierownik : Pracownik
    {
        public int podwladni;
        public string typkierownictwa;
        public int dodatekfunkcyjny;
        
        public Kierownik(int podwladni1, string typkierownicta1, int dodatekfunkcyjny1)
        {
            podwladni = podwladni1;
            typkierownictwa = typkierownicta1;
            dodatekfunkcyjny = dodatekfunkcyjny1;
        }

        public override void wyswietl()
        {
 	         base.wyswietl();
             Console.WriteLine("Podwladni: {0}", podwladni);
             Console.WriteLine("Typ kierownictwa: {0}", typkierownictwa);
             Console.WriteLine("Dodatek Funkcyjny: {0}", dodatekfunkcyjny);
        }
    }
}
