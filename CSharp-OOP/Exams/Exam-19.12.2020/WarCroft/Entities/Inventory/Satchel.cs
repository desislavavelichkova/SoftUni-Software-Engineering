using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Satchel : Bag
    {
        private List<Item> items;
        public Satchel()
            : base(20)
        {
            items = new List<Item>();
        }
    }
}
