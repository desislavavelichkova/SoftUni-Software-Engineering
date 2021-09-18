
namespace WildFarm.Models
{
    public abstract class Feline: Mammal
    {
        public Feline(string name, double weight, double foodEatenConst, string livingRegion, string breed)
            : base(name, weight, foodEatenConst, livingRegion)
        {
            this.Breed = breed;
        }

        public string  Breed { get;private set; }
                
        public override string ToString(string foodEaten)
        {            
            double animalWeight = WeightAfterEat(int.Parse(foodEaten));
            return $"{base.ToString(foodEaten)}{this.Breed}, {animalWeight}, {this.LivingRegion}, {foodEaten}]";
        }
    }
}
