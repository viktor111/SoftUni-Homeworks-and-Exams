using System;
using System.Text;

namespace _04CaesarCipher
{
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (var symbol in input)
            {
                char encryptedSymbol = (char)(symbol + 3);
                sb.Append(encryptedSymbol);
            }
            Console.WriteLine(sb);
        }
    }
}
