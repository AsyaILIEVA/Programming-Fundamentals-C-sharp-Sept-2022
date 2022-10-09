using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());
            int nReduced = n % numbersArray.Length;

            for (int rot = 1; rot <= nReduced; rot++)
            {
                int firstElement = numbersArray[0];

                for (int i = 0; i <= numbersArray.Length - 2; i++)
                {
                    numbersArray[i] = numbersArray[i + 1];
                }
                numbersArray[numbersArray.Length - 1] = firstElement;
            }

            Console.WriteLine(string.Join(" ", numbersArray));

        }
    }
}
