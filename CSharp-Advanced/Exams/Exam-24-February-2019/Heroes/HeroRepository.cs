using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> heroes;

        public HeroRepository()
        {
            heroes = new List<Hero>();

        }
        public void Add(Hero hero)
        {
            heroes.Add(hero);
        }

        public void Remove(string name)
        {
            if (heroes.FirstOrDefault(x => x.Name == name) != null)
            {
                heroes.Remove(heroes.FirstOrDefault(x => x.Name == name));
            }
        }
        public Hero GetHeroWithHighestStrength()
        {
            var heroWithHighestStrenght = heroes.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return heroWithHighestStrenght;
        }
        public Hero GetHeroWithHighestAbility()
        {
            var heroWithHighestAbility = heroes.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return heroWithHighestAbility;
        }
        public Hero GetHeroWithHighestIntelligence()
        {
            var heroWithHighestIntelligence = heroes.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return heroWithHighestIntelligence;
        }

        public int Count => heroes.Count;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in heroes)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString();
        }


    }
}
