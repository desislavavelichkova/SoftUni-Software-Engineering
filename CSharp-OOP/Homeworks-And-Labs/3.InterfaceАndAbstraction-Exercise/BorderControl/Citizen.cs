
using System.Collections.Generic;

namespace BorderControl
{
    public class Citizen : IPerson, IIdentifiable
    {
        private List<Citizen> people;
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
            people = new List<Citizen>();
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        
        public void AddCitizen(Citizen person)
        {
            people.Add(person);            
        }
    }
}
