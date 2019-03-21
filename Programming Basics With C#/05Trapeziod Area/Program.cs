using System;

namespace _05Trapeziod_Area
{
    public class Program
    {
        public static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var sum = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid sum = " + sum);
        }
    }
}
