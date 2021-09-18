using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            this.rabbits = new List<Rabbit>();
            Name = name;
            Capacity = capacity;
        }

        public int Count
        {
            get => rabbits.Count;
        }
        
        public string Name { get; private set; }
        public int Capacity { get; private set; }

        public void Add(Rabbit rabbit)
        {
            if (rabbits.Count < Capacity)
            {
                rabbits.Add(rabbit);                
            }            
        }
        public string RemoveRabbit(string name)
        {
            Rabbit rabbit = rabbits.FirstOrDefault(x => x.Name == name);
            bool valid = true; 

            if (rabbit == null)
            {
                valid = false;
                return $"{valid}";
            }
            else
            {
                rabbits.Remove(rabbit);

                return $"{valid}";
            }
        }

        public void RemoveSpecies(string species)
        {
            foreach (Rabbit rabot in rabbits.Where(x => x.Species == species))
            {
                rabbits.Remove(rabot);
            }
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = rabbits.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;

            return rabbit;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {

            Rabbit[] rabbitsForSell = rabbits.Where(x => x.Species == species).ToArray();
            for (int i = 0; i < rabbitsForSell.Length; i++)
            {
                rabbitsForSell[i].Available = false;
            }
            return rabbitsForSell;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rabbits available at {Name}:");
            foreach (Rabbit rabbit in rabbits.Where(x => x.Available == true))
            {
                sb.AppendLine(rabbit.ToString());

            }
            return sb.ToString().TrimEnd();
        }

    }
}
