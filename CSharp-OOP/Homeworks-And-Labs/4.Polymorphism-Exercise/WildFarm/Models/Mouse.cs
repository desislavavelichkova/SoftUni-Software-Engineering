
namespace WildFarm.Models
{
    public class Mouse: Mammal
    {
        private const double foodEatenConst = 0.10;
        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, foodEatenConst,livingRegion)
        { }
        public override string Talk()
        {
            return "Squeak";
        }
        public override string ToString(string foodEaten)
        {
            double animalWeight = WeightAfterEat(int.Parse(foodEaten));
            return $"{base.ToString(foodEaten)}{animalWeight}, {LivingRegion}, {foodEaten}]";
        }
    }
}
