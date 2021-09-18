
namespace WildFarm.Models
{
    public abstract class Animal
    {
        protected Animal(string name, double weight, double foodEatenConst)
        {
            Name = name;
            Weight = weight;
            FoodEatenConst = foodEatenConst;
        }

        public string Name { get; private set; }
        public double Weight { get; private set; }
        public virtual double FoodEatenConst { get; private set; }

        public virtual string Talk()
        {
            return null;
        }
        public virtual double WeightAfterEat(int foodQuantity)
        {
            return this.Weight + (foodQuantity * this.FoodEatenConst);
        }
        public virtual string ToString(string foodEaten)
        {            
            return $"{GetType().Name} [{this.Name}, ";
        }

    }
}
