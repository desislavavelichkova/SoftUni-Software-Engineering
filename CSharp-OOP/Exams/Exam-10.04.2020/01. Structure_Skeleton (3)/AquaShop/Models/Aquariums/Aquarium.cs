using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Models.Aquariums
{
    public abstract class Aquarium : IAquarium
    {
        private string name;
        private int capacity;
        private ICollection<IDecoration> decorations;
        private ICollection<IFish> fishes;

        public Aquarium(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            decorations = new List<IDecoration>();
            fishes = new List<IFish>();

        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new AggregateException(string.Format(ExceptionMessages.InvalidAquariumName));
                }
                this.name = value;
            }
        }

        public int Capacity { get; private set; }

        public int Comfort
        {
            get
            {
                return decorations.Sum(x => x.Comfort);
            }
        }

        public ICollection<IDecoration> Decorations => this.decorations;

        public ICollection<IFish> Fish => this.fishes;

        public void AddDecoration(IDecoration decoration)
        {
            decorations.Add(decoration);
        }

        public void AddFish(IFish fish)
        {
            if (fishes.Count == this.Capacity)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NotEnoughCapacity));
            }            

            fishes.Add(fish);
        }

        public void Feed()
        {            
            foreach (var fish in fishes)
            {
                fish.Eat();                
            }
        }

        public virtual string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Name} ({GetType().Name}):");
            if (fishes.Count == 0)
            {
                sb.AppendLine($"Fish: none");
            }
            else
            {
                sb.AppendLine($"Fish: {string.Join(", ", fishes.Select(x => x.Name))}");
            }
            sb.AppendLine($"Decorations: { decorations.Count}");
            sb.AppendLine($"Comfort: {Comfort}");

            return sb.ToString().TrimEnd();            
        }

        public bool RemoveFish(IFish fish)
        {
            if (!fishes.Contains(fish))
            {
                return false;
            }
            fishes.Remove(fish);     
            return true;
        }
    }
}
