using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> person = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person currPerson = new Person(name, age);

                if (currPerson.Age > 30)
                {
                    person.Add(currPerson);
                }
                
            }
            foreach (var name in person.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{name.Name} - {name.Age}");
            }
        }
    }
}
