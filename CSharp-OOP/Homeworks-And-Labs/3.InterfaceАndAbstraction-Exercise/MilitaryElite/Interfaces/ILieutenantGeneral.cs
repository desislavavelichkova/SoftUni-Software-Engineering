
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ILieutenantGeneral:IPrivate
    {
        List<ISoldier> Privates { get; }
    }
}
