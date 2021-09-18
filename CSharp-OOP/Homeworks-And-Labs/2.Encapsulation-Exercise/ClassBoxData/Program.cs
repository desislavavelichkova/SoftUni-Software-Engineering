using System;
using System.Linq;
using System.Reflection;

namespace _01.ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {               

                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(length, width, height);
                Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());
                Console.WriteLine("Volume - {0:F2}", box.Volume());
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
