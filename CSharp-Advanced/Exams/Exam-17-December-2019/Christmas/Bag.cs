using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        private List<Present> presents;

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            presents = new List<Present>();
        }

        public string Color { get; private set; }
        public int Capacity { get; private set; }

        public void Add(Present present)
        {
            if (presents.Count < Capacity)
            {
                presents.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present present = presents.FirstOrDefault(x => x.Name == name);
            if (present == null)
            {
                return false;
            }
            else
            {
                presents.Remove(present);
                return true;
            }
        }
        public Present GetHeaviestPresent()
        {
            return presents.OrderByDescending(x => x.Weight).FirstOrDefault();
        }

        public Present GetPresent(string name)
        {
            Present present = presents.FirstOrDefault(x => x.Name == name);
            return present;
        }

        public int Count { get { return presents.Count; } }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Color} bag contains:");
            foreach (var item in presents)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }


    }

}
