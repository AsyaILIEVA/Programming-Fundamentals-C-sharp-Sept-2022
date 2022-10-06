using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] people = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                people [i] = currNumber;
                sum += currNumber;
                
            }
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(sum);
        }
    }
}
