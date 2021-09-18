using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToList();
            List<int> secondList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToList();
            List<int> thirdList = new List<int>();
            List<int> finalList = new List<int>();

            int countList = 0;
            int firstNumber = 0;
            int secondNumber = 0;

            if (firstList.Count > secondList.Count)
            {
                countList = secondList.Count;

                for (int i = 0; i < countList; i++)
                {
                    thirdList.Add(firstList[i]);
                    thirdList.Add(secondList[countList - 1 - i]);
                }
                firstNumber = firstList[countList];
                secondNumber = firstList[countList + 1];

            }
            else
            {
                countList = firstList.Count;

                for (int i = 0; i < countList; i++)
                {
                    thirdList.Add(firstList[i]);
                    thirdList.Add(secondList[secondList.Count - 1 - i]);
                }
                firstNumber = secondList[countList];
                secondNumber = secondList[countList - 1];
            }

            if (firstNumber > secondNumber)
            {
                for (int i = 0; i < thirdList.Count; i++)
                {
                    int currNum = thirdList[i];

                    if (currNum > secondNumber && currNum < firstNumber)
                    {
                        finalList.Add(currNum);
                    }
                }
            }
            else
            {
                for (int i = 0; i < thirdList.Count; i++)
                {
                    int currNum = thirdList[i];

                    if (currNum > firstNumber && currNum < secondNumber)
                    {
                        finalList.Add(currNum);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", finalList.OrderBy(x => x)));
        }
    }
}
