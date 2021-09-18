using System;
using System.Text;
using WildFarm.Models;

namespace WildFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StringBuilder sbTalk = new StringBuilder();
            StringBuilder sbAnimals = new StringBuilder();

            while (true)
            {
                Animal animal = null;

                string[] animalData = Console.ReadLine().Split();

                if (animalData[0] == "End")
                {
                    break;
                }

                string animalType = animalData[0];
                string name = animalData[1];
                double weight = double.Parse(animalData[2]);

                if (animalType == nameof(Owl))
                {
                    double wingSize = double.Parse(animalData[3]);
                    animal = new Owl(name, weight, wingSize);

                }
                else if (animalType == nameof(Hen))
                {
                    double wingSize = double.Parse(animalData[3]);
                    animal = new Hen(name, weight, wingSize);
                }
                else if (animalType == nameof(Mouse))
                {
                    string livingRegion = animalData[3];
                    animal = new Mouse(name, weight, livingRegion);
                }
                else if (animalType == nameof(Dog))
                {
                    string livingRegion = animalData[3];
                    animal = new Dog(name, weight, livingRegion);
                }
                else if (animalType == nameof(Cat))
                {
                    string livingRegion = animalData[3];
                    string breed = animalData[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                }
                else if (animalType == nameof(Tiger))
                {
                    string livingRegion = animalData[3];
                    string breed = animalData[4];

                    animal = new Tiger(name, weight, livingRegion, breed);
                }

                sbTalk.AppendLine(animal.Talk());


                string[] foodData = Console.ReadLine().Split();
                string foodType = foodData[0];
                int foodQuantity = int.Parse(foodData[1]);

                if (animalType == nameof(Mouse) &&
                    foodType != nameof(Vegetable) &&
                    foodType != nameof(Fruit))
                {
                    sbTalk.AppendLine($"{animalType} does not eat {foodType}!");
                    foodData[1] = "0";
                }
                else if (animalType == nameof(Cat) && (foodType != nameof(Vegetable) && foodType != nameof(Meat)))
                {
                    sbTalk.AppendLine($"{animalType} does not eat {foodType}!");
                    foodData[1] = "0";
                }
                else if (animalType == nameof(Tiger) || animalType == nameof(Dog) || animalType == nameof(Owl) && foodType != nameof(Meat))
                {
                    sbTalk.AppendLine($"{animalType} does not eat {foodType}!");
                    foodData[1] = "0";
                }

                sbAnimals.AppendLine(animal.ToString(foodData[1]));

            }
            Console.Write(sbTalk);
            Console.WriteLine(sbAnimals);
        }

    }
}
