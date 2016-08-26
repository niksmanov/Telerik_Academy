using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class largerThanNeighbours
{
    static int LargerNumber(int[] numbers)
    {
        int count = 0;
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int arr = int.Parse(Console.ReadLine());
        int[] numbers = new int[arr];
        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        Console.WriteLine(LargerNumber(numbers));
    }
}

