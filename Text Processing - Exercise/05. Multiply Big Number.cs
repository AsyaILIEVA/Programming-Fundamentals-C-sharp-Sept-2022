using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInt = BigInteger.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());

            Console.WriteLine(bigInt * digit);
        }
    }
}
