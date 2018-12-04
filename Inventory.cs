using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jatek;


namespace jatek
{
    class Inventory
    {
        int Kapacitasmax;
        int Kapacitas;
        List<ItemSet> leltar { get; set; }


        public Inventory(int Kapacitasmax)
        {

             this.leltar = new List<ItemSet>();
            this.Kapacitasmax = Kapacitasmax;
            this.Kapacitas = Kapacitasmax;
        }

        public void targyhozzaadas(ItemSet item)
        {
            if(item.Suly > this.Kapacitas)
            {
                Console.WriteLine("Sajnos nem fér már több tárgy a leltáradba!");
            }
            else
            {
                this.leltar.Add(item);
                this.Kapacitas -= item.Suly;
            }
            

        }

        public String Kapacitaskiiras()
        {
            return this.Kapacitas + " / " + this.Kapacitasmax;
        }



    }
}
