using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jatek;

namespace jatek
{
    


    class Program
    {
        static void Main(string[] args)
        {

            Jatekos Player1 = new Jatekos("Codiee", 100);

            ItemSet itemset = new ItemSet();
            
            
            for (int i = 0; i < 101; i++)
            {
                Player1.Leltar.targyhozzaadas(itemset.KardItem());
            }

            
            

            Console.WriteLine(Player1.Leltar.Kapacitaskiiras());

            Console.ReadKey();
        }
    }
}
