using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resources = new Dictionary<string, long>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }
            foreach (var rqp in resources)
            {
                string currResource = rqp.Key;
                long resourceQty = rqp.Value;

                Console.WriteLine($"{currResource} -> {resourceQty}");
            }
        }
    }
}
