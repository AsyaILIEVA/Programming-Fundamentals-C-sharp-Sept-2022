using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charOcc = new Dictionary<char, int>();

            foreach (var ch in text)
            {
                if (!charOcc.ContainsKey(ch))
                {
                    charOcc.Add(ch, 1);
                }
                else if (charOcc.ContainsKey(ch))
                {
                    charOcc[ch]++;
                }
            }
            foreach (KeyValuePair<char, int> ch in charOcc.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            } 
        }
    }
}
