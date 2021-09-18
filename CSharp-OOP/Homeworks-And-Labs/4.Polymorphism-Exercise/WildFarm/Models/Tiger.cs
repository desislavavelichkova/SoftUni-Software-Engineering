
namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        private const double foodEatenConst = 1.00;
        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, foodEatenConst, livingRegion, breed)
        { }
        public override string Talk()
        {
            return "ROAR!!!";
        }
    }
}
