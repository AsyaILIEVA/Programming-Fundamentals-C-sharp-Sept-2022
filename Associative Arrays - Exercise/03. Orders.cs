using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> product = new Dictionary<string, List<decimal>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();

                string key = input[0];

                if (key.ToLower() == "buy")
                {
                    break;
                }

                decimal price = decimal.Parse(input[1]);
                decimal count = decimal.Parse(input[2]);

                if (!product.ContainsKey(key))
                {
                    product.Add(key, new List<decimal>() { price, count });
                }
                else
                {
                    product[key][0] = price;
                    product[key][1] += count;
                }
            }
            foreach (var item in product)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }
        }
    }
}
