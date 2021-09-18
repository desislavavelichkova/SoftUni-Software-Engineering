using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        
        private string flourType;
        private string bakingTechnique;
        private int weight;
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public string FlourType 
        { 
            get => this.flourType;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "white" &&
                    valueAsLower != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }               

                flourType = value;
            }
        }

        public string BakingTechnique 
        { 
            get => this.bakingTechnique;
            private set
            {
                var valueAsLower = value.ToLower();
                if (valueAsLower != "crispy" &&
                    valueAsLower != "chewy" &&
                    valueAsLower != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }                
                bakingTechnique = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                weight = value;
            }
        }
           
        private double GetFlourTypeModifier()
        {
            var flourTypeToLower = this.FlourType.ToLower();

            if (flourTypeToLower == "white")
            {
                return 1.5;
            }
            return 1.0;
        }
        private double GetBakingTechniqueModifier()
        {
            string bakingTechniqueToLower = this.BakingTechnique.ToLower();

            if (bakingTechniqueToLower == "crispy")
            {
                return 0.9;
            }
            if (bakingTechniqueToLower == "chewy")
            {
                return 1.1;
            }            
            return 1.0;
        }
        public double GetCalorie()
        {            
            double calories = (2 * this.Weight) * GetFlourTypeModifier() * GetBakingTechniqueModifier();
            return calories;
        }
    }
}
