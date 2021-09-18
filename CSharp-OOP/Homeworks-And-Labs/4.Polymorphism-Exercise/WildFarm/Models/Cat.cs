
namespace WildFarm.Models
{
    public class Cat:Feline
    {
        private const double foodEatenConst = 0.30;
        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, foodEatenConst, livingRegion, breed)
        {   }

        public override string Talk()
        {
            return "Meow";
        }
        
    }
}
