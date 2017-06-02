using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_lab_12
{
    class Komputer
    {
        public string producent, model, motherboard, processor, harddrive;

        public Komputer()
        {
            Console.WriteLine("Producent:");
            producent = Console.ReadLine();
            Console.WriteLine("Model:");
            model = Console.ReadLine();
            Console.WriteLine("Plyta Główna:");
            motherboard = Console.ReadLine();
            Console.WriteLine("Procesor:");
            processor = Console.ReadLine();
            Console.WriteLine("Dysk Twardy:");
            harddrive = Console.ReadLine();
        }

        public Komputer(string Producent, string Model, string Motherboard, string Procesor, string Harddrive)
        {
            producent = Producent;
            model = Model;
            motherboard = Motherboard;
            processor = Procesor;
            harddrive = Harddrive;
        }

        public virtual void wyswietl()
        {
            Console.WriteLine("Producent: {0} , Model: {1} , Płyta Główna: {2}",producent,model,motherboard);
            Console.WriteLine("Procesor: {0} , Dysk Twardy: {1}",processor,harddrive);
        }
    }
}
