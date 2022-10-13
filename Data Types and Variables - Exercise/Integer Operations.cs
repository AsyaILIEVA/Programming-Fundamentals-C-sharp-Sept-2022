using System;
using System.Linq;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long addOpp = (long)firstNumber + secondNumber;
            long divideOpp = addOpp / thirdNumber;
            long multiplyOpp = divideOpp * fourthNumber;

            Console.WriteLine(multiplyOpp); 
        }
    }
}
