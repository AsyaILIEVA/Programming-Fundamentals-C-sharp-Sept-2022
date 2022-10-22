using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> peopleCount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());

            string command = "";
            int morePeople = 0;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(" ");
                if (cmdArgs.Length == 1)
                {
                    morePeople = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < peopleCount.Count; i++)
                    {
                        if (peopleCount[i] + morePeople <= wagonCapacity)
                        {
                            peopleCount[i] += morePeople;
                            break;
                        }
                    }
                }
                else
                {
                    morePeople = int.Parse(cmdArgs[1]);
                    peopleCount.Add(morePeople);
                }                
            }
            string result = string.Join(" ", peopleCount);
            Console.WriteLine(result);
        }
    }
}
