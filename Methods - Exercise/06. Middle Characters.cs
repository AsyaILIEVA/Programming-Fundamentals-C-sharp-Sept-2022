using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            GetTheMiddleChar(word);
        }
        static void GetTheMiddleChar(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.WriteLine(word.Substring((word.Length / 2) - 1, 2));
            }
            else
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
}
