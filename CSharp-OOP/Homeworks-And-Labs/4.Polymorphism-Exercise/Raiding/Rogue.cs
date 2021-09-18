
namespace Raiding
{
    public class Rogue: BaseHero
    {
        private const int power = 80;
        public Rogue(string playerName)
            : base(playerName)
        { }
        public override int Power => power;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.PlayerName} hit for {this.Power} damage";
        }

    }
}
