using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    public class Program
    {
        public static void Main()
        {
            var resourceAndQuantity = new Dictionary<string, int>();

            string input = string.Empty;
            int quantity = 0;

            while ((input = Console.ReadLine()) != "stop")
            {
                quantity = int.Parse(Console.ReadLine());

                if (!resourceAndQuantity.ContainsKey(input))
                {
                    resourceAndQuantity[input] = quantity;
                }
                else
                {
                    resourceAndQuantity[input] += quantity;
                }
            }

            foreach (var kvp in resourceAndQuantity)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
