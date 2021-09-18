using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Contracts
{
    public class Backpack : Bag
    {
        private List<Item> items;

        public Backpack()
            : base(100)
        {
            items = new List<Item>();
        }
    }
}
