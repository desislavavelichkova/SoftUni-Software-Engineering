using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BaseHero hero = null;
            List<BaseHero> heros = new List<BaseHero>();
            

            for (int i = 0; i < n; i++)
            {
                string playerName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    hero = new Druid( playerName);   
                }
                else if(heroType == "Paladin")
                {
                    hero = new Paladin(playerName);                                        
                }
                else if (heroType == "Rogue")
                {
                    hero = new Rogue(playerName);
                    
                }
                else if(heroType == "Warrior")
                {
                    hero = new Warrior(playerName);                    
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }
                heros.Add(hero);
                Console.WriteLine(hero.CastAbility());
            }

            int bossPower = int.Parse(Console.ReadLine());
            int sumHeroPower = heros.Sum(x => x.Power);

            if (sumHeroPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
