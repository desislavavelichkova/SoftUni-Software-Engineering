using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    public class Rabbit
    {
        public bool available;
        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
            available = true;
        }

        public string Name { get; set; }
        public string Species { get; set; }

        public bool Available
        {
            get => this.available;
            set
            {
                this.available = value;
            }
        }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }
    }
}
