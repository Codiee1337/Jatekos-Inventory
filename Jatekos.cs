using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek
{
    class Jatekos
    {

        String Nev { get; set; }
        int Eleteromax { get; set; }
        public Inventory Leltar = new Inventory(1000);

        public Jatekos(String Nev, int Eleteromax)
        {
            this.Nev = Nev;
            this.Eleteromax = Eleteromax;
            

        }

    }
}
