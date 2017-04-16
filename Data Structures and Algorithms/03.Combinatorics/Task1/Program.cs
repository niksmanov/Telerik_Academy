using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            uint asterisksCount = 0;

            foreach (var el in input)
            {
                if (el == '*')
                {
                    asterisksCount++;
                }
            }

            Console.WriteLine((ulong)Math.Pow(2, asterisksCount)); //2 because we have two choices 1 and 0
        }
    }
}
