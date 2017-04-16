using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Task1
{
    class StartUp
    {
        static void Main()
        {
            var sequence = new List<int>();
            double sum = 0;
            var input = Console.ReadLine();

            while (input != string.Empty)
            {
                var number = int.Parse(input);
                sequence.Add(number);
                sum += number;
                input = Console.ReadLine();
            }

            var average = sum / sequence.Count;

            var output = new StringBuilder();
            output.AppendLine("Sum: " + sum);
            output.AppendLine("Average: " + average);
            output.AppendLine("Sequence: " + string.Join(", ", sequence));

            Console.WriteLine(output.ToString());
        }
    }
}
