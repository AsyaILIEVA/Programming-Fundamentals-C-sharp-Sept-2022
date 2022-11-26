using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                students[name].Add(grade);
            }
            foreach (var kvp in students
                .Where(x => x.Value.Average(x => x) >= 4.50))                
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average(x => x):f2}");
            }

        }
    }
}
