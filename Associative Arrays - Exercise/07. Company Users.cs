using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] inputArray = input.Split(" -> ");
                string companyName = inputArray[0];
                string employeeID = inputArray[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }
                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
