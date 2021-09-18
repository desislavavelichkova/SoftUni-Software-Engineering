using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public interface IRebel : IPerson, IBuyer
    {
         string Group { get; }
    }
}
