using System;
using WarCroft.Constants;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Contracts;

namespace WarCroft.Entities.Characters
{
    public class Warrior : Character, IAttacker
    {
        private static Bag bag;
        private Warrior currentWaririor;

        public Warrior(string name) 
            : base(name, 100, 50, 40, bag)
        {            
            this.Name = name;
            this.currentWaririor = currentWaririor;
        }
        public override double BaseHealth => 100;
        public override double BaseArmor => 50;
        public override bool IsAlive { get; set; } = true;
        public void Attack(Character character)
        {
            if (character.IsAlive && currentWaririor.IsAlive)
            {
                if (currentWaririor.Name == character.Name)
                {
                    throw new InvalidOperationException(ExceptionMessages.CharacterAttacksSelf);
                }
                else
                {
                    character.TakeDamage(currentWaririor.AbilityPoints);
                }
            }            

        }
    }
}
