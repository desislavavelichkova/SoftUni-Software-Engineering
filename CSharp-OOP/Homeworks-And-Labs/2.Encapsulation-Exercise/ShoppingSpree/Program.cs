using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();
            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }                

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var data = input.Split();

                var personName = data[0];
                var productName = data[1];


                try
                {
                    var person = people[personName];
                    var product = products[productName];
                    person.AddProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                                
            }

            foreach (var person in people.Values)
            {
                Console.WriteLine(person);
            }
        }

        private static Dictionary<string, Product> ReadProducts()
        {
            var result = new Dictionary<string, Product>();

            var parts = Console.ReadLine()
                        .Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var productData = part.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var nameOfProduct = productData[0];
                var cost = double.Parse(productData[1]);

                result[nameOfProduct] = new Product(nameOfProduct, cost);
            }

            return result;
        }

        private static Dictionary<string, Person> ReadPeople()
        {
            var result = new Dictionary<string, Person>();

            var parts = Console.ReadLine()
                        .Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var personData = part.Split("=", StringSplitOptions.RemoveEmptyEntries);
                var name = personData[0];
                var money = double.Parse(personData[1]);

                result[name] = new Person(name, money);
            }

            return result;
        }
    }
}
