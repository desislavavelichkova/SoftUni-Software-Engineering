using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            Name = name;
            Level = level;
            Item = item;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }
        public Item Item { get; private set; }

        public override string ToString()
        {
            return  $"Hero: {Name} – {Level}lvl\r\n" +
                    $"Item:\r\n" +
                    $"  * Strength: {Item.Strength}\r\n" +
                    $"  * Ability: {Item.Ability}\r\n" +
                    $"  * Intelligence: {Item.Intelligence}";


        }
    }
}
