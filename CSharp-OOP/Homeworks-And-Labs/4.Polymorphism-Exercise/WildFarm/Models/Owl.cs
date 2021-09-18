
namespace WildFarm.Models
{
    public class Owl: Bird
    {
        private const double foodEatenConst = 0.25;        
        public Owl(string name, double weight, double wingSize)
            : base(name, weight, foodEatenConst, wingSize)
        {  }

        public override string Talk()
        {
            return "Hoot Hoot";
        }
    }
}
