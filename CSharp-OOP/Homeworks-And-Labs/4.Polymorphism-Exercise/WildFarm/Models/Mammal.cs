
namespace WildFarm.Models
{
    public abstract class Mammal: Animal
    {
        public Mammal(string name, double weight, double foodEatenConst, string livingRegion) 
            : base (name, weight, foodEatenConst)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; private set; 
        
        }
    }
}
