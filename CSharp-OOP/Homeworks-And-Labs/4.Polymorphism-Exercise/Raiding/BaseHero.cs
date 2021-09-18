
namespace Raiding
{
    public abstract class BaseHero
    {
        
        protected BaseHero(string playerName)
        {
            this.PlayerName = playerName;
        }

              
        public string PlayerName { get; private set; }

        public abstract int Power { get; }

        public abstract string CastAbility();

    }
}
