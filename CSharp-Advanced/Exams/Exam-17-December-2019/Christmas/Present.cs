using System;
using System.Collections.Generic;
using System.Text;

namespace Christmas
{
    public class Present
    {
        public Present(string name, double weight, string gender)
        {
            Name = name;
            Weight = weight;
            Gender = gender;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public string Gender { get; private set; }

        public override string ToString()
        {
            return $"Present {Name} for a {Gender}";
        }
    }
}
