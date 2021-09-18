using System;
using System.Linq;
using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Inventory.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private readonly Character character;
        private string name;
		private double baseHealth;
		private double health;
		private double baseArmor;
		private double armor;
		private double abilityPoints;
		private Bag bag;

		public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            Health = health;
			AbilityPoints = abilityPoints;
			Armor = armor;
			Bag = bag;
        }

        public string Name
		{
			get => this.name;
			set
			{
                if (string.IsNullOrWhiteSpace(value))
                {
					throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
				}
				this.name = value;
			}
		}

        public virtual double BaseHealth { get; }

		public double Health
		{
			get => this.health;
			set
			{
                if (value > 0 || value <= this.baseHealth )
                {
					this.health = value;
                }			
			}
		}

		public virtual double BaseArmor { get; }

		public double Armor
		{
			get => this.armor;
			set
			{
				if (value > 0 )
				{
					this.armor = value;
				}
			}
		}
		public double AbilityPoints { get; private set; }	

		public virtual Bag Bag { get; }

		public virtual bool IsAlive { get; set; } = true;


		public void TakeDamage(double hitPoints)
        {
			EnsureAlive();

            if (this.Armor >= hitPoints)
            {
				this.Armor -= hitPoints;

            }
            else
            {
				double currHitPoints = hitPoints - this.Armor;
				this.Armor = 0;
				this.Health -= currHitPoints;

                if (this.Health <= 0)
                {
					this.IsAlive = false;					
                }
				
            }
        }

		public void UseItem(Item item)
		{
			EnsureAlive();			
            
            if (bag.Items.Contains(item))
            {				
				if (item.GetType().Name == nameof(FirePotion))
				{
					item.AffectCharacter(character);
				}
				else if (item.GetType().Name == nameof(HealthPotion))
				{
					item.AffectCharacter(character);
				}
			}
		}
		protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
	}
}