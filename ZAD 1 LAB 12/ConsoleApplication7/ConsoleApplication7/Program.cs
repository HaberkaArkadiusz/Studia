using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            punkt A = new punkt(50.3, 23.5);
            A.wspolrzedne();
            Kolorowypunkt B = new Kolorowypunkt(20.5, 12.4, 150, 200, 60);
            B.wspolrzedne();
            B.Red = 0;
            Console.ReadLine();
        }
    }
}
