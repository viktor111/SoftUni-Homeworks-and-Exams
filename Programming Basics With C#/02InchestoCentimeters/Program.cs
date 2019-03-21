using System;

namespace IncheToCentimeters 

{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("inches = ");

            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;

            Console.WriteLine($"Centimeters {centimeters}");
        }
    }
}
