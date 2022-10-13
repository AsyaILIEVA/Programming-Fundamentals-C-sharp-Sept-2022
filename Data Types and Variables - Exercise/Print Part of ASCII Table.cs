using System;

namespace Print_Part_of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCh = int.Parse(Console.ReadLine());
            int lastCh = int.Parse(Console.ReadLine());

            for (int i = firstCh; i <= lastCh; i++)
            {
                char currCh = (char)i;
                Console.Write($"{currCh} ");
            }
        }
    }
}
