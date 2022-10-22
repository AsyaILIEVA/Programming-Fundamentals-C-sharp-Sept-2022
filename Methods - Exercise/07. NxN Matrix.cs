using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNMatrix(n);
        }
        static void PrintNMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{n} ");

                for (int j = 0; j < n-1; j++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
            }
        }
    }
}
