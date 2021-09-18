
namespace Raiding
{
    public class Paladin: BaseHero
    {
        private const int power = 100;
        public Paladin(string playerName)
            : base(playerName)
        { }
        public override int Power => power;

        public override string CastAbility()
        {
            return $"{ this.GetType().Name} - {this.PlayerName} healed for {this.Power}";
        }

    }
}
