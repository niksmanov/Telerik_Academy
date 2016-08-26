using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class seriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            //string newInput = input + '|';
            List<char> output = new List<char>();

            for (int i = 0; i < input.Length-1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    continue;
                }
                else
                {
                    output.Add(input[i]);
                }
            }
            output.Add(input.Last());
            Console.WriteLine(string.Join("", output));
        }
    }
