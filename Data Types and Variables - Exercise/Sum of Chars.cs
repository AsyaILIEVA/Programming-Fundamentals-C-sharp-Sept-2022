using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < nLines; i++)
            {
                char currCh = char.Parse(Console.ReadLine());
                int currCode = (int)currCh;

                sum += currCode;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
