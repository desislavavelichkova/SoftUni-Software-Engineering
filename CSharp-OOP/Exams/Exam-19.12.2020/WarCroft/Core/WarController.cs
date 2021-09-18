using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Inventory.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
	public class WarController
	{
		private readonly List<Character> party;
		private readonly Stack<Item> pool;
		public WarController()
		{
			party = new List<Character>();
			pool = new Stack<Item>();
		}

		public string JoinParty(string[] args)
		{
			string characterType = args[0];
			string name = args[1];
			            
			Character character = null;

            if (characterType == nameof(Priest))
            {
				character = new Priest(name);
            }
            else if (characterType == nameof(Warrior))
            {
				character = new Warrior(name);
            }
            else
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, characterType));
            }
			party.Add(character);

			return string.Format(SuccessMessages.JoinParty, name);            
		}

		public string AddItemToPool(string[] args)
		{
			string itemName = args[0];

			Item item = null;

            if (itemName == nameof(FirePotion))
            {
				item = new FirePotion();
            }
            else if (itemName == nameof(HealthPotion))
            {
				item = new HealthPotion();

            }
            else
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, itemName));
            }
			pool.Push(item);

			return string.Format(SuccessMessages.AddItemToPool, itemName);
		}

		public string PickUpItem(string[] args)
		{
			string characterName = args[0];

            if (party.FirstOrDefault(x => x.Name == characterName) == null)
            {
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, characterName);
            }
            else 
            {
                if (pool.Count == 0)
                {
					throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);

				}
				Item item = pool.Peek();
				
                if (party.FirstOrDefault(x => x.Name == characterName).GetType().Name == nameof(Warrior))
                {
					Warrior character = (Warrior)party.FirstOrDefault(x => x.Name == characterName);
					character.Bag.AddItem(item);
				}
				if (party.FirstOrDefault(x => x.Name == characterName).GetType().Name == nameof(Priest))
				{
					Priest character = (Priest)party.FirstOrDefault(x => x.Name == characterName);
					character.Bag.AddItem(item);		
				}			

				return $"{characterName.ToString()} picked up {item}!";

			}
		}

		public string UseItem(string[] args)
		{
			string characterName = args[0];
			string itemName = args[1];

			if (party.FirstOrDefault(x => x.Name == characterName) == null)
			{
				throw new ArgumentException(ExceptionMessages.CharacterNotInParty, characterName);
			}
						
			var character = party.FirstOrDefault(x => x.Name == characterName);
			var item = character.Bag.GetItem(itemName);

			return string.Format(SuccessMessages.UsedItem, characterName, itemName);

		}

		public string GetStats()
		{
			StringBuilder sb = new StringBuilder();

            foreach (var character in party.OrderByDescending(x => x.IsAlive)
										   .ThenByDescending(x => x.Health))
            {
                if (character.IsAlive == false)
                {
					sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: Dead");
				}
				
				sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: Alive");
            }

			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			string attackerName = args[0];
			string receiverName = args[1];

            IAttacker attacker = (IAttacker)party.FirstOrDefault(x => x.Name == attackerName);
			double attackerAbilityPoints = party.FirstOrDefault(x => x.Name == attackerName).AbilityPoints;
			Character receiver = party.FirstOrDefault(x => x.Name == receiverName);

            if (attacker == null)
            {
				throw new ArgumentException($"Character {attackerName} not found!");

			}
			else if (receiver == null)
			{
				throw new ArgumentException($"Character {receiverName} not found!");
			}

            if (attacker.GetType().Name != nameof(Warrior))
            {
				throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }

			attacker.Attack(receiver);

			if (receiver.IsAlive)
			{ 				
				return $"{attackerName} attacks {receiverName} for {attackerAbilityPoints} hit points! {receiverName} " +
						$"has {receiver.Health}/{receiver.BaseHealth} " +
						$"HP and {receiver.Armor}/{receiver.BaseArmor} AP left!\r\n" +
						$"{receiverName} is dead!";

			}            
            
			return $"{attackerName} attacks {receiverName} for {attackerAbilityPoints} hit points! {receiverName} " +
						$"has {receiver.Health}/{receiver.BaseHealth} " +
						$"HP and {receiver.Armor}/{receiver.BaseArmor} AP left!";
		}

		public string Heal(string[] args)
		{
			string healerName = args[0];
			string healingReceiverName = args[1];

			IHealer healer = (IHealer)party.FirstOrDefault(x => x.Name == healerName);
			Character healingReceiver = party.FirstOrDefault(x => x.Name == healingReceiverName);

			if (healer == null)
			{
				throw new ArgumentException($"Character {healerName} not found!");

			}
			else if (healingReceiver == null)
			{
				throw new ArgumentException($"Character {healingReceiverName} not found!");
			}

            if (!party.FirstOrDefault(x => x.Name == healerName && GetType().Name == nameof(Priest)).IsAlive)
            {
				throw new ArgumentException($"{healerName} cannot heal!");
            }

			healer.Heal(healingReceiver);
			double healerAbilityPoints = party.FirstOrDefault(x => x.Name == healerName).AbilityPoints;

			return $"{healerName} heals {healingReceiver} for {healerAbilityPoints}! " +
				$"{healingReceiver.Name} has {healingReceiver.Health} health now!";

		}
	}
}
