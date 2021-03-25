using System;
using Extensions;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");
            var parsedUserInput = (Console.ReadLine()).IsValidIntegerandWithinBounds(1,10);
            while (!parsedUserInput.Item1)
            {
                Console.Write($"{parsedUserInput.Item2}: ");
                parsedUserInput = (Console.ReadLine()).IsValidIntegerandWithinBounds(1, 10);
            }

            Console.WriteLine(parsedUserInput.Item2);
        }
    }
}
