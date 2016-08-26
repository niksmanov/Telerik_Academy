using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class largestNumber
    {
        static void PrintMax(int[] numbers)
        {
            int maxNumber = 0;
            foreach (var number in numbers)
            {
                maxNumber = numbers.Max();
            }
            Console.WriteLine(maxNumber);
        }

        static void Main()
        {
            string[] stringInput = Console.ReadLine().Split(' ');
            int[] input = new int[stringInput.Length];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(stringInput[i]);
            }
            PrintMax(input);

        }
    }
