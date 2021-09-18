using System;
using System.Collections.Generic;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters
{
    public class Priest : Character, IHealer
    {
        private static Bag bag;

        //private static Backpack backpack;
        private Priest currentpriest;      

        public Priest(string name) 
            : base(name, 50, 25, 40, bag)
        {
            this.Name = name;
           
        }
        
        public override double BaseHealth => 50;
        public override double BaseArmor => 25;
        public override bool IsAlive { get; set; } = true;

        private Priest Currentpriest => this.currentpriest;

        public void Heal(Character character)
        {
            if (character.IsAlive && currentpriest.IsAlive)
            {
                if (currentpriest.Name == character.Name)
                {
                    throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                }
                else
                {
                    character.Health += currentpriest.AbilityPoints;
                }
            }

        }
    }
}
