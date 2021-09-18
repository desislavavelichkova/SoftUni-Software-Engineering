using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral: Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, double salary, List<ISoldier> privates)
            : base(id, firstName, lastName, salary)
        {
            Privates = @privates;
        }
        public List<ISoldier> Privates { get; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Privates:");
            foreach (ISoldier @private in this.Privates)
            {
                sb.AppendLine($"  {@private}");
            }
            return sb.ToString().Trim();
        }
    }
}
