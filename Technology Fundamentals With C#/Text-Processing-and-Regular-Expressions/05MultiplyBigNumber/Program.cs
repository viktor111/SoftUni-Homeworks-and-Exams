using System;
using System.Text;

namespace Multiply_by_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string textOfFirstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int decimalPart = 0;
            int lastDigit = 0;
            int prevousDecimalPart = 0;

            for (int i = textOfFirstNumber.Length - 1; i >= 0; i--)
            {

                string currentNumber = textOfFirstNumber[i].ToString();
                int currentResult = int.Parse(currentNumber) * secondNumber;

                decimalPart = currentResult / 10;
                lastDigit = currentResult % 10 + prevousDecimalPart;
                if (lastDigit <= 9)
                {
                    result.Append(lastDigit);
                }
                else
                {
                    result.Append(lastDigit % 10);
                    decimalPart++;
                }

                prevousDecimalPart = decimalPart;
                if (i == 0 && decimalPart != 0)
                {
                    result.Append(decimalPart);
                }
            }
            string output = Reverse(result.ToString());
            if (secondNumber == 0 || textOfFirstNumber == "0")
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(output);
            }


        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
