using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory.Contracts
{
    public abstract class Bag : IBag
    {
        private int capacity;
        private List<Item> items;
        
        protected Bag(int capacity)
        {
            this.Capacity = capacity;
            items = new List<Item>();
            
        }

        public int Capacity 
        { 
            get => this.capacity; 
            set => this.capacity = 100; 
        }

        public int Load => items.Sum(x => x.Weight);


        public IReadOnlyCollection<Item> Items => (IReadOnlyCollection<Item>)items;

        public virtual void AddItem(Item item)
        {
            if ((item.Weight + this.Load) > capacity )
            {
                throw new InvalidOperationException(ExceptionMessages.ExceedMaximumBagCapacity);
            }

            items.Add(item);
             
        }

        public Item GetItem(string name)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.EmptyBag);
            }

            Item item = items.FirstOrDefault(x => x.GetType().Name == name);

            if (item == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.ItemNotFoundInBag, name));
            }

            items.Remove(item);
            return item;
        }
    }
}
