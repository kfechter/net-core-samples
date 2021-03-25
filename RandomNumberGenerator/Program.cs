using System;
using System.Threading;

namespace RandomNumberGenerator
{
    class Program
    {
        static void RunIntNDoubleRandoms(Random randObj)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Random Integer {i}: {randObj.Next()}");
                Console.WriteLine($"Random Double {i}: {randObj.NextDouble()}");
            }
        }

        static void FixedSeedRandoms(int seed)
        {
            Console.WriteLine($"Random Numbers from Generator with seed {seed}");
            Random seededGenerator = new Random(seed);
            RunIntNDoubleRandoms(seededGenerator);
        }

        static void AutoSeededRandoms()
        {
            Thread.Sleep(1);
            Console.WriteLine("Random Numbers from Generator with automatic seed");
            Random autoSeed = new Random();
            RunIntNDoubleRandoms(autoSeed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Example of Various implementations of the Random class");

            FixedSeedRandoms(123);

            FixedSeedRandoms(456);

            AutoSeededRandoms();
            AutoSeededRandoms();
            AutoSeededRandoms();

            Console.ReadLine();
        }
    }
}
