using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            RectangleArea(a, b);
        }
        static void RectangleArea (int width, int height)
        {
            int area = (width * height);
            Console.WriteLine(area);
        }
    }
}
