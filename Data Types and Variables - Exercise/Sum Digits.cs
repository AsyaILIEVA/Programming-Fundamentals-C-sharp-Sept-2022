using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = num; i > 0; i = i / 10)
            {
                sum += i % 10;                
            }
            Console.WriteLine(sum);

        }
    }
}
