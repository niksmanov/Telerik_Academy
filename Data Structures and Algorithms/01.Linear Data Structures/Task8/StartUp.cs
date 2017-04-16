using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class StartUp
    {
        static void Main()
        {
            var sequence = Console.ReadLine().Split(new char[] { ',', ' ' },
             StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //var sequence = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var output = new StringBuilder();
            Array.Sort(sequence);
            var counter = 1;
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    counter++;
                }
                else if (counter == sequence.Length / 2 + 1)
                {
                    output.AppendLine($"The majorant is: {sequence[i]}");
                    counter = 1;
                }
                else
                {
                    counter = 1;
                }
                if (i == sequence.Length - 2 && counter == sequence.Length / 2 + 1)
                {
                    output.AppendLine($"The majorant is: {sequence[i]}");
                }
            }
            if (output.Length == 0)
            {
                output.AppendLine("In this sequence doesn't have majorant!");
            }
            
            Console.WriteLine(output);
        }
    }
}