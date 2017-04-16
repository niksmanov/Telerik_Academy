using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class StartUp
    {
        static void Main()
        {
            var sequence = new List<int>();
            var input = Console.ReadLine();

            while (input != string.Empty)
            {
                var number = int.Parse(input);
                sequence.Add(number);
                input = Console.ReadLine();
            }
            sequence.Sort();

            Console.WriteLine("Sequence: " + string.Join(", ", sequence));
        }
    }
}
