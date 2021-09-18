
namespace WildFarm.Models
{
    public class Hen: Bird
    {
        private const double foodEatenConst = 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, foodEatenConst, wingSize)
        { }
        public override string Talk()
        {
             return "Cluck";            
        }
    }
}
