using System;

namespace DateModifierProblem
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            int days = DateModifier.GetDifferensBetweenDays(firstDate, secondDate);
            Console.WriteLine(days);
        }
    }
}
