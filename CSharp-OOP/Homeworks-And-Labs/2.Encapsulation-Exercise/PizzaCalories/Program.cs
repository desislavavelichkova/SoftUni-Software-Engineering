using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = pizzaData[1];                
                                
                string[] doughtData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string flourType = doughtData[1];
                string bakingTechnique = doughtData[2];
                int weight = int.Parse(doughtData[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);
                Pizza pizza = new Pizza(name, dough);

                while (true)
                {
                    string line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }
                        string[] toppingData = line.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                        string toppingType = toppingData[1];
                        int toppingWeight = int.Parse(toppingData[2]);

                        Topping topping = new Topping(toppingType, toppingWeight);
                        pizza.AddTopping(topping);                   
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetCalorie():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
