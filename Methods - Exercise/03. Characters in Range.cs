using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstCh = char.Parse(Console.ReadLine());
            char secondCh = char.Parse(Console.ReadLine());

            PrintBtwTwoChars(firstCh, secondCh);

        }
        static void PrintBtwTwoChars(char firstCh, char secondCh) 
        {

            int startCharacter = Math.Min(firstCh, secondCh);
            int endCharacter = Math.Max(firstCh, secondCh);

            for (int i = ++startCharacter; i < endCharacter; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
        


    }
}
