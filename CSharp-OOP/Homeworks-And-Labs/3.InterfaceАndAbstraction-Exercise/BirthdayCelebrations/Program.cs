using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthdaysData = new List<IBirthable>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] data = input.Split(" ");

                if (data[0].ToLower() == "citizen")
                {
                    string name = data[1];
                    int age = int.Parse(data[2]);
                    string id = data[3];
                    string birthdate = data[4];

                    Citizen person = new Citizen(name, age, id, birthdate);
                    birthdaysData.Add(person);

                }
                else if (data[0].ToLower() == "pet")
                {
                    string name = data[1];
                    string birthdate = data[2];
                    Pet pet = new Pet(name, birthdate);
                    birthdaysData.Add(pet);
                }

                input = Console.ReadLine();
            }

            string year = Console.ReadLine();

            List<IBirthable> filteredYears = birthdaysData.Where(x => x.Birthdate.EndsWith(year)).ToList();

            if (filteredYears.Count == 0)
            {               
                Environment.Exit(0);
            }
            foreach (var filtered in filteredYears)
            {
                Console.WriteLine(filtered.Birthdate);
            }
        }
    }
}
