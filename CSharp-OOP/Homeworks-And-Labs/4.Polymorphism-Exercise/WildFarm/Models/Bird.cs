
namespace WildFarm.Models
{
    public abstract class Bird: Animal
    {
        public Bird(string name, double weight, double foodEatenConst, double wingSize)
            : base(name, weight, foodEatenConst)
        {
            this.WingSize = wingSize;
        }
               
        public double WingSize { get; private set; }
                
        public override string ToString(string foodEaten)
        {
            double animalWeight = WeightAfterEat(int.Parse(foodEaten));
            return $"{base.ToString(foodEaten)}{this.WingSize}, {animalWeight}, {foodEaten}]";
        }
    }
}
