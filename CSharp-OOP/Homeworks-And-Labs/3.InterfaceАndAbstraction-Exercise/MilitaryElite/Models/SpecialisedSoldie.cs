using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldie: Private, ISpecialisedSoldier
    {
        public SpecialisedSoldie(int id, string firstName, string lastName, double salary, string corp)
            : base(id, firstName, lastName, salary)
        {
            Corp = corp;
        }

        public string Corp { get; }
        
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Corps: {Corp}");
            return sb.ToString();
        }
    }
}
