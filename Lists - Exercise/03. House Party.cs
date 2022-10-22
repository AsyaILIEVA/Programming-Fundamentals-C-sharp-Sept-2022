using System;
using System.Linq;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestlist = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = cmdArgs[0];

                if (cmdArgs.Length == 3)
                {
                    if (guestlist.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestlist.Add(name);
                }
                else if (cmdArgs.Length == 4)
                {
                    if (!guestlist.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestlist.Remove(name);
                }
            }
            PrintItemsOnNewLine(guestlist);
            //string.Join(Environment.NewLine, guestlist);
        }
        static void PrintItemsOnNewLine(List<string> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
