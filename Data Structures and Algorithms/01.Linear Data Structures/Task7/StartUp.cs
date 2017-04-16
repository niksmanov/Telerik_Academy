using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class StartUp
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ',', ' ' },
              StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //var sequence = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            var output = new StringBuilder();
            Array.Sort(sequence);
            var counter = 1;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                }
                else
                {
                    output.AppendLine($"{sequence[i]} -> {counter} times");
                    counter = 1;
                }
                if (i == sequence.Length - 2)
                {
                    output.AppendLine($"{sequence[i]} -> {counter} times");
                }
            }
            Console.WriteLine(output);
        }
    }
}

