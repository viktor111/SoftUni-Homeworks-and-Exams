using System;

namespace _04Concatenate_Data
{
    public class Program
    {
        public static void Main()
        {
            var firstname = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine($"You are {firstname} {lastName}, a {age} -years old person from {town}.");
        }
    }
}
