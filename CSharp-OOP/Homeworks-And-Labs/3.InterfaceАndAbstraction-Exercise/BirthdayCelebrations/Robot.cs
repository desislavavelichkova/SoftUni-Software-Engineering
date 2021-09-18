
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    public class Robot: IRobot, IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
            
        }

        public string Model { get; set; }
        public string Id { get; set; }

    }
}
