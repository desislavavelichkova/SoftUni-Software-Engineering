using System;

namespace PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;

        private string toppingType;
        private int toppingWeight;

        public Topping(string toppingType, int toppingWeight)
        {
            this.ToppingType = toppingType;
            this.ToppingWeight = toppingWeight;
        }

        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                var valueAsLower = value.ToLower();

                if (valueAsLower != "meat" &&
                    valueAsLower != "veggies" &&
                    valueAsLower != "cheese" &&
                    valueAsLower != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }              

                toppingType = value;
            }
        }
        public int ToppingWeight
        {
            get => this.toppingWeight;
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{toppingType} weight should be in the range[{MinWeight}..{MaxWeight}].");
                }
                toppingWeight = value;
            }
        }
       
        private double GetToppingTypeModifiers()
        {           
            if (this.ToppingType.ToLower() == "meat")
            {
                return 1.2;
            }
            if (this.ToppingType.ToLower() == "veggies")
            {
                return 0.8;
            }
            if (this.ToppingType.ToLower() == "cheese")
            {
                return 1.1;
            }            
            return 0.9;
        }
        public double GetCalories()
        {
            var calories = 2.0 * GetToppingTypeModifiers() * this.ToppingWeight;

            return calories;
        }

    }
}
