using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topIntegers = new int[inputArr.Length];
            int topInteger = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                int currNum = inputArr[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    int nextNum = inputArr[j];

                    if (nextNum >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topInteger] = currNum;
                    topInteger++;
                }

            }
            for (int i = 0; i < topInteger; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }

        }
    }
}
