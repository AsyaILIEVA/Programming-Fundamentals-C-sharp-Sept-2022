using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0;

            switch (groupType)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday": pricePerPerson = 8.45; break;
                        case "Saturday": pricePerPerson = 9.80; break;
                        case "Sunday": pricePerPerson = 10.46; break;
                    }
                    if (peopleCount >= 30)
                    {
                        pricePerPerson *= 0.85;
                    }
                    break;

                case "Business":
                    switch (day)
                    {
                        case "Friday": pricePerPerson = 10.90; break;
                        case "Saturday": pricePerPerson = 15.60; break;
                        case "Sunday": pricePerPerson = 16.00; break;
                    }
                    if (peopleCount >= 100)
                    {
                        peopleCount -= 10;
                    }
                    break;

                case "Regular":
                    switch (day)
                    {
                        case "Friday": pricePerPerson = 15.00; break;
                        case "Saturday": pricePerPerson = 20.00; break;
                        case "Sunday": pricePerPerson = 22.50; break;                            
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        pricePerPerson *= 0.95;
                    }
                    break;                    
            }

            double totalPrice = peopleCount * pricePerPerson;
            Console.WriteLine($"Total price: {totalPrice:F2}");

        }
    }
}
