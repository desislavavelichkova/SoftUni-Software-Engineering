
namespace Raiding
{
    public class Warrior : BaseHero
    {
        public const int power = 100;

        public Warrior(string playerName)
            : base(playerName)
        { }
        public override int Power => power;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {this.PlayerName} hit for {this.Power} damage";
        }
    }
}
