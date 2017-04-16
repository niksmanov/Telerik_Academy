using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class StartUp
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] < 0)
                {
                    sequence.RemoveAt(i);
                    i--;
                }               
            }

            Console.WriteLine("Sequence without negative numbers: " + string.Join(", ", sequence));
        }
    }
}
