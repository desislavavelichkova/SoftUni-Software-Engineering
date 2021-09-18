using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _3.HeroesОfCodeАndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mpMax = 200;
            int hpMax = 100;

            Dictionary<string, int> heroHp = new Dictionary<string, int>();
            Dictionary<string, int> heroMp = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {                
                string[] cmndArgms = Console.ReadLine().Split();

                string nameOfHero = cmndArgms[0];
                int hitPoint = int.Parse(cmndArgms[1]);
                int manaPoint = int.Parse(cmndArgms[2]);

                if (hitPoint >= hpMax)
                {
                    hitPoint = hpMax;
                }
                if (manaPoint >= mpMax)
                {
                    manaPoint = mpMax;
                }
                heroHp.Add(nameOfHero,hitPoint);
                heroMp.Add(nameOfHero, manaPoint);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmndArgs = input.Split(" - ");
                string comand = cmndArgs[0];
                string heroName = cmndArgs[1];

                if (comand == "CastSpell")
                {
                    int neededMp = int.Parse(cmndArgs[2]);
                    string spellName = cmndArgs[3];

                    if (heroMp[heroName] >= neededMp)
                    {
                        heroMp[heroName] -= neededMp;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroMp[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (comand == "TakeDamage")
                {
                    int demage = int.Parse(cmndArgs[2]);
                    string attacker = cmndArgs[3];

                    if (heroHp[heroName] > demage)
                    {
                        int currentHp = heroHp[heroName] - demage;
                        heroHp[heroName] -= demage;
                        Console.WriteLine($"{heroName} was hit for {demage} HP by {attacker} and now has {currentHp} HP left!");
                    }
                    else if(heroHp[heroName] <= demage)
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroHp.Remove(heroName);
                        heroMp.Remove(heroName);
                    }
                }
                else if (comand == "Recharge")
                {
                    int amount = int.Parse(cmndArgs[2]);
                    int oldMp = heroMp[heroName];
                    int recoveredMp = 0;

                    if (oldMp + amount < mpMax)
                    {
                        recoveredMp = amount;
                        heroMp[heroName] += amount;
                    }
                    else
                    {
                        recoveredMp = mpMax - oldMp;
                        heroMp[heroName] = mpMax;
                    }
                    Console.WriteLine($"{heroName} recharged for {recoveredMp} MP!");
                }
                else if (comand == "Heal")
                {
                    int amount = int.Parse(cmndArgs[2]);

                    int oldHp = heroHp[heroName];
                    int recoveredHp = 0;

                    if (oldHp + amount < hpMax)
                    {
                        recoveredHp = amount;
                        heroHp[heroName] += amount;
                    }
                    else
                    {
                        recoveredHp = hpMax - oldHp;
                        heroHp[heroName] = hpMax;
                    }
                    Console.WriteLine($"{heroName} healed for {recoveredHp} HP!");
                }

                input = Console.ReadLine();
            }
            foreach (var hero in heroHp.OrderByDescending(x => x.Value)
                                       .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroMp[hero.Key]}");
            }
        }
    }
}
