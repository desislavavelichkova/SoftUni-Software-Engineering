using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> wrongList = new List<IIdentifiable>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ");

                if (data.Length == 3)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];
                    Citizen person = new Citizen(name, age, id);
                    wrongList.Add(person);
                   
                }
                else if (data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];
                    Robot robot = new Robot(model, id);
                    wrongList.Add(robot);
                }

                input = Console.ReadLine();
            }

            string endsId = Console.ReadLine();

            List<IIdentifiable> newWrongList = wrongList.Where(x => x.Id.EndsWith(endsId)).ToList();

            foreach (var identifieble in newWrongList)
            {
                Console.WriteLine(identifieble.Id);
            }

        }
    }
}
