using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CookingDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();
            Queue<int> liquid = new Queue<int>(liquids);

            var ingredients = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            Stack<int> ingredient = new Stack<int>(ingredients);

            Dictionary<string, int> food = new Dictionary<string, int>();
            food.Add("Bread", 0);
            food.Add("Cake", 0);
            food.Add("Pastry", 0);
            food.Add("Fruit Pie", 0);

            while (liquid.Count != 0 && ingredient.Count != 0)
            {
                int liquidValue = liquid.Peek();
                int ingredientValue = ingredient.Peek();
                int sum = liquid.Peek() + ingredient.Peek();

                if (sum == 25)
                {
                    food["Bread"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (sum == 50)
                {
                    food["Cake"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (sum == 75)
                {
                    food["Pastry"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else if (sum == 100)
                {
                    food["Fruit Pie"]++;
                    liquid.Dequeue();
                    ingredient.Pop();
                }
                else
                {
                    liquid.Dequeue();
                    ingredientValue += 3;
                    ingredient.Pop();
                    ingredient.Push(ingredientValue);
                }
            }

            if (food["Bread"] > 0 && food["Cake"] > 0 && food["Pastry"] > 0 && food["Fruit Pie"] > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquid)}");
            }
            if (ingredient.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredient)}");
            }

            foreach (var item in food.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
