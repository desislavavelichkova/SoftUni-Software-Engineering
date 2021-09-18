using System;

namespace _11.RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Length: ");
            double dul = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double sh = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double h = double.Parse(Console.ReadLine());
            double V = (dul * sh * h) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
