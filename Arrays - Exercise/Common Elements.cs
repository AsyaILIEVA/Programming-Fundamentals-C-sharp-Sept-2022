using System;
using System.Linq;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            string result = " ";

            foreach (var item in secondArray)
            {
                if (firstArray.Contains(item))
                {
                    result += " " + item;
                }
            }
            Console.WriteLine($"{result.Trim()}");
        }
    }
}
