using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public abstract class Fish : IFish
    {
        private string name;
        private string species;
        private decimal price;
        private int size;

        protected Fish(string name, string species, decimal price)
        {
            Name = name;
            Species = species;            
            Price = price;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(string.Format(ExceptionMessages.InvalidFishName));
                }
                this.name = value;
            }
        }

        public string Species
        {
            get => this.species;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(string.Format(ExceptionMessages.InvalidFishSpecies));
                }

                this.species = value;
            }
        }

        public virtual int Size => this.size;

        public decimal Price
        {
            get => this.price;
            private set
            {
                if (value <= 0)
                {
                    throw new AggregateException(string.Format(ExceptionMessages.InvalidFishPrice));
                }

                this.price = value;
            }
        }

        public virtual void Eat()
        {
            
        }
    }
}
