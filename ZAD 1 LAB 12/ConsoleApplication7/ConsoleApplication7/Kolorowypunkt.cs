using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Kolorowypunkt : punkt
    {
        private Int32 red;
        private Int32 green;
        private Int32 blue;

        public Int32 Red
        {
            get { return red; }
            set { red = value; }
        }
        public Int32 Green
        {
            get { return green; }
            set { green = value; }
        }
        public Int32 Blue
        {
            get { return blue; }
            set { blue = value; }
        }

        public Kolorowypunkt(double x, double y, Int32 r, Int32 g, Int32 b) : base(x, y) 
        {
            red = r;
            green = g;
            blue = b;
        }
    }
}
