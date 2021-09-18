
using System.Collections.Generic;

namespace BorderControl
{
    public class Robot: IRobot, IIdentifiable
    {
         public List<Robot> robots;

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
            robots = new List<Robot>();
        }

        public string Model { get; set; }
        public string Id { get; set; }

        public void AddRobot(Robot robot)
        {
            robots.Add(robot);
        }
    }
}
