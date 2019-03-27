using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Count_Chars_in_a_String
{
    public class Program
    {
        public static void Main()
        {
            char[] text = Console.ReadLine()
                .Where(x => x != ' ')
                .ToArray();

            var countChars = new Dictionary<char, int>();

            foreach (var charechter in text)
            {
                if (!countChars.ContainsKey(charechter))
                {
                    countChars[charechter] = 0;
                }
                countChars[charechter]++;
            }

            foreach (var kvp in countChars)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
