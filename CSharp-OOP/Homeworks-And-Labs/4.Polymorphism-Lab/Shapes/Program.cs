using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape = null;
            string input = Console.ReadLine();

            if (input == "Circle")
            {
                int radius = int.Parse(Console.ReadLine());
                shape = new Circle(radius);
            }
            else if (input == "Rectangle")
            {
                double wigth = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                shape = new Rectangle(height, wigth);
            }            

            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.Draw());
        }
    }
}
