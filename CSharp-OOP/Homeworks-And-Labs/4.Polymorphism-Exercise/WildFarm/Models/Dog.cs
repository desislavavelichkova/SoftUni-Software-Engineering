
namespace WildFarm.Models
{
    public class Dog:Mammal
    {
        private const double foodEatenConst = 0.40;
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, foodEatenConst, livingRegion)
        {  }

        public override string Talk()
        {
            return "Woof!";
        }
        public override string ToString(string foodEaten)
        {
            double animalWeight = WeightAfterEat(int.Parse(foodEaten));
            return $"{base.ToString(foodEaten)}{animalWeight}, {LivingRegion}, {foodEaten}]";
        }
    }
}
