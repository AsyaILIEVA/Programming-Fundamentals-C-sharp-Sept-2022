using System;

namespace Add_and_Substract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
                        

            SumFirstSecondInt(firstInt, secondInt);
            SubtractSumThirdInt(firstInt, secondInt, thirdInt);

        }
        static int SumFirstSecondInt(int firstInt, int secondInt)
        {
            int sum = firstInt + secondInt;
            return sum;
        }
        static int SubtractSumThirdInt(int firstInt, int secondInt, int thirdInt)
        {
            int result = (firstInt + secondInt) - thirdInt;
            Console.WriteLine(result);
            return result;
        }
        
    }
}
