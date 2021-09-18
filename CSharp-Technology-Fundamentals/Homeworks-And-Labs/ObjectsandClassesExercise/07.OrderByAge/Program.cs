using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> people = new List<People>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] cmndArgs = input.Split();

                string name = cmndArgs[0];
                string numberID = cmndArgs[1];
                int age = int.Parse(cmndArgs[2]);

                People person = new People(name, numberID, age);

                people.Add(person);
                input = Console.ReadLine();
            }

            foreach (var item in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{item.Name} with ID: {item.IDNumber} is {item.Age} years old.");
            }
        }
    }
    class People
    {
        public People (string name, string numberID, int age )
        {
            Name = name;
            IDNumber = numberID;
            Age = age;
        }
        public string Name { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
    }
}
