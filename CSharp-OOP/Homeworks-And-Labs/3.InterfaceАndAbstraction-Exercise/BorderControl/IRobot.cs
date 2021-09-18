using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    interface IRobot : IIdentifiable
    {
       string Model { get; }
    }
}
