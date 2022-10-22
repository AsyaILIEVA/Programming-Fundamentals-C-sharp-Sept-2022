using System;
using System.Linq;
using System.Collections.Generic;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] cmdArgs = line.Split();
                string command = cmdArgs[0];
                int element = int.Parse(cmdArgs[1]);

                if (command == "Delete")
                {
                    inputList.RemoveAll(x => x == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    inputList.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
