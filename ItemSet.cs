using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek
{
    class ItemSet
    {
        public int ID { get; set; }
        public int Suly { get; set; }
        public Fegyver Fegyver;
        public Pancel Pancel;

        public ItemSet KardItem()
        {
            ItemSet KardItem = new ItemSet();
            

            KardItem.ID = 0;
            KardItem.Suly = 10;
            KardItem.Fegyver = new Fegyver("Kard",10,100);

            return KardItem;
        }

    }
}
