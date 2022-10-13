using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int nPeople = int.Parse(Console.ReadLine());
            int pCapacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (nPeople % pCapacity != 0)
            {
                courses = nPeople / pCapacity;
                courses += 1;
            }
            else
            {
                courses = nPeople / pCapacity;
            }            
            Console.WriteLine(courses);
        }
    }
}
