using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] maleData = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] femaleData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> male = new Stack<int>(maleData);
            Queue<int> female = new Queue<int>(femaleData);

            int matchesCount = 0;

            while (true)
            {
                if (male.Count == 0)
                {
                    break;
                }
                if (female.Count == 0)
                {
                    break;
                }

                int maleAge = male.Peek();
                int femaleAge = female.Peek();

                if (maleAge == 0)
                {
                    male.Pop();
                    maleAge = male.Peek();
                    if(maleAge == 0)
                    {
                        male.Pop();
                        maleAge = male.Peek();
                    }
                }
                if (femaleAge == 0)
                {
                    female.Dequeue();
                    femaleAge = female.Peek();
                    if (femaleAge == 0)
                    {
                        female.Dequeue();
                        femaleAge = female.Peek();
                    }
                }
                if (femaleAge == 25)
                {
                    if (female.Count == 2)
                    {
                      female.Dequeue();
                      female.Dequeue();                    
                        break;
                    }
                    if (female.Count == 1)
                    {
                        female.Dequeue();                        
                        break;
                    }

                    female.Dequeue();
                    female.Dequeue();
                    femaleAge = female.Peek();
                }

                if (maleAge == 25)
                {
                    if (male.Count == 2)
                    {
                        male.Pop();
                        male.Pop();
                        break;
                    }
                    if (male.Count == 1)
                    {
                        male.Pop();
                        break;
                    }

                    male.Pop();
                    male.Pop();
                    femaleAge = male.Peek();
                }
                if (femaleAge == maleAge)
                {
                    male.Pop();
                    female.Dequeue();
                    matchesCount++;
                }
                else
                {
                    if(maleAge == 0)
                    {
                        male.Pop();
                        maleAge = male.Peek();
                    }
                    if (femaleAge == 0)
                    {
                        female.Dequeue();
                        femaleAge = female.Peek();
                    }
                    female.Dequeue();
                    male.Pop();
                    male.Push(maleAge / 2);
                }
            }
            Console.WriteLine($"Matches: {matchesCount}");

            if (male.Count == 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", male)}");
            }
            if (female.Count == 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", female)}");
            }

        }
    }
}
