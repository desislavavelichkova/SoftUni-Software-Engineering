
namespace Raiding
{
    public class Druid: BaseHero
    {
        private const int power = 80;
        public Druid(string playerName)
            : base(playerName)
        {  }
        public override int Power => power;

        public override string CastAbility()
        {
            return $"{ this.GetType().Name} - {this.PlayerName} healed for {this.Power}";
        }
    }
}
