using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek
{
    class Fegyver
    {
        public String Fegyvernev { get; set; }
        public int Sebzes { get; set; }
        public int Eletero { get; set; }

        public Fegyver(String Fegyvernev, int Sebzes, int Eletero)
        {
            this.Fegyvernev = Fegyvernev;
            this.Sebzes = Sebzes;
            this.Eletero = Eletero;
        }

        
        
    }
}
