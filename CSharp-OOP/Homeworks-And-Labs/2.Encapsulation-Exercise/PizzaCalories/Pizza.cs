using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private const int MaxToppingCount = 10;
        private const int MinToppingCount = 0;
        private const int MaxPizzaNameLenght = 15;
        private const int MinPizzaNameLenght = 1;

        private string name;
        private Dough dough;
        private List<Topping> toppings;        

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
            toppings = new List<Topping>();           
        }

        public string Name 
        { 
            get => this.name;
            set
            {
                if (value.Length < MinPizzaNameLenght || value.Length > MaxPizzaNameLenght)
                {
                    throw new ArgumentException($"Pizza name should be between {MinPizzaNameLenght} and {MaxPizzaNameLenght} symbols.");
                }
                this.name = value;                
            }
        }
        
        public void AddTopping(Topping topping)
        {
            if (toppings.Count > MaxToppingCount)
            {
                throw new ArgumentException($"Number of toppings should be in range [{MinToppingCount}..{MaxToppingCount}].");
            }

            toppings.Add(topping);              
        }

        public double GetCalorie()
        {
            var calories = dough.GetCalorie() + toppings.Sum(x => x.GetCalories());
            return calories;
        }
    }
}
