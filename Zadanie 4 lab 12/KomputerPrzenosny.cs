using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_lab_12
{
    class KomputerPrzenosny : Komputer
    {
        public string bateria;
        public Double waga;
        public string bluetooth;

        public KomputerPrzenosny()
        {
            Console.WriteLine("Waga:");
            waga = Convert.ToDouble(Console.ReadLine());
            while (waga < 1.2 || waga > 3.5)
            {
                Console.WriteLine(" # Waga powinna znajdować się w przedziale od 1,2 do 3,5 kg");
                Console.WriteLine("Waga:");
                waga = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Bateria:");
            bateria = Console.ReadLine();

            Console.WriteLine("Bluetooth:");
            bluetooth = Console.ReadLine();
            while (bluetooth != "t" && bluetooth != "n")
            {
                Console.WriteLine(" # Bluetooth może przyjąć wartość t lub n");
                Console.WriteLine("Bluetooth:");
                bluetooth = Console.ReadLine();
            }

        }

        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine("Bateria: {0}, Waga: {1}, Bluetooth: {2}", bateria, waga, bluetooth);
        }


    }
}
